using System.Data;
using System.Xml.Linq;
using Versao.Data;

namespace Versao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CarregarXml();
        }

        public string strCaminhoBanco { get; set; }

        #region Métodos

        public void CarregarXml()
        {
            if (File.Exists("config.xml"))
            {
                XElement xml = XElement.Load("config.xml");
                string? caminhoBanco = xml.Element("DatabasePath")?.Value;
                string? porta = xml.Element("Port")?.Value;
                string? automaticClose = xml.Element("AutomaticSave")?.Value;

                Conexao.i.connectionString = $@"Server=localhost;Port={porta};User=SYSDBA;Password=masterkey;Database={caminhoBanco}";
                this.txtBanco.Text = caminhoBanco;
                this.txtVersaoAtual.Text = this.getVersaoAtual();
                this.numNovaVersao.Value = int.Parse(this.txtVersaoAtual.Text);
                this.txtPorta.Text = porta;
                this.ckbFecharAposUpdate.Checked = automaticClose == "1" ? true : false;
            }
        }

        private string? getVersaoAtual()
        {
            string strSql = @"SELECT versao.valor
                      FROM versao
                      WHERE versao.versaoid = 1";

            DataTable tabela = DbFirebird.i.ExecutarSelect(strSql);

            string? strResultado = string.Empty;

            if (tabela.Rows.Count > 0)
            {
                strResultado = tabela.Rows[0]["valor"].ToString();
            }

            return strResultado;
        }

        public void SelecionarBanco()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Firebird Database (*.fdb)|*.fdb";
            dialog.Title = "Selecione o arquivo do banco de dados";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(this.txtPorta.Text))
                {
                    MessageBox.Show("Informe uma porta válida");
                    return;
                }

                string caminhoBanco = dialog.FileName;
                Conexao.i.connectionString = $@"Server=localhost;Port={this.txtPorta.Text};User=SYSDBA;Password=masterkey;Database={caminhoBanco}";

                this.strCaminhoBanco = strCaminhoBanco;
                this.SalvarXml(caminhoBanco);

                MessageBox.Show("Caminho salvo com sucesso!");
            }
        }

        private void AtualizarVersao()
        {
            if (this.numNovaVersao.Value <= 0)
            {
                MessageBox.Show("A versão não pode ser menor ou igual a zero.");
                return;
            }

            string strUpdate = $@"update versao set versao.valor = {this.numNovaVersao.Value} where versao.versaoid = 1";

            DbFirebird.i.ExecutarComando(strUpdate);

            MessageBox.Show("Versão atualizada com sucesso.");

            if (this.ckbFecharAposUpdate.Checked)
                this.Close();
        }

        private void SalvarXml(string caminhoBanco)
        {
            XElement xml = new XElement("Configuracao",
                new XElement("DatabasePath", caminhoBanco),
                new XElement("Port", this.txtPorta.Text),
                new XElement("AutomaticSave", this.ckbFecharAposUpdate.Checked ? "1" : 0)

            );

            xml.Save("config.xml");
        }

        #endregion Métodos

        #region Eventos

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.AtualizarVersao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelecionarbanco_Click(object sender, EventArgs e)
        {
            try
            {
                this.SelecionarBanco();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Eventos

        private void ckbFecharAposUpdate_CheckStateChanged(object sender, EventArgs e)
        {
            this.SalvarXml(this.txtBanco.Text);
        }
    }
}
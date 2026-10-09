namespace Versao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSelecionarbanco = new Button();
            txtBanco = new TextBox();
            numNovaVersao = new NumericUpDown();
            btnAtualizar = new Button();
            txtVersaoAtual = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPorta = new TextBox();
            label4 = new Label();
            btnFecha = new Button();
            ckbFecharAposUpdate = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numNovaVersao).BeginInit();
            SuspendLayout();
            // 
            // btnSelecionarbanco
            // 
            btnSelecionarbanco.Location = new Point(304, 80);
            btnSelecionarbanco.Name = "btnSelecionarbanco";
            btnSelecionarbanco.Size = new Size(76, 23);
            btnSelecionarbanco.TabIndex = 1;
            btnSelecionarbanco.Text = "Selecionar";
            btnSelecionarbanco.UseVisualStyleBackColor = true;
            btnSelecionarbanco.Click += btnSelecionarbanco_Click;
            // 
            // txtBanco
            // 
            txtBanco.BackColor = SystemColors.Menu;
            txtBanco.BorderStyle = BorderStyle.FixedSingle;
            txtBanco.Location = new Point(83, 80);
            txtBanco.Name = "txtBanco";
            txtBanco.ReadOnly = true;
            txtBanco.Size = new Size(215, 23);
            txtBanco.TabIndex = 2;
            // 
            // numNovaVersao
            // 
            numNovaVersao.Location = new Point(83, 51);
            numNovaVersao.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numNovaVersao.Name = "numNovaVersao";
            numNovaVersao.Size = new Size(120, 23);
            numNovaVersao.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(169, 109);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(118, 23);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtVersaoAtual
            // 
            txtVersaoAtual.BackColor = SystemColors.Menu;
            txtVersaoAtual.BorderStyle = BorderStyle.FixedSingle;
            txtVersaoAtual.Location = new Point(83, 6);
            txtVersaoAtual.Name = "txtVersaoAtual";
            txtVersaoAtual.ReadOnly = true;
            txtVersaoAtual.Size = new Size(67, 23);
            txtVersaoAtual.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "Versão atual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 83);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Banco:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 54);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 7;
            label3.Text = "Nova versão:";
            // 
            // txtPorta
            // 
            txtPorta.BackColor = SystemColors.ButtonHighlight;
            txtPorta.BorderStyle = BorderStyle.FixedSingle;
            txtPorta.Location = new Point(83, 109);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new Size(80, 23);
            txtPorta.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 113);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "Porta:";
            // 
            // btnFecha
            // 
            btnFecha.Location = new Point(129, 152);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(118, 23);
            btnFecha.TabIndex = 11;
            btnFecha.Text = "&Fechar";
            btnFecha.UseVisualStyleBackColor = true;
            btnFecha.Click += btnFechar_Click;
            // 
            // ckbFecharAposUpdate
            // 
            ckbFecharAposUpdate.AutoSize = true;
            ckbFecharAposUpdate.Location = new Point(248, 7);
            ckbFecharAposUpdate.Name = "ckbFecharAposUpdate";
            ckbFecharAposUpdate.Size = new Size(132, 19);
            ckbFecharAposUpdate.TabIndex = 12;
            ckbFecharAposUpdate.Text = "Fechar após update.";
            ckbFecharAposUpdate.UseVisualStyleBackColor = true;
            ckbFecharAposUpdate.CheckStateChanged += ckbFecharAposUpdate_CheckStateChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 186);
            Controls.Add(ckbFecharAposUpdate);
            Controls.Add(btnFecha);
            Controls.Add(label4);
            Controls.Add(txtPorta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtVersaoAtual);
            Controls.Add(btnAtualizar);
            Controls.Add(txtBanco);
            Controls.Add(btnSelecionarbanco);
            Controls.Add(numNovaVersao);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numNovaVersao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSelecionarbanco;
        private TextBox txtBanco;
        private NumericUpDown numNovaVersao;
        private Button btnAtualizar;
        private TextBox txtVersaoAtual;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPorta;
        private Label label4;
        private Button btnFecha;
        private CheckBox ckbFecharAposUpdate;
    }
}

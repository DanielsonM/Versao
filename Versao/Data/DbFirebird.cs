using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Threading.Tasks;

namespace Versao.Data
{
    internal class DbFirebird
    {
        private static DbFirebird? _i;

        public static DbFirebird i
        {
            get
            {
                if(_i == null)
                    return _i = new DbFirebird();

                return _i;
            }
            set
            {
                _i = value;
            }
        }

        // SELECT genérico (assíncrono)
        public async Task<DataTable> ExecutarSelectAsync(string sql, params FbParameter[] parametros)
        {
            DataTable tabela = new DataTable();

            using (FbConnection conn = new FbConnection(Conexao.i.connectionString))
            {
                await conn.OpenAsync(); // não bloqueia a thread

                using (FbCommand cmd = new FbCommand(sql, conn))
                {
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    using (FbDataAdapter adapter = new FbDataAdapter(cmd))
                    {
                        adapter.Fill(tabela); // DataAdapter não tem versão async
                    }
                }
            } // conexão fechada automaticamente aqui

            return tabela;
        }

        // UPDATE / INSERT / DELETE genérico (assíncrono)
        public async Task<int> ExecutarComandoAsync(string sql, params FbParameter[] parametros)
        {
            using (FbConnection conn = new FbConnection(Conexao.i.connectionString))
            {
                await conn.OpenAsync();

                using (FbCommand cmd = new FbCommand(sql, conn))
                {
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    return await cmd.ExecuteNonQueryAsync(); // libera thread
                }
            }
        }

        // Exemplo de SELECT síncrono (se precisar)
        public DataTable ExecutarSelect(string sql, params FbParameter[] parametros)
        {
            DataTable tabela = new DataTable();

            using (FbConnection conn = new FbConnection(Conexao.i.connectionString))
            {
                conn.Open();
                using (FbCommand cmd = new FbCommand(sql, conn))
                {
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    using (FbDataAdapter adapter = new FbDataAdapter(cmd))
                    {
                        adapter.Fill(tabela);
                    }
                }
            }

            return tabela;
        }

        // Exemplo de comando síncrono
        public int ExecutarComando(string sql, params FbParameter[] parametros)
        {
            using (FbConnection conn = new FbConnection(Conexao.i.connectionString))
            {
                conn.Open();
                using (FbCommand cmd = new FbCommand(sql, conn))
                {
                    if (parametros != null)
                        cmd.Parameters.AddRange(parametros);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

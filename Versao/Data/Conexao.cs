using FirebirdSql.Data.FirebirdClient;

namespace Versao.Data
{
    internal class Conexao
    {
        public string? connectionString;
        public string? porta;

        private static Conexao? _i;

        public static Conexao i
        {
            get
            {
                if(_i == null)
                    return _i = new Conexao();

                return _i;
            }
            set
            {
                _i = value;
            }
        }

        public void AbrirConexao()
        {
            using (FbConnection conn = new FbConnection(connectionString))
            {
                conn.Open();
            }
        }

    }
}

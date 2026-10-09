using FirebirdSql.Data.FirebirdClient;

internal class Conexao
{
    public string? connectionString;

    private static  Conexao _i;

    public static Conexao i
    {
        get
        {
            if (_i == null)
                return _i = new Conexao();

            return _i;
        }
        set
        {
            _i = value;
        }
    }

    public Conexao(string conn)
    {
        connectionString = conn;
    }

    public Conexao()
    {
    }

    public void AbrirConexao()
    {
        using (FbConnection conn = new FbConnection(connectionString))
        {
            conn.Open();
        }
    }

    public void ExecutarComando(string sql)
    {
        using (FbConnection conn = new FbConnection(connectionString))
        {
            conn.Open();
            using (FbCommand cmd = new FbCommand(sql, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
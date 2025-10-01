using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public static class Connection
    {
        private static readonly string dbPath = @"C:\Users\daniel.csilva66\Desktop\logistica.db";

        public static readonly string connectionString = $"Data Source={dbPath};Version=3;";

        public static SQLiteConnection ObterConexao()
        {
            try
            {
                var conexao = new SQLiteConnection(connectionString);
                
                    conexao.Open();
                    return conexao;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }
    }
}
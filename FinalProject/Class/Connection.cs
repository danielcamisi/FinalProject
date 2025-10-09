using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace FinalProject
{
    public static class Connection
    {
      
        private static readonly string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logistica.db");

       
        public static readonly string connectionString = $"Data Source={dbPath};Version=3;Foreign Keys=True;";

        
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
                
                throw new Exception("Erro ao conectar ao banco de dados. Detalhe: " + ex.Message);
            }
        }

      
        public static bool BancoExiste()
        {
            return File.Exists(dbPath);
        }

     
        public static void CriarBancoSeNaoExistir()
        {
            if (!BancoExiste())
            {
                
                var createCommands = new List<string>
                {
                    "PRAGMA foreign_keys = ON;", 

                    @"CREATE TABLE VEICULO (
                        VEICULOID INTEGER PRIMARY KEY AUTOINCREMENT,
                        MODELO TEXT NOT NULL,
                        PLACA TEXT NOT NULL UNIQUE,
                        CONSUMO_MEDIO REAL NOT NULL,
                        CARGA_MAXIMA REAL
                    );",

                    @"CREATE TABLE MOTORISTA (
                        MOTORISTAID INTEGER PRIMARY KEY AUTOINCREMENT,
                        NOME TEXT NOT NULL,
                        CNH TEXT NOT NULL UNIQUE,
                        TELEFONE TEXT NOT NULL
                    );",

                    @"CREATE TABLE ROTA (
                        ROTAID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ORIGEM TEXT NOT NULL,
                        DESTINO TEXT NOT NULL,
                        DISTANCIA REAL NOT NULL
                    );",

                    @"CREATE TABLE PRECO_COMBUSTIVEL (
                        PRECOID INTEGER PRIMARY KEY AUTOINCREMENT,
                        COMBUSTIVEL TEXT NOT NULL UNIQUE,
                        PRECO REAL NOT NULL,
                        DATA_CONSULTA DATETIME DEFAULT CURRENT_TIMESTAMP
                    );",

                    @"CREATE TABLE VIAGEM (
                        VIAGEMID INTEGER PRIMARY KEY AUTOINCREMENT,
                        VEICULOID INTEGER NOT NULL,
                        MOTORISTAID INTEGER NOT NULL,
                        ROTAID INTEGER NOT NULL,
                        DATA_SAIDA DATETIME,
                        DATA_CHEGADA DATETIME,
                        SITUACAO TEXT NOT NULL,
                        FOREIGN KEY (VEICULOID) REFERENCES VEICULO(VEICULOID) ON DELETE RESTRICT,
                        FOREIGN KEY (MOTORISTAID) REFERENCES MOTORISTA(MOTORISTAID) ON DELETE RESTRICT,
                        FOREIGN KEY (ROTAID) REFERENCES ROTA(ROTAID) ON DELETE RESTRICT
                    );",

                    @"CREATE TABLE USERS (
                        USERID INTEGER PRIMARY KEY AUTOINCREMENT,
                        uName TEXT NOT NULL,
                        uEmail TEXT NOT NULL UNIQUE,
                        uPword TEXT NOT NULL
                    );"
                };

                try
                {
                    
                    using (var conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        
                        using (var transaction = conn.BeginTransaction())
                        {
                            using (var cmd = new SQLiteCommand(conn))
                            {
                                foreach (var sqlCommand in createCommands)
                                {
                                    cmd.CommandText = sqlCommand;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            transaction.Commit(); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    if (File.Exists(dbPath))
                    {
                        File.Delete(dbPath);
                    }
                    throw new Exception("Falha ao inicializar o banco de dados e as tabelas. Detalhe: " + ex.Message);
                }
            }
        }
    }
}
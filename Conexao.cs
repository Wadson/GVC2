using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace GVC.Helpers
{
    internal class Conexao
    {
        public static SqliteConnection Conex()
        {
            try
            {
                string basePath = AppContext.BaseDirectory;
                string folder = Path.Combine(basePath, "Data");

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string databasePath = Path.Combine(folder, "bdsiscontrol.db");

                if (!File.Exists(databasePath))
                    throw new Exception("❌ Banco de dados não encontrado em: " + databasePath);

                string connString = $"Data Source={databasePath};";

                return new SqliteConnection(connString);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao banco: " + ex.Message, ex);
            }
        }
    }
}

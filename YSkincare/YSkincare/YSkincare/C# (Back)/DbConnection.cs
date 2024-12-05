using System;
using System.Configuration;
using System.Data.SqlClient;

namespace YSkincare.C___Back_
{
    public class DbConnection
    {
        public static string ConnectionString_YS()
        {
            return ConfigurationManager.ConnectionStrings["connection_YS"].ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString_YS());
            try
            {
                connection.Open();
                Console.WriteLine("Conexión exitosa.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
            return connection;
        }
    }
}

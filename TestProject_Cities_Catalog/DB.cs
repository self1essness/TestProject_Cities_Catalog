using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace TestProject_Cities_Catalog
{
    class DB
    {
        private static string ConnectionStringRemote = ConfigurationManager.ConnectionStrings["remoteDataBase"].ConnectionString;
        //private static string ConnectionStringLocal = ConfigurationManager.ConnectionStrings["localDataBase"].ConnectionString;
        MySqlConnection connection = new MySqlConnection(ConnectionStringRemote);

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}

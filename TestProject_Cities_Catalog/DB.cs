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
        static string connectionStringRemote = ConfigurationManager.ConnectionStrings["remoteDataBase"].ConnectionString;
        //static string connectionStringLocal = ConfigurationManager.ConnectionStrings["localDataBase"].ConnectionString;
        MySqlConnection connection = new MySqlConnection(connectionStringRemote);

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

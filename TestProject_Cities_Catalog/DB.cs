using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TestProject_Cities_Catalog
{
    class DB
    {
        //MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=bd_city");
        //MySqlConnection connection = new MySqlConnection("server=sql8.freesqldatabase.com;port=3306;username=sql8517259;password=MJSdrtSVT2;database=sql8517259");
        MySqlConnection connection = new MySqlConnection("server=db4free.net;port=3306;username=db_self1essness;password=Bee424274;database=self1essness");

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

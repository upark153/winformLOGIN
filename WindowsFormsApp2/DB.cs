using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // MYSQL 연결할 첫번째 단계

namespace WindowsFormsApp2
{
    internal class DB
    {
        MySqlConnection connection =  new MySqlConnection
            ("server=localhost; " +
            "port=3306;" +
            "username=root;" +
            "password=0000;" +
            "database=users"); //

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection; // 단순히 연결 자체를 반환한다.
        }
    }
}

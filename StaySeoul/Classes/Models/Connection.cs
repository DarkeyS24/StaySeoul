using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StaySeoul.Classes.Models
{
    internal class Connection
    {
        private MySqlConnection connection;

        public Connection()
        {
            string conString = "server=localhost;uid=root;pwd=;database=WS2019";
            connection = new MySqlConnection(conString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}

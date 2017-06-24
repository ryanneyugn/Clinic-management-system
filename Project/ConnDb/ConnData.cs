using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ConnData
{
    public class ConnData
    {
        private static string Connectionstring;
        private MySqlCommand command;
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;

        public static string Connectionstring1
        {
            get { return ConnData.Connectionstring; }
            set { ConnData.Connectionstring = value; }
        }
        public void OpenConnec()
        {
            connection = new MySqlConnection(Connectionstring1);
            connection.Open();
        }
        public void CloseConnec()
        {
            connection.Close();
        }
        public DataTable executeReader(string sql)
        {
            DataTable tb = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            adapter.Fill(tb);
            return tb;
        }
        public void executeNonQuery(string sql)
        {
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ConnDb
{
    public class ConnData
    {
        private  string Connectionstring;
        private MySqlCommand command;
        private MySqlConnection connection;        

        public ConnData(string connectionString)
        {
            this.Connectionstring = connectionString;
        }
        public void OpenConnec()
        {
            connection = new MySqlConnection(this.Connectionstring);
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

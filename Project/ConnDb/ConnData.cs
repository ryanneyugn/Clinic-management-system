using System.Data;
using MySql.Data.MySqlClient;

namespace ConnDb
{
    public class ConnData
    {        
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlCommand command;

        public ConnData(string server, string database, string uid, string password)
        {
            Initialize(server, database, uid, password);
        }

        private void Initialize(string server, string database, string uid, string password)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.password = password;
            string connectionString = "server=" + this.server + ";" + "database=" + this.database + ";" + "uid=" + this.uid + ";" + "password=" + this.password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public string OpenConnection()
        {
            try {
                connection.Open();
                return "Opened connection";
            } catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        return "Cannot connect to server.  Contact administrator.";
                    case 1045:
                        return "Invalid username/password, please try again.";
                    default:
                        return "Error: " + ex.Message;
                }
            }            
        }

        public string CloseConnection()
        {
            try
            {
                connection.Close();
                return "Connection closed.";
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }

        public DataTable ExecuteReader(string sql)
        {
            DataTable tb = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            adapter.Fill(tb);
            return tb;
        }
        public void ExecuteNonQuery(string sql)
        {
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}

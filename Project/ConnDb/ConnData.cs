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
        private string errormessage;

        public ConnData()
        {            
            server = "localhost";
            database = "qlpk";
            uid = "root";
            password = "123456";
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

        public bool OpenConnection()
        {
            try {
                connection.Open();
                return true;
            } catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        errormessage = "Cannot connect to server.  Contact administrator.";
                        break;
                    case 1045:
                        errormessage = "Invalid username/password, please try again.";
                        break;
                    default:
                        errormessage = "Error: " + ex.Message;
                        break;
                }
                return false;
            }            
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();                
                return true; 
            }
            catch (MySqlException ex)
            {
                errormessage = ex.Message;
                return false;
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

        public string ShowErrorMessage()
        {
            return errormessage;
        }
    }
}

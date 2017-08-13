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

        public MySqlCommand Command { get => command; set => command = value; }
        public MySqlConnection Connection { get => connection; set => connection = value; }

        public ConnData()
        {            
            server = "localhost";
            database = "phongkham";
            uid = "root";
            password = "1";
            Initialize(server, database, uid, password);        
        }

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

            Connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try {
                Connection.Open();
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
                Connection.Close();                
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
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, Connection);
            adapter.Fill(tb);
            return tb;
        }

        public void ExecuteNonQuery(string sql)
        {
            Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }

        public string ShowErrorMessage()
        {
            return errormessage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CentralniServer.Data
{
    public class DBConnection : IDisposable
    {
        private DBConnection()
        {
        }

        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        private MySqlConnection Connection { get; set; }

        private static DBConnection _instance = null;
        //public static DBConnection Instance()
        //{
        //    if (_instance == null)
        //        _instance = new DBConnection();
        //    return _instance;
        //}
        public static DBConnection Instance(string server = "localhost", string database = "ntp2020", string username = "ntp2020_user", string password = "123")
        {
            if (_instance == null)
                _instance = new DBConnection();
            _instance.Server = server;
            _instance.DatabaseName = database;
            _instance.UserName = username;
            _instance.Password = password;
            return _instance;
        }

        public MySqlConnection GetConnection()
        {
            return Connection;
        }

        public bool IsConnected()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(DatabaseName))
                    return false;
                string connString = string.Format("Server={0};Database={1};Uid={2};Pwd={3}", Server, DatabaseName, UserName, Password);
                Connection = new MySqlConnection(connString);
                Connection.Open();
            }

            return true;
        }

        public void Dispose()
        {
            this.Close();
            Connection = null;
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}

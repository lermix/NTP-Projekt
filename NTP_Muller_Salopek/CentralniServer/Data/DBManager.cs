using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CentralniServer.Data
{
    /// <summary>
    /// Class that manages MySQL connection and closes it in the finalizer
    /// </summary>
    public class DBManager
    {
        /* Info (for copy-paste purposes):
	        -- - Database/schema name: ntp2020
	        -- - Address/server: localhost (127.0.0.1)
	        -- - Port: 3306
	        --
	        -- - User: ntp2020_user
	        -- - Password: 123
	        --
	        -- Tables:
	        -- Product - id INT, name VARCHAR, buttonName VARCHAR, price FLOAT
	        -- User - id INT, name VARCHAR, surname VARCHAR, username VARCHAR, hashpass VARCHAR, role INT FK
	        -- Userrole - id INT, name VARCHAR
	        --
	        -- - Userrole: { 1: 'admin', 2: 'worker' }
	        -- - Users:
	        --		- admin, password '123' hashed
	        --		- worker, password '123' hashed
        */

        private DBConnection dbCon;

        public DBManager(string server="localhost", string database="ntp2020", string username="ntp2020_user", string password="123")
        {
            this.dbCon = DBConnection.Instance(server, database, username, password);
        }

        ~DBManager()
        {
            this.dbCon.Close();
        }

        private void ExecuteQuery(string query = "select * from user")
        {
            if (dbCon.IsConnected())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                var cmd = new MySqlCommand(query, dbCon.GetConnection());
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string surname = reader.GetString(2);
                }
            }
        }

        public List<dynamic> FetchUsers()
        {
            List<dynamic> users = new List<dynamic>();
            if (dbCon.IsConnected())
            {
                var cmd = new MySqlCommand(@"SELECT U.*, UR.NAME ROLENAME FROM USER U INNER JOIN USERROLE UR ON U.ROLE=UR.ID;", dbCon.GetConnection());
                var reader = cmd.ExecuteReader();
	        // User - id INT, name VARCHAR, surname VARCHAR, username VARCHAR, hashpass VARCHAR, role INT FK
                while(reader.Read())
                {
                    users.Add(new {
                        id = reader.GetInt32("id"),
                        name = reader.GetString("name"),
                        surname = reader.GetString("surname"),
                        username = reader.GetString("username"),
                        password = reader.GetString("hashpass"),
                        role = reader.GetString("rolename")
                    });
                }
                dbCon.Close();
            }
            return users;
        }

    }
}

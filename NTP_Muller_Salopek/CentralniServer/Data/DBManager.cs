using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CentralniServer.Data
{
    /// <summary>
    /// Class that contains various MySql methods
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

        //private DBConnection dbCon;

        private DBManager() { }
        
        // Example read:
        //  while (reader.Read())
        //      User u = new User(name: reader.GetString(1), username: reader.GetString("Username"));
        /*using (DBConnection dbCon = DBConnection.Instance())
            {
                if (dbCon.IsConnected())
                {
                    var cmd = new MySqlCommand(query, dbCon.GetConnection());
    MySqlDataReader r = cmd.ExecuteReader();

                    if (r.HasRows == false)
                        return null;
                }
            }
        */

// id=0 fetches all users
        public static dynamic FetchUser(int id)
        {
            if (!(id > 0))
                throw new Exception("id must be >0");
            try
            {
                string query = @"select u.*, ur.name as rolename " +
                        @"from user as u " +
                        @"inner join userrole as ur " +
                        @"on u.role = ur.id " +
                        @"where u.id=" + id;

                using (DBConnection dbCon = DBConnection.Instance())
                {
                    if (dbCon.IsConnected())
                    {
                        var cmd = new MySqlCommand(query, dbCon.GetConnection());
                        MySqlDataReader r = cmd.ExecuteReader();

                        if (r.HasRows == false)
                            return null;
                        dynamic user = new
                        {
                            id = r.GetInt32(0),
                            name = r.GetString(1),
                            surname = r.GetString(2),
                            username = r.GetString(3),
                            password = r.GetString(4),
                            role = r.GetString(6)   // ur.name as rolename
                        };
                        return user;
                    }
                    else throw new Exception("Can't connect.");
                }
            }
            catch
            {
                return null;
            }
        }

        public static List<dynamic> FetchUsers()
        {
            List<dynamic> users = new List<dynamic>();
            try
            {
                string query = @"select u.*, ur.name as rolename " +
                        @"from user as u " +
                        @"inner join userrole as ur " +
                        @"on u.role = ur.id;";

                using (DBConnection dbCon = DBConnection.Instance())
                {
                    if (dbCon.IsConnected())
                    {
                        var cmd = new MySqlCommand(query, dbCon.GetConnection());
                        MySqlDataReader r = cmd.ExecuteReader();

                        while (r.Read())
                        {
                            // User - id INT, name VARCHAR, surname VARCHAR, username VARCHAR, hashpass VARCHAR, role INT FK
                            users.Add(new
                            {
                                id = r.GetInt32(0),
                                name = r.GetString(1),
                                surname = r.GetString(2),
                                username = r.GetString(3),
                                password = r.GetString(4),
                                role = r.GetString(6)   // ur.name as rolename
                            });
                        }
                    }
                    else throw new Exception("Can't connect.");
                }
                
            }
            catch
            {
                // Error
            }
            return users;
        }

    }
}

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
        public static dynamic FetchUser(int id, string username)
        {
            if (!(id > 0) && string.IsNullOrWhiteSpace(username))
                throw new Exception("To get all users, call FetchUsers");
            try
            {
                string query = @"select u.*, ur.name as rolename " +
                        @"from user as u " +
                        @"inner join userrole as ur " +
                        @"on u.role = ur.id " +
                        @"where 1=1 ";
                if (id > 0)
                    query += @"and u.id=" + id + " ";
                if (!string.IsNullOrWhiteSpace(username))
                    query += @"and u.username='" + username + "';";


                using (DBConnection dbCon = DBConnection.Instance())
                {
                    if (dbCon.IsConnected())
                    {
                        var cmd = new MySqlCommand(query, dbCon.GetConnection());
                        MySqlDataReader r = cmd.ExecuteReader();

                        if (r.HasRows == false)
                            return null;

                        r.Read();
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

        public static bool AddUser(dynamic user)
        {
            try
            {
                using (DBConnection dbCon = DBConnection.Instance())
                {
                    if (dbCon.IsConnected())
                    {
                        string name = user.name.Replace("'", "");
                        string surname = user.surname.Replace("'", "");
                        string username = user.username.Replace("'", "");
                        string password = user.password.Replace("'", "");
                        int roleId = user.role.ToLower() == "admin" ? 1 : 2;

                        string query = @"insert into user(name, surname, username, hashpass, role) " +
                            $"values ('{name}', '{surname}', '{username}', '{password}', {roleId});";
                        var cmd = new MySqlCommand(query, dbCon.GetConnection());
                        cmd.ExecuteNonQuery();
                    }
                    else return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteUser(int id)
        {
            try
            {
                using (DBConnection dbCon = DBConnection.Instance())
                {
                    if (dbCon.IsConnected())
                    {
                        var cmd = new MySqlCommand(@"delete from user where id=" + id, dbCon.GetConnection());
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    else return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static List<dynamic> FetchProducts()
        {
            List<dynamic> products = new List<dynamic>();
            try
            {
                string query = @"select * from product";

                using (DBConnection dbCon = DBConnection.Instance())
                {
                    if (dbCon.IsConnected())
                    {
                        var cmd = new MySqlCommand(query, dbCon.GetConnection());
                        MySqlDataReader r = cmd.ExecuteReader();

                        while (r.Read())
                        {
                            // Product - id INT, name VARCHAR, buttonName VARCHAR, price FLOAT
                            products.Add(new
                            {
                                id = r.GetInt32(0),
                                name = r.GetString(1),
                                buttonName = r.GetString(2),
                                price = r.GetFloat(3)
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
            return products;
        }

        public static bool AddProduct(dynamic product)
        {
            try
            {
                using (DBConnection dbCon = DBConnection.Instance())
                {
                    if (dbCon.IsConnected())
                    {
                        // Product - id INT, name VARCHAR, buttonName VARCHAR, price FLOAT
                        string name = product.name;
                        string buttonName = product.buttonName;
                        float price = product.price;

                        string query = @"insert into product(name, buttonName, price) " +
                            $"values ('{name}', '{buttonName}', {price});";
                        var cmd = new MySqlCommand(query, dbCon.GetConnection());
                        cmd.ExecuteNonQuery();
                    }
                    else return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteProduct(int id)
        {
            try
            {
                using (DBConnection dbCon = DBConnection.Instance())
                {
                    if (dbCon.IsConnected())
                    {
                        var cmd = new MySqlCommand(@"delete from product where id=" + id, dbCon.GetConnection());
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    else return false;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}

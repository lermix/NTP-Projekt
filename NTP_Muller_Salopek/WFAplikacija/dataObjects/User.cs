using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WFAplikacija.dataObjects
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }

        public User(int _id, string _name, string _surname, string _username)
        {
            id = _id;
            name = _name;
            surname = _surname;
            username = _username;

        }

        public User() { }
    }
}

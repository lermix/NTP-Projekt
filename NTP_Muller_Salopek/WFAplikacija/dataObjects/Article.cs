using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace project_Muller_Salopek.dataObjects
{
    public class Article
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string buttonName { get; set; }
        public float price { get; set; }
        public float quantity { get; set; }
        public float totalPrice { get { return price * quantity; } set { totalPrice = price * quantity; } }

        public Article (int _ID, string _name, string _buttonName, float _price)
        {
            ID = _ID;
            name = _name;
            buttonName = _buttonName;
            price = _price;
            quantity = 1;
        }
        public Article(int _ID, string _name, string _buttonName,float _quantity, float _price)
        {
            ID = _ID;
            name = _name;
            buttonName = _buttonName;
            price = _price;
            quantity = _quantity;
        }
        public Article ()
        { }

        public bool checkButtonName(string buttonNameToCompare)
        {
            return (buttonName == buttonNameToCompare) ? true : false;
        }

    }
}

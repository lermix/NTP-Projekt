using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WFAplikacija.dataObjects
{
    [Serializable()]
    [XmlRoot("Article")]
    public class Article
    {
        [XmlAttribute("ID")]
        public int ID { get; set; }
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("buttonName")]
        public string buttonName { get; set; }
        [XmlAttribute("price")]
        public float price { get; set; }
        [XmlAttribute("quantity")]
        public float quantity { get; set; } 
        [XmlAttribute("totalPrice")]
        public float totalPrice { get { return price * quantity; } set {} }

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
        {
            quantity = 1;
        }

        public bool checkButtonName(string buttonNameToCompare)
        {
            return (buttonName == buttonNameToCompare) ? true : false;
        }

        public override string ToString()
        {
            string returnValue =
                "ID: " + ID + " | " +
                "name: " + name + " | " +
                "button name: " + buttonName + " | " +
                "price: " + price + " | ";
            return returnValue;
        }

    }
}

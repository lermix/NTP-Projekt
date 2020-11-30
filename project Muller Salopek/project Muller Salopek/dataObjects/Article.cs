using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace project_Muller_Salopek.dataObjects
{
    [Serializable]
    [XmlRoot("Article")]
    public class Article
    {
        [XmlElement("ID")]
        public int ID { get; set; }
        [XmlElement("name")]
        public string name { get; set; }
        [XmlElement("buttonName")]
        public string buttonName { get; set; }
        [XmlElement("price")]
        public float price { get; set; }

        public Article (int _ID, string _name, string _buttonName, float _price)
        {
            ID = _ID;
            name = _name;
            buttonName = _buttonName;
            price = _price;
        }
        public Article ()
        { }

        public bool checkButtonName(string buttonNameToCompare)
        {
            return (buttonName == buttonNameToCompare) ? true : false;
        }

    }
}

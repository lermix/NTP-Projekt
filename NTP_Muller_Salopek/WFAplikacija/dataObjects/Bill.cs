using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WFAplikacija.dataObjects
{
    [Serializable()]
    [XmlRoot("Bills")]
    public class Bill
    {
        private DateTime dateTimePrivate;
        
        [XmlArray("Bill")]
        [XmlArrayItem("Article", typeof(Article))]
        public List<Article> articles { get; set; }
        [XmlAttribute("User")]
        public string user { get; set; } //Username
        [XmlAttribute("Total")]
        public int totalPrice { get; set; }
        [XmlAttribute("ID")]
        public int id { get; set; }
        [XmlAttribute("Time")]
        public string dateTimeString
        {
            get
            {
                return dateTimePrivate.ToString("dd-MM-yyy HH:mm");
            }
            set { }
        }

        [XmlIgnore]
        public DateTime dateTime
        {
            get { return dateTimePrivate; }
            set { dateTimePrivate = value; }
        }

        public override string ToString()
        {
            string returnValue = 
                "ID:" + id + "\r\n" +
                "user:" + user + "\r\n" +
                "total price:" + totalPrice + "\r\n" +
                "time:" + dateTimePrivate.ToString("dd-MM-yyy HH:mm") + "\r\n" +
                "number of articles: " + articles.Count() + "\r\n";
            return returnValue;
        }
        public string getArticlesAsString()
        {
            string returnValue = "";
            foreach (Article article in articles)
            {
                returnValue += article.ToString();
            }
            return returnValue;
        }

    }
}

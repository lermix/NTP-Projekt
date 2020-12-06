using WFAplikacija.dataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WFAplikacija.Data
{
    [Serializable()]
    [XmlRoot("Articles")]
    public class ArticleList
    {
        [XmlArray("Articles")]
        [XmlArrayItem("Article", typeof(Article))]
        public List<Article> articles { get; set; }
    }
}

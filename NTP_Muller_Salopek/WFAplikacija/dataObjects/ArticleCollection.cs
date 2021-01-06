using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WFAplikacija.DataObjects
{
    [XmlRoot(ElementName = "ArticleCollection")]
    public class ArticleCollection
    {
        [XmlElement(ElementName = "Article")]
        public List<Article> articles { get; set; }
    }
}

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
    public class BillList
    {
        [XmlArray("Bills")]
        [XmlArrayItem("Bill", typeof(Bill))]
        public List<Bill> bills { get; set; }
      
    }
}

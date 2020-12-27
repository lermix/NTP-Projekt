using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WFAplikacija.DataObjects
{
    [XmlRoot(ElementName = "BillCollection")]
    public class BillCollection
    {
        [XmlElement(ElementName = "Bill")]
        public List<Bill> Bills { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAplikacija.dataObjects
{
    class Bill
    {
        public DateTime dateTime { get; set; }
        public List<Article> aeticles { get; set; }
        public User user { get; set; }
        public int totalPrice { get; set; }

    }
}

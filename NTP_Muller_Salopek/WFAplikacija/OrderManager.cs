using project_Muller_Salopek.dataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace project_Muller_Salopek
{

    /*RAČUNI---------------------------
     * Sadrzi listu trenutnog racuna
     * Sprema tu listu u XML file
     * sadrzi funckije za obradu racuna
     */

    class OrderManager
    {
        List<Article> order = new List<Article>();

        private void addArticle(Article artikl)
        {
            order.Add(artikl);
        }
    }
}

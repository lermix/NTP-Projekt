using project_Muller_Salopek.dataObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace project_Muller_Salopek
{

    //Bavi se xml fileovima
    public class XmlManager
    {
        static List<Article> allArticles = new List<Article>();

        //NIJE DOVRSENO
        XDocument AllArticlesXML = XDocument.Load(@"assets\Data\AllArticlesXML.xml");
        

        //Dohvaca artikl prema buttonName atributu iz AllArticlesXML -- NIJE DOVRSENO
        public static List<Article> GetArticles()
        {
            return allArticles;
        }

        //Dodaje artikl u AllArticlesXML --- NIJE DOVRSENO
        public void AddArticle()
        {
            Article a = new Article(0, "test", "Article1", 5);
            XmlSerializer serializer = new XmlSerializer(a.GetType());
            serializer.Serialize(Console.Out, a);
        }




    }
}

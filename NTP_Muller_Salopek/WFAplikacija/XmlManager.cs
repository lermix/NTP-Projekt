using project_Muller_Salopek.dataObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace project_Muller_Salopek
{

    //Bavi se xml fileovima
    public class XmlManager
    {
        static List<Article> allArticles = new List<Article>();

        static XDocument AllArticlesXml = XDocument.Load("../../Data/AllArticlesXML.xml");
        static XDocument AllBillsXml = XDocument.Load("../../Data/AllBills.xml");
        //var path = Environment.GetFolderPath("../../Data/AllBills.xml");


        //Dohvaca artikl prema buttonName atributu iz AllArticlesXML -- NIJE DOVRSENO
        public static List<Article> GetArticles()
        {
            Console.WriteLine("a");
            return allArticles;
        }

        public static void AddArticlesListToAllBillsXml(List<Article> articles)
        {
            var billRoot = new XElement("Bill");
            //info racuna
            billRoot.Add(new XAttribute("Time", DateTime.Now.ToString("F")));
            billRoot.Add(new XAttribute("User", "TEST"));
            float totalPrice = 0;

            foreach (Article article in articles)
            {
                XElement articleElement = new XElement("Article");
                List<XAttribute> articleAttributes = new List<XAttribute>
                {
                    new XAttribute("ID", article.ID),
                    new XAttribute("name", article.name),
                    new XAttribute("quantity", article.quantity),
                    new XAttribute("price", article.price),
                    new XAttribute("totalPrice", article.totalPrice)
                };
                foreach (XAttribute attribute in articleAttributes)
                {
                    articleElement.Add(attribute);
                }
                billRoot.Add(articleElement);
                totalPrice += article.totalPrice;
            }

            billRoot.Add(new XAttribute("Total", totalPrice));
            AllBillsXml.Root.Add(billRoot);
            AllBillsXml.Save("../../Data/AllBills.xml");

        }

        public void AddArticleToAllArticlesXml(Article article)
        {
            var articleRoot = new XElement("Article");
            AllArticlesXml.Root.Add(articleRoot);

            List<XElement> articleElements = new List<XElement>
            { 
                new XElement("ID", article.ID),
                new XElement("name", article.name),
                new XElement("buttonName", article.buttonName),
                new XElement("price", article.price)
            };

            foreach (XElement xElement in articleElements)
            {
                articleRoot.Add(xElement);
            }

            AllArticlesXml.Save("../../Data/AllArticlesXML.xml");

        }




    }
}

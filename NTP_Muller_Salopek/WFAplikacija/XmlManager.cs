using WFAplikacija.Data;
using WFAplikacija.dataObjects;
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

namespace WFAplikacija
{

    //Bavi se xml fileovima
    public class XmlManager
    {
        static List<Article> allArticles = new List<Article>();

        public static User user { get; set; }

        static XDocument AllArticlesXml = XDocument.Load("../../Data/AllArticlesXML.xml");
        static XDocument AllBillsXml = XDocument.Load("../../Data/AllBills.xml");

        public static void addObjectToXml(object objectToAdd)
        {
            Console.WriteLine("Appending objet to xml.");
            //DODAJEMO ARTIKL-----------------------------------
            if (objectToAdd.GetType() == typeof(Article))
            {
                Console.WriteLine("ObjectToAdd is Article.");

                Article article = (Article)objectToAdd;
                var articleElement = new XElement("Article");

                //Add element
                AllArticlesXml.Root.Element("Articles").Add(articleElement);

                //Atributes to add
                List<XAttribute> articleAtributes = new List<XAttribute>
                {
                    new XAttribute("ID", article.ID),
                    new XAttribute("name", article.name),
                    new XAttribute("buttonName", article.buttonName),
                    new XAttribute("price", article.price)
                };

                //Add atributes
                foreach (XAttribute xElement in articleAtributes)
                {
                    articleElement.Add(xElement);
                }

                //Save
                AllArticlesXml.Save("../../Data/AllArticlesXML.xml");
            }
            //DODAJEMO RACUN-----------------------------------------
            else if (objectToAdd.GetType() == typeof(Bill))
            {
                Console.WriteLine("ObjectToAdd is Bill.");

                Bill bill = (Bill)objectToAdd;
                float totalPrice = 0;
                var billElement = new XElement("Bill");
                billElement.Add(new XAttribute("ID", bill.id));
                billElement.Add(new XAttribute("Time", DateTime.Now.ToString("dd-MM-yyy HH:mm")));
                billElement.Add(new XAttribute("User", user.username));
                billElement.Add(new XAttribute("SavedToDatabase", user.username));

                //Add element
                AllBillsXml.Root.Element("Bills").Add(billElement);

                //Add articles to bill
                foreach (Article article in bill.articles)
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
                    billElement.Add(articleElement);
                    totalPrice += article.totalPrice;
                }

                billElement.Add(new XAttribute("Total", totalPrice));

                //Save
                AllBillsXml.Save("../../Data/AllBills.xml");
            }


        }


        //Dohvaca artikl prema buttonName atributu iz AllArticlesXML
        public static ArticleList GetArticles()
        {
            Console.WriteLine("reading Articles");

            ArticleList allArticles = null;

            //Dodavanje root elementa kako bi serializer znao koji je root element
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "ArticlesCollection";
            xRoot.IsNullable = true;

            XmlSerializer serializer = new XmlSerializer(typeof(ArticleList), xRoot);
            XmlReader reader = AllArticlesXml.CreateReader();
         
            allArticles = (ArticleList)serializer.Deserialize(reader);
            reader.Close();

            Console.WriteLine("reading succesful");

            return allArticles;
        }

        public static BillList GetBills()
        {
            Console.WriteLine("reading bills");

            BillList allBills = null;

            //Dodavanje root elementa kako bi serializer znao koji je root element
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "BillsCollection";
            xRoot.IsNullable = true;

            XmlSerializer serializer = new XmlSerializer(typeof(BillList), xRoot);
            XmlReader reader = AllBillsXml.CreateReader();

            allBills = (BillList)serializer.Deserialize(reader);
            reader.Close();

            Console.WriteLine("reading succesful");

            return allBills;
        }






    }
}

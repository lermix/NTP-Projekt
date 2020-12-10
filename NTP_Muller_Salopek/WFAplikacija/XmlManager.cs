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
            if (objectToAdd == null){return;}
            Console.WriteLine("Appending objet to xml.");
            //DODAJEMO ARTIKL-----------------------------------
            if (objectToAdd.GetType() == typeof(Article))
            {
                Console.WriteLine("ObjectToAdd is Article.");

                Article article = (Article)objectToAdd;
                var articleElement = new XElement("Article");

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

                //Add element
                AllArticlesXml.Root.Add(articleElement);

                //Save
                AllArticlesXml.Save("../../Data/AllArticlesXML.xml");
            }
            //DODAJEMO RACUN-----------------------------------------
            else if (objectToAdd.GetType() == typeof(Bill))
            {
                Console.WriteLine("ObjectToAdd is Bill.");
                Bill bill = (Bill)objectToAdd;

                //root
                XElement billElement = new XElement("Bill");

                //Atributes
                float totalPrice = 0;
                billElement.Add(new XAttribute("ID", bill.id));
                billElement.Add(new XAttribute("Time", DateTime.Now.ToString("dd-MM-yyy HH:mm")));
                billElement.Add(new XAttribute("User", user.username));
                billElement.Add(new XAttribute("SavedToDatabase", user.username));

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

                //Add total price
                billElement.Add(new XAttribute("Total", bill.totalPrice));

                //Add element
                AllBillsXml.Root.Add(billElement);

                //Save
                AllBillsXml.Save("../../Data/AllBills.xml");
            }


        }


        //Dohvaca artikl prema buttonName atributu iz AllArticlesXML
        public static ArticleCollection GetArticles()
        {
            Console.WriteLine("reading Articles");
            ArticleCollection articles = new ArticleCollection();

            XmlSerializer serializer = new XmlSerializer(typeof(ArticleCollection));

            using (StreamReader reader = new StreamReader(@"../../Data/AllArticlesXML.xml"))
            {
                articles = (ArticleCollection)serializer.Deserialize(reader);
            }

            Console.WriteLine("reading succesful");
            return articles;
        }

        public static BillCollection GetBills()
        {
            Console.WriteLine("reading bills");
            BillCollection bills = new BillCollection();

            XmlSerializer serializer = new XmlSerializer(typeof(BillCollection));

            using (StreamReader reader = new StreamReader(@"../../Data/AllBills.xml"))
            {
                bills = (BillCollection)serializer.Deserialize(reader);
            }

            Console.WriteLine("reading succesful");
            return bills;            
        }

        public static void ReplaceArticle(Article newArticle)
        {
            /*
            Console.WriteLine("Replacing Article", newArticle);
            var query = from articles in AllArticlesXml.Root.Elements("Article")
                        select articles;
            foreach (XElement article in query)
            {
                Console.WriteLine("ID SEARCH: ", article.Attribute("name").Value);
                if (int.Parse(article.Attribute("ID").Value) == newArticle.ID)
                {
                    Console.WriteLine("Article found");
                    article.Attribute("name").Value = newArticle.name;
                    article.Attribute("buttonName").Value = newArticle.buttonName;
                    article.Attribute("price").Value = newArticle.price.ToString();
                }
            }*/

            var target = AllArticlesXml.Elements().Where(e => e.Attribute("ID").Value == "0").Single();
            target.Attribute("price").Value = newArticle.price.ToString();
            AllArticlesXml.Save("../../Data/AllArticlesXML.xml");
        }

        






    }
}

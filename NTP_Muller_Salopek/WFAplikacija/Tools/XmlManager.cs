using WFAplikacija.DataObjects;
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

namespace WFAplikacija.Tools
{

    /// <summary>
    /// Works with xml files.
    /// Functions: add, replace, delete, getArticles, getBills, getNextIDArticle
    /// </summary>
    public static class XmlManager
    {
        public static string AllArticlesXmlLoaction = @"../../Data/AllArticlesXML.xml";
        public static string AllBillXmlLoaction = @"../../Data/AllBills.xml";

        static XDocument AllArticlesXml = XDocument.Load(AllArticlesXmlLoaction);
        static XDocument AllBillsXml = XDocument.Load(AllBillXmlLoaction);

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
                foreach (XAttribute xAtribut in articleAtributes)
                {
                    articleElement.Add(xAtribut);
                }

                //Add element
                AllArticlesXml.Root.Add(articleElement);

                //Save
                AllArticlesXml.Save(AllArticlesXmlLoaction);
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
                billElement.Add(new XAttribute("User", WFAplikacija.Tools.Session.user.username));
                billElement.Add(new XAttribute("SavedToDatabase", WFAplikacija.Tools.Session.user.username));

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
                    //Add atributes to article
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
                AllBillsXml.Save(AllBillXmlLoaction);
            }


        }

        public static ArticleCollection GetArticles()
        {
            Console.WriteLine("reading Articles");
            ArticleCollection articles = new ArticleCollection();

            //For it to work each class property needs definition as how will it be stored in xml  
            //Each xElement is presented with a class and its properties with attributes
            XmlSerializer serializer = new XmlSerializer(typeof(ArticleCollection));

            //Reads the document and stores it in reader variable
            using (StreamReader reader = new StreamReader(AllArticlesXmlLoaction))
            {
                articles = (ArticleCollection)serializer.Deserialize(reader);
            }

            Console.WriteLine("reading succesful, count: " + articles.articles.Count);
            return articles;
        }

        public static BillCollection GetBills()
        {
            Console.WriteLine("reading bills");
            BillCollection bills = new BillCollection();

            XmlSerializer serializer = new XmlSerializer(typeof(BillCollection));

            using (StreamReader reader = new StreamReader(AllBillXmlLoaction))
            {
                bills = (BillCollection)serializer.Deserialize(reader);
            }

            Console.WriteLine("reading succesful");
            return bills;            
        }

        public static void ReplaceArticle(Article newArticle)
        {
            var target = AllArticlesXml.Root.Elements().Where(e => e.Attribute("ID").Value == newArticle.ID.ToString()).Single();
            target.Attribute("price").Value = newArticle.price.ToString();
            AllArticlesXml.Save(AllArticlesXmlLoaction);
        }

        public static void DeleteArticle(Article articleToDelete)
        {
            var target = AllArticlesXml.Root.Elements().Where(e => e.Attribute("ID").Value == articleToDelete.ID.ToString()).Single();
            target.Remove();
            AllArticlesXml.Save(AllArticlesXmlLoaction);
        }

        //Max 1000 after that it collides with bills
        public static int getNextIDArticle()
        {
            int target = AllArticlesXml.Root.Elements().Max(e => (int)e.Attribute("ID"));
            return target+1;
        }

        public static void DeleteAllArticles()
        {
            var target = AllArticlesXml.Root.Elements();
            target.Remove();
        }

        public static void DeleteAllBills()
        {
            var target = AllBillsXml.Root.Elements();
            target.Remove();
        }

        public static void AddList(List<Object> listToAdd)
        {
            foreach (Object item in listToAdd)
            {
                addObjectToXml(item);
            }
        }


        






    }
}

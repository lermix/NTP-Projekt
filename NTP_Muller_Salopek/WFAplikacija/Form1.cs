using WFAplikacija.dataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using WFAplikacija.Data;

namespace WFAplikacija
{
    public partial class Form1 : Form
    {

        List<Article> orderArticles = new List<Article>();
        ArticleList allArticles = new ArticleList();

        public Form1()
        {
            InitializeComponent();

            //Konfiguracija listViewArticles
            listViewArticles.View = View.Details;
            listViewArticles.Columns.Add("ID");
            listViewArticles.Columns.Add("Name");
            listViewArticles.Columns.Add("Quantity");
            listViewArticles.Columns.Add("Price");

            //Dohavti sve dostupne artikle u ArtiklListu            
            allArticles = XmlManager.GetArticles();

            //Postavi usera
            User user = new User(0, "TESTN", "TESTS", "TEST");
            XmlManager.user = user;

            //TEST ZONE
            BillList testList = new BillList();
            testList = XmlManager.GetBills();
            foreach (Bill bill in testList.bills)
            {
                Console.WriteLine(bill.ToString());
                //Console.WriteLine(bill.getArticlesAsString());
            }


        }

        private void ArticleButtonClicked(object sender, EventArgs e)
        {
            //Dohvati koji button je stisnut
            var button = (Button)sender;

            //Povuci podatke o artiklu iz liste artikala
            Article article = new Article();
            article = allArticles.articles.FirstOrDefault(tempArticle => tempArticle.checkButtonName(button.Text));

            if (article == null)
            {
                Console.WriteLine("Article with that buttonName does not exist");
                return;
            }           

            //Provjeri je li artikl vec na racunu
            bool sameArticleFound = false;
            foreach (Article a in orderArticles)
            {
                if (a.ID == article.ID)
                {
                    a.quantity += 1;
                    sameArticleFound = true;
                }
            }

            if (sameArticleFound == false)
            {
                //Dodaj artikl u listu za prikaz
                listViewArticles.Items.Add(new ListViewItem(
                new string[] { article.ID.ToString(), article.name, article.quantity.ToString(), article.totalPrice.ToString() }));

                //Dodaj artikl na racun
                orderArticles.Add(article);
            }
            else
            {
                listViewArticles.Items.Clear();
                foreach (Article a in orderArticles)
                {
                    listViewArticles.Items.Add(new ListViewItem(
                    new string[] { a.ID.ToString(), a.name, a.quantity.ToString(), a.totalPrice.ToString() }));
                }
            }


            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //Dodaj racun u AllBills.xml
            Bill order = new Bill();
            order.id = 0;
            order.articles = orderArticles;

            XmlManager.addObjectToXml(order);

            listViewArticles.Items.Clear();
            orderArticles.Clear();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm();
            propertiesForm.ShowDialog();
        }

        private void tabReports_Click(object sender, EventArgs e)
        {

        }

        private void checkServerButton_Click(object sender, EventArgs e)
        {
            this.checkServerResponseLabel.Text = "Sending request...";

            Action<string> onResponse = (string response) => { this.checkServerResponseLabel.Text = "Server response: " + response; };
            Action onError = () => { this.checkServerResponseLabel.Text = "ERROR - No response."; };
            WFAplikacija.RESTManager.Get(WFAplikacija.Properties.Resources.CentralniServerURL + @"Home/RequestTest", onResponse, onError);
        }

       

        private void sendGetRequestButton_Click(object sender, EventArgs e)
        {
            string url = this.customGetRequestBaseTextBox.Text + this.customGetRequestActionTextBox.Text;
            this.customGetRequestResponseLabel.Text = "Sending request to " + url;

            Action<string> onResponse = (string response) => { this.customGetRequestResponseLabel.Text = "Server response: " + response; };
            Action onError = () => { this.customGetRequestResponseLabel.Text = "ERROR - No response."; };
            WFAplikacija.RESTManager.Get(url, onResponse, onError);
        }
    }
}

using project_Muller_Salopek.dataObjects;
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




namespace project_Muller_Salopek
{
    public partial class Form1 : Form
    {

        List<Article> allArticles = new List<Article>();
        List<Article> order = new List<Article>();

        public Form1()
        {
            InitializeComponent();

            //Konfiguracija listViewArticles
            listViewArticles.View = View.Details;
            listViewArticles.Columns.Add("ID");
            listViewArticles.Columns.Add("Name");
            listViewArticles.Columns.Add("Quantity");
            listViewArticles.Columns.Add("Price");

            //Dohavti sve dostupne artikle u listu            
            allArticles = XmlManager.GetArticles(); //NIJE DOVRSENO


            //TEST DODAJ ARTIKL U LISTU
            Article testArticle = new Article(0,"test","Article1", 5);
            Article testArticle2 = new Article(1, "test2", "Article2", 10);
            allArticles.Add(testArticle);
            allArticles.Add(testArticle2);


        }

        private void ArticleButtonClicked(object sender, EventArgs e)
        {
            //Dohvati koji button je stisnut
            var button = (Button)sender;

            //Povuci podatke o artiklu iz liste artikala
            Article article = new Article();
            article = allArticles.FirstOrDefault(tempArticle => tempArticle.checkButtonName(button.Text));

            //Provjeri je li artikl vec na racunu
            bool sameArticleFound = false;
            foreach (Article a in order)
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
                order.Add(article);
            }
            else
            {
                listViewArticles.Items.Clear();
                foreach (Article a in order)
                {
                    listViewArticles.Items.Add(new ListViewItem(
                    new string[] { a.ID.ToString(), a.name, a.quantity.ToString(), a.totalPrice.ToString() }));
                }
            }


            
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm();
            propertiesForm.ShowDialog();
        }

        private void tabReports_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                // Izmijeniti prema potrebi
                var URL_SERVERA = @"https://localhost:44391";
                var NASTAVAK = @"/Home/RequestTest";

                string responseString = "";
                try
                {
                    responseString = await client.GetStringAsync(URL_SERVERA + NASTAVAK);
                    // Remove trailing white spaces:
                    responseString.Trim();
                }
                catch
                {
                    responseString = "NO RESPONSE";
                }
                this.label2.Text = "Server response: " + responseString;
                return;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //Dodaj racun u AllBills.xml
            XmlManager.AddArticlesListToAllBillsXml(order);
            listViewArticles.Items.Clear();
        }
    }
}

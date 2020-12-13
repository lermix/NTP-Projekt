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
using WFAplikacija.Tools;

namespace WFAplikacija
{
    public partial class Form1 : Form
    {

        List<Article> orderArticles = new List<Article>();
        ArticleCollection articleCollection = new ArticleCollection();
        Bill order = new Bill();


        public Form1()
        {
            InitializeComponent();

            //Konfiguracija listViewArticles
            listViewArticles.View = View.Details;
            listViewArticles.Columns.Add("ID");
            listViewArticles.Columns.Add("Name");
            listViewArticles.Columns.Add("Quantity");
            listViewArticles.Columns.Add("Price");

            //konfiguracija racuna
            order.totalPrice = 0;

            //Dohavti sve dostupne artikle u ArtiklListu            
            articleCollection = XmlManager.GetArticles();

            //Postavi usera
            User user = new User(0, "TESTN", "TESTS", "TEST");
            XmlManager.user = user;

            //TEST ZONE
            //PDFManager.BillsXmlToPdf();
        }

        private void ArticleButtonClicked(object sender, EventArgs e)
        {
            //Dohvati koji button je stisnut
            var button = (Button)sender;

            //Povuci podatke o artiklu iz liste artikala
            Article article = new Article();
            article = articleCollection.articles.FirstOrDefault(tempArticle => tempArticle.checkButtonName(button.Text));

            if (article == null)
            {
                Console.WriteLine("Article with that buttonName does not exist");
                return;
            }

            //Povecaj ukupnu cijenu
            order.totalPrice += article.price;
            lblTotalNum.Text = order.totalPrice.ToString();

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
            string url = WFAplikacija.Properties.Resources.CentralniServerURL + @"/Status";
            this.checkServerResponseLabel.Text = "Sending request to " + url;

            Action<string> onResponse = (string response) => { this.checkServerResponseLabel.Text = "Server response: " + response; };
            Action onError = () => { this.checkServerResponseLabel.Text = "ERROR - No response."; };
            WFAplikacija.Tools.RESTManager.Get(WFAplikacija.Properties.Resources.CentralniServerURL + @"/Status", onResponse, onError);
        }

       

        private void sendGetRequestButton_Click(object sender, EventArgs e)
        {
            string url = this.customGetRequestBaseTextBox.Text + this.customGetRequestActionTextBox.Text;
            this.customGetRequestResponseLabel.Text = "Sending request to " + url;

            Action<string> onResponse = (string response) => { this.customGetRequestResponseLabel.Text = "Server response: " + response; };
            Action onError = () => { this.customGetRequestResponseLabel.Text = "ERROR - No response."; };
            WFAplikacija.Tools.RESTManager.Get(url, onResponse, onError);
        }

      private void sendSampleLoginButton_Click(object sender, EventArgs e)
        {
            string url = WFAplikacija.Properties.Resources.CentralniServerURL + @"/User";

            var usernameText = this.sampleLoginUsernameTextBox.Text;
            var passwordText = this.sampleLoginPasswordTextBox.Text;

            //Moj edit da se rijesim errora
            string hashedPasswordText = WFAplikacija.Tools.Cryptography.makeSha512(passwordText).ToString();

            


            this.sampleLoginResponseLabel.Text = "Sending request to " + url +
                "\nUser: " + usernameText +
                "\nHashed password: " + hashedPasswordText;
            var postRequestBody = new Dictionary<string, string>{
                { "username", usernameText },
                { "hashedPassword", hashedPasswordText }
            };
            Action<string> onResponse = (string response) => { this.sampleLoginResponseLabel.Text = "Server response: " + response; };
            Action onError = () => { this.sampleLoginResponseLabel.Text = "ERROR - No response."; };
            WFAplikacija.Tools.RESTManager.Post(url, postRequestBody, onResponse, onError);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Clear previous data
            dtReports.Rows.Clear();
            dtReports.Refresh();

            //DataGridView config
            dtReports.ColumnCount = 5;
            dtReports.Columns[0].Name = "ID";
            dtReports.Columns[1].Name = "user";
            dtReports.Columns[2].Name = "total";
            dtReports.Columns[3].Name = "time";
            dtReports.Columns[4].Name = "number of articles";

            //Add bills to dataGridView
            BillCollection billCollection = XmlManager.GetBills();
            for (int i = 0; i < billCollection.Bills.Count; i++)
            {               
                dtReports.Rows.Add(new string[] {
                    billCollection.Bills[i].id.ToString(),
                    billCollection.Bills[i].user,
                    billCollection.Bills[i].totalPrice.ToString(),
                    billCollection.Bills[i].dateTime.ToString(),
                    billCollection.Bills[i].articles.Count.ToString()
                });
            }
            
        }

    }
}

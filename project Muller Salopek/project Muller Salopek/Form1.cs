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
            listViewArticles.Columns.Add("Sifra");
            listViewArticles.Columns.Add("NazivArtikla");
            listViewArticles.Columns.Add("Cijena");

            //Dohavti sve dostupne artikle u listu            
            allArticles = XmlManager.GetArticles(); //NIJE DOVRSENO


        }

        private void ArticleButtonClicked(object sender, EventArgs e)
        {
            //Dohvati koji button je stisnut
            var button = (Button)sender;

            //Povuci podatke o artiklu iz liste artikala
            Article article = new Article();
            article = allArticles.FirstOrDefault(tempArticle => tempArticle.checkButtonName(button.Text));

            //Dodaj artikl u listu za prikaz
            listViewArticles.Items.Add(new ListViewItem(new string[] { article.ID.ToString(), article.name, article.price.ToString() }));

            //Dodaj artikl na racun
            order.Add(article);

            //Dodaj Artikl u xmlFFile - NIJE DOVRSENO
            XmlManager xmlManager = new XmlManager();
            xmlManager.AddArticle();

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm();
            propertiesForm.ShowDialog();
        }


        private void btnComplete_Click(object sender, EventArgs e)
        {
            order.Clear();
        }
    }
}

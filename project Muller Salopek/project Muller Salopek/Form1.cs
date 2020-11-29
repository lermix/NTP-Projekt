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
        public Form1()
        {
            InitializeComponent();
            listViewArticles.View = View.Details;
            listViewArticles.Columns.Add("Sifra");
            listViewArticles.Columns.Add("NazivArtikla");
            listViewArticles.Columns.Add("Cijena");

        }

        private void ArticleButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            listViewArticles.Items.Add(new ListViewItem(new string[] { "0000 ", button.Text, "100" }));
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

                string responseString = await client.GetStringAsync(URL_SERVERA + NASTAVAK);
                // Remove trailing white spaces:
                responseString.Trim();
                this.label2.Text = "Server response: " + responseString;
                return;
            }

        private void btnComplete_Click(object sender, EventArgs e)
        {

        }
    }
}

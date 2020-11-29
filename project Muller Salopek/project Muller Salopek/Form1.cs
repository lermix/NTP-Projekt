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


        private void btnComplete_Click(object sender, EventArgs e)
        {

        }
    }
}

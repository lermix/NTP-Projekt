using WFAplikacija.DataObjects;
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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WFAplikacija
{
    public partial class AppForm : Form
    {

        List<Article> orderArticles = new List<Article>();
        ArticleCollection articleCollection = new ArticleCollection();
        Bill order = new Bill();

        BillCollection billCollection = XmlManager.GetBills();
        ArticleCollection articlesCollection = XmlManager.GetArticles();



        public AppForm()
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

        private void programmableButton_Click(object sender, EventArgs e)
        {
            // Testing area
            this.testABLabel.Text = WFAplikacija.Properties.Resources.testAB;
        }

        private void openPropertiesButton_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm();
            propertiesForm.ShowDialog();
        }


//REPORTS-------------------------------------------------------------------------------------------------------------------

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AddBillsToDtReports();          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            addArticlesToDtReports();
        }

        private void btnReportsSave_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;    

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (radioButton1.Checked)//BILLS
                {
                    String saveLocation = dialog.FileName + "/bills_" + DateTime.Now.ToString("dd_MM_yyy_HHmmss") + ".pdf";
                    saveLocation = saveLocation.Replace("\\", "/");
                    MessageBox.Show("You selected: " + saveLocation);
                    PDFManager.createPDFfromList<Bill>(DataGridBillsToList(), "Bills", @saveLocation);
                }
                else//ARTICLES
                {
                    String saveLocation = dialog.FileName + "/Articles_" + DateTime.Now.ToString("dd_MM_yyy_HHmmss") + ".pdf";
                    saveLocation = saveLocation.Replace("\\", "/");
                    MessageBox.Show("You selected: " + saveLocation);
                    PDFManager.createPDFfromList<Article>(DataGridArticlesToList(), "Articles", @saveLocation);
                }
                
                //PDFManager.BillsXmlToPdf(@saveLocation);
                //PDFManager.createPDFfromList<Bill>(dtReports.Rows, "Bills", @saveLocation);
            }
        }


        private List<Bill> DataGridBillsToList()
        {
            List<Bill> billsFromDataGridList = new List<Bill>();
            List<Bill> allBills = new List<Bill>();
            allBills = billCollection.Bills;            

            foreach (DataGridViewRow row in dtReports.Rows)
            {
                Bill tempBIll = new Bill();
                tempBIll.id = int.Parse(row.Cells[0].Value.ToString());
                tempBIll.user = row.Cells[1].Value.ToString();
                tempBIll.totalPrice = int.Parse(row.Cells[2].Value.ToString());
                tempBIll.dateTime = DateTime.Parse(row.Cells[3].Value.ToString());
                tempBIll.articles = allBills.Find(x => x.id == tempBIll.id).articles;

                billsFromDataGridList.Add(tempBIll);
            }

            return billsFromDataGridList;
        }

        private List<Article> DataGridArticlesToList()
        {
            List<Article> articleFromDataGridList = new List<Article>();

            foreach (DataGridViewRow row in dtReports.Rows)
            {
                Article tempArticle = new Article();
                tempArticle.ID = int.Parse(row.Cells[0].Value.ToString());
                tempArticle.name = row.Cells[1].Value.ToString();
                tempArticle.price = int.Parse(row.Cells[2].Value.ToString());

                articleFromDataGridList.Add(tempArticle);
            }

            return articleFromDataGridList;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();
            int reportNum, userInput;

            if (string.IsNullOrEmpty(cmbFilterColumn.Text))
            {
                MessageBox.Show("You must select column to filter before filtering");
                return;
            }
            if (string.IsNullOrEmpty(cmbFilterFunction.Text))
            {
                MessageBox.Show("You must define how to filter data before filtering");
                return;
            }

            if (radioButton1.Checked)
            {
                AddBillsToDtReports();
            }
            else if (radioButton2.Checked)
            {
                addArticlesToDtReports();
            }

            for (int i = 0; i < dtReports.Rows.Count; i++)
            {

                switch (cmbFilterFunction.SelectedItem.ToString())
                {
                    case "Is equal to":
                    case "Jednako je":
                        if (dtReports.Rows[i].Cells[cmbFilterColumn.Text].Value.ToString() != tBoxFilter.Text)
                        {
                            rowsToRemove.Add(dtReports.Rows[i]);
                        }
                        break;

                    case "Is greater than":
                    case "Je vece od":
                        if (int.TryParse(dtReports.Rows[i].Cells[cmbFilterColumn.Text].Value.ToString(), out reportNum))
                        {
                            if (int.TryParse(tBoxFilter.Text, out userInput))
                            {
                                if (reportNum <= userInput){rowsToRemove.Add(dtReports.Rows[i]);}
                            }
                            else{MessageBox.Show("For greater than filter you must input numbers");return;}
                        }
                        else{MessageBox.Show("For greater than filter you must use column that has numbers");return;}
                        break;

                    case "Is less than":
                    case "Je manje od":
                        if (int.TryParse(dtReports.Rows[i].Cells[cmbFilterColumn.Text].Value.ToString(), out reportNum))
                        {
                            if (int.TryParse(tBoxFilter.Text, out userInput))
                            {
                                if (reportNum >= userInput) { rowsToRemove.Add(dtReports.Rows[i]); }
                            }
                            else { MessageBox.Show("For less than filter you must input numbers"); return; }
                        }
                        else { MessageBox.Show("For less than filter you must use column that has numbers"); return; }
                        break;
                    case "Is not equal to":
                    case "Je različito od":
                        if (dtReports.Rows[i].Cells[cmbFilterColumn.Text].Value.ToString() == tBoxFilter.Text)
                        {
                            rowsToRemove.Add(dtReports.Rows[i]);
                        }
                        break;
                    case "Starts with":
                    case "Počinje sa":
                        if (!dtReports.Rows[i].Cells[cmbFilterColumn.Text].Value.ToString().StartsWith(tBoxFilter.Text))
                        {
                            rowsToRemove.Add(dtReports.Rows[i]);
                        }

                        break;
                    default:
                        break;
                }                
            }

            foreach (DataGridViewRow row in rowsToRemove)
            {
                dtReports.Rows.Remove(row);
            }

        }

        private void AddBillsToDtReports()
        {
            // Clear previous data
            dtReports.Columns.Clear();
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

            //Filter config
            cmbFilterColumn.Items.Clear();
            for (int i = 0; i < dtReports.Columns.Count; i++)
            {
                cmbFilterColumn.Items.Add(dtReports.Columns[i].Name);
            }
        }

        private void addArticlesToDtReports()
        {
            // Clear previous data
            dtReports.Columns.Clear();
            dtReports.Rows.Clear();
            dtReports.Refresh();

            //DataGridView config
            dtReports.ColumnCount = 5;
            dtReports.Columns[0].Name = "ID";
            dtReports.Columns[1].Name = "name";
            dtReports.Columns[2].Name = "price";

            //Add bills to dataGridView
            for (int i = 0; i < articlesCollection.articles.Count; i++)
            {
                dtReports.Rows.Add(new string[] {
                    articlesCollection.articles[i].ID.ToString(),
                    articlesCollection.articles[i].name,
                    articlesCollection.articles[i].price.ToString()
                });
            }

            //Filter config
            cmbFilterColumn.Items.Clear();
            for (int i = 0; i < dtReports.Columns.Count; i++)
            {
                cmbFilterColumn.Items.Add(dtReports.Columns[i].Name);
            }
        }
    }

}

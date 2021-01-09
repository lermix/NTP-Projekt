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
using System.Collections.Specialized;

namespace WFAplikacija
{
    /// <summary>
    /// Main form
    /// 
    /// Warning!!!
    /// When adding article button it must be added to articleButtonList in getAllArticleButtons() function
    /// </summary>
    public partial class AppForm : Form
    {
        //Sale
        List<Article> orderArticles = new List<Article>();
        ArticleCollection articleCollection = new ArticleCollection();
        Bill order = new Bill();

        //Collections
        BillCollection billCollection = XmlManager.GetBills();
        ArticleCollection articlesCollection = XmlManager.GetArticles();

        //Reports
        string ShownObject = "";

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


            //Reports conf
            lblBillInfo.Hide();
            btnReportsBack.Hide();
            btnReportsBillInfo.Hide();
            btnReportsSaveAllBills.Hide();

            //Get all article and generate their buttons
            GenerateArticleButtons(this.tabArticle1, articlesCollection.articles);

        }

        //FORM LAYOUT AND INI----------------------------------------------------------------------------------------------
        #region FORM LAYOUT AND INI
        /// <summary>
        /// Load layout from an INI file if exists
        /// </summary>
        public void LoadFormLayout()
        {
            IniFilesManager settings = new IniFilesManager(WFAplikacija.Properties.Resources.SettingsIniFile);

            if (settings.KeyExists(WFAplikacija.Properties.Resources.IniXPosKey))
                this.Left = Int32.Parse(settings.Read(WFAplikacija.Properties.Resources.IniXPosKey));
            if (settings.KeyExists(WFAplikacija.Properties.Resources.IniYPosKey))
                this.Top = Int32.Parse(settings.Read(WFAplikacija.Properties.Resources.IniYPosKey));
        }

        /// <summary>
        /// Save layout to INI file
        /// </summary>
        public void SaveFormLayout()
        {
            IniFilesManager settings = new IniFilesManager(WFAplikacija.Properties.Resources.SettingsIniFile);

            settings.Write(WFAplikacija.Properties.Resources.IniWidthKey, this.Width.ToString());
            settings.Write(WFAplikacija.Properties.Resources.IniHeightKey, this.Height.ToString());
            settings.Write(WFAplikacija.Properties.Resources.IniXPosKey, this.Left.ToString());
            settings.Write(WFAplikacija.Properties.Resources.IniYPosKey, this.Top.ToString());
        }
        #endregion
        //SALE---------------------------------------------------------------------------------------------------------------
        #region SALE
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
            order.id = billCollection.Bills.Last().id+1;
            order.articles = orderArticles;

            if (order.articles.Count != 0)
            {
                XmlManager.addObjectToXml(order);
            }

            listViewArticles.Items.Clear();
            orderArticles.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listViewArticles.Items.Clear();
        }

        #endregion
        //ADMIN-------------------------------------------------------------------------------------------------------
        #region ADMIN
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm(this);
            propertiesForm.LoadFormLayout();
            propertiesForm.FormClosing += delegate {
                // Save app layout
                propertiesForm.SaveFormLayout();
                // Update products in case they are changed
                articleCollection = XmlManager.GetArticles();
                GenerateArticleButtons(this.tabArticle1, articleCollection.articles);
                // Closing PropertiesForm shows AppForm
                this.LoadFormLayout();
                this.Show();
            };
            propertiesForm.ShowDialog();
        }
        #endregion
        //SERVER-------------------------------------------------------------------------------------------------------
        #region SERVER
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
            string urlBase = WFAplikacija.Properties.Resources.CentralniServerURL + @"/User/Login/?";
            string url = urlBase;
            NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);

            var usernameText = this.sampleLoginUsernameTextBox.Text;
            var passwordText = this.sampleLoginPasswordTextBox.Text;
            var hashedPasswordText = WFAplikacija.Tools.Cryptography.GetHashString(passwordText);

            queryString.Add("username", usernameText);
            queryString.Add("hashedPassword", hashedPasswordText);
            url += queryString.ToString();

            this.sampleLoginResponseLabel.Text = "Sending request to " + urlBase +
                "\nUser: " + usernameText +
                "\nHashed password: " + hashedPasswordText;
            var postRequestBody = new { };

            Action<string> onResponse = (string response) => { this.sampleLoginResponseLabel.Text = "Server response: " + response; };
            Action onError = () => { this.sampleLoginResponseLabel.Text = "ERROR - No response."; };
            WFAplikacija.Tools.RESTManager.Post(url, postRequestBody, onResponse, onError);
        }

        private void programmableButton_Click(object sender, EventArgs e)
        {
            // Testing area
            string res = WFAplikacija.Tools.Cryptography.GetHashString("123");
        }

        private void openPropertiesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PropertiesForm propertiesForm = new PropertiesForm(this);
            propertiesForm.Location = this.Location;
            propertiesForm.StartPosition = this.StartPosition;
            propertiesForm.FormClosing += delegate {
                // Save app layout
                propertiesForm.SaveFormLayout();
                // Closing PropertiesForm shows AppForm
                this.LoadFormLayout();
                this.Show();
            };
            propertiesForm.ShowDialog();
        }
        #endregion
        // HELPING FUNCTIONS -------------------------------------------------------------------------------------------------------
        #region HELPING FUNCTIONS
        private List<Button> getAllArticleButtons()
        {
            List<Button> allArticleButton = new List<Button> {
            btnArticle1, btnArticle2, btnArticle3, btnArticle4,
            btnArticle5, btnArticle6, btnArticle7, btnArticle8,
            btnArticle9, btnArticle10, btnArticle11, btnArticle12,
            btnArticle13, btnArticle14};

            return allArticleButton;
        }

        public void ChangeButtonText(string btnName, string text)
        {
            foreach (Button button in getAllArticleButtons())
            {
                if(button.Name == btnName)
                {
                    button.Text = text;
                    MessageBox.Show("selected button: " + btnName + "\r\n" +
                            "text changed to: " + text);
                }
            }
        }

        public void ClearArticleButtons(System.Windows.Forms.TabPage articlePage)
        {
            articlePage.Controls.Clear();
        }

        /// <summary>
        /// Adds buttons with articles to a tab page
        /// </summary>
        /// <param name="articlePage">Tab inside TabControl object.</param>
        /// <param name="articles">List of articles whose names are added as buttons</param>
        public void GenerateArticleButtons(System.Windows.Forms.TabPage articlePage, List<Article> articles, int articlesPerRow = 7)
        {
            // Clear previous buttons
            ClearArticleButtons(articlePage);
            int currRow = 1;
            int currCol = 1;
            foreach (Article a in articles)
            {
                // Calculate position
                /* width = 75
                 * height = 75
                 * distance between buttons = 6
                 */
                int buttonX = 6 + (currCol - 1) * 81;
                int buttonY = 6 + (currRow - 1) * 81;

                // Generate button
                Button button = new System.Windows.Forms.Button();
                button.Location = new System.Drawing.Point(buttonX, buttonY);
                button.Name = "btnArticle" + a.ID.ToString();
                button.Size = new System.Drawing.Size(75, 75);
                button.TabIndex = 1;
                button.Text = a.buttonName;
                button.UseVisualStyleBackColor = true;
                button.Click += new System.EventHandler(this.ArticleButtonClicked);
                // Add button
                articlePage.Controls.Add(button);

                // Adjust currRow, currCol
                ++currCol;
                if (currCol > articlesPerRow)
                {
                    // Go to next row
                    currCol = 1;
                    ++currRow;
                }
            }
        }
        #endregion
        //REPORTS-------------------------------------------------------------------------------------------------------------------
        //dtReports uses tag property to keep track of what is shown so it is easier to add shown objects to list
        //WARNING: when adding to dtReports change tag accordingly tags(Bills, Articles, BillArticles)
        //         *BillArticles have quantity and totalPrice
        #region REPORTS
        //Bills radio button selected
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AddBillsToDtReports();
            dtReports.Tag = "Bills";
            lblBillInfo.Show();
            btnReportsBack.Show();
            btnReportsBillInfo.Show();
            btnReportsSaveAllBills.Show();
        }
        //Articles radio button  selected
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            addArticlesToDtReports();
            dtReports.Tag = "Articles";
            lblBillInfo.Hide();
            btnReportsBack.Hide();
            btnReportsBillInfo.Hide();
            btnReportsSaveAllBills.Hide();
        }

        private void btnReportsSave_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;    

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (dtReports.Tag.ToString() == "Bills")//BILLS
                {
                    String saveLocation = dialog.FileName + "/bills_" + DateTime.Now.ToString("dd_MM_yyy_HHmmss") + ".pdf";
                    saveLocation = saveLocation.Replace("\\", "/");
                    MessageBox.Show("You selected: " + saveLocation);
                    PDFManager.createPDFfromList<Bill>(DataGridBillsToList(), "Bills", @saveLocation, true);
                }
                else if(dtReports.Tag.ToString() == "Articles")//ARTICLES
                {
                    String saveLocation = dialog.FileName + "/Articles_" + DateTime.Now.ToString("dd_MM_yyy_HHmmss") + ".pdf";
                    saveLocation = saveLocation.Replace("\\", "/");
                    MessageBox.Show("You selected: " + saveLocation);
                    PDFManager.createPDFfromList<Article>(DataGridArticlesToList(), "Articles", @saveLocation, true);
                }
                else if(dtReports.Tag.ToString() == "BillArticles") //Bill Articles
                {
                    String saveLocation = dialog.FileName + "/BillArticles_" + DateTime.Now.ToString("dd_MM_yyy_HHmmss") + ".pdf";
                    saveLocation = saveLocation.Replace("\\", "/");
                    MessageBox.Show("You selected: " + saveLocation);
                    PDFManager.createPDFfromList<Article>(DataGridBillArticlesToList(), "Bill articles", @saveLocation, false);
                }
            }
        }

        //Put all bills presented in dataGrid to list
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

        //Put all articles presented in datagrid to list
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

        //Put all bill articles presented in datagrid to list
        private List<Article> DataGridBillArticlesToList()
        {
            List<Article> articleFromDataGridList = new List<Article>();

            foreach (DataGridViewRow row in dtReports.Rows)
            {
                Article tempArticle = new Article();
                tempArticle.ID = int.Parse(row.Cells[0].Value.ToString());
                tempArticle.name = row.Cells[1].Value.ToString();
                tempArticle.price = int.Parse(row.Cells[2].Value.ToString());
                tempArticle.quantity = int.Parse(row.Cells[3].Value.ToString());                

                articleFromDataGridList.Add(tempArticle);
            }

            return articleFromDataGridList;
        }

        //Filter 
        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();
            int reportNum, userInput;

            //Check for correct input
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

            //Bills selected
            if (radioButton1.Checked)
            {
                AddBillsToDtReports();
            }
            //Articles selected
            else if (radioButton2.Checked)
            {
                addArticlesToDtReports();
            }

            //Filter
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

            //remove filtered out data
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
            dtReports.ColumnCount = 3;
            dtReports.Columns[0].Name = "ID";
            dtReports.Columns[1].Name = "name";
            dtReports.Columns[2].Name = "price";

            //Add articles to dataGridView
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

        //Open bill
        private void btnReportsBillInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int billID = int.Parse(dtReports.SelectedRows[0].Cells["ID"].Value.ToString());
                Bill selectedBill = billCollection.Bills.Find(x => x.id == billID);

                // Clear previous data
                dtReports.Columns.Clear();
                dtReports.Rows.Clear();
                dtReports.Refresh();

                //DataGridView config
                dtReports.ColumnCount = 5;
                dtReports.Columns[0].Name = "ID";
                dtReports.Columns[1].Name = "name";
                dtReports.Columns[2].Name = "price";
                dtReports.Columns[3].Name = "quantity";
                dtReports.Columns[4].Name = "total price";

                //Add articles to dataGridView
                for (int i = 0; i < selectedBill.articles.Count; i++)
                {
                    dtReports.Rows.Add(new string[] {
                    selectedBill.articles[i].ID.ToString(),
                    selectedBill.articles[i].name,
                    selectedBill.articles[i].price.ToString(),
                    selectedBill.articles[i].quantity.ToString(),
                    selectedBill.articles[i].totalPrice.ToString()
                    });
                }

                //Tag change
                dtReports.Tag = "BillArticles";

            }
            catch (Exception)
            {
                MessageBox.Show("You must select row not cell");
                return;
            }
            
            
        }

        private void btnReportsBack_Click(object sender, EventArgs e)
        {
            AddBillsToDtReports();
            dtReports.Tag = "Bills";
        }

        //Choose save location
        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                String saveLocation = dialog.FileName + "/AllBills_" + DateTime.Now.ToString("dd_MM_yyy_HHmmss") + ".pdf";
                saveLocation = saveLocation.Replace("\\", "/");
                MessageBox.Show("You selected: " + saveLocation);
                PDFManager.BillsXmlToPdf(@saveLocation);
            }
        }
        #endregion

    }

}

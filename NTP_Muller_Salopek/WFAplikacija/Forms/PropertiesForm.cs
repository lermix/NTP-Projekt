using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAplikacija.DataObjects;
using WFAplikacija.Tools;

namespace WFAplikacija
{
    public partial class PropertiesForm : Form
    {
        ArticleCollection articlesCollection = new ArticleCollection();

        AppForm appForm;



        public PropertiesForm(AppForm mainForm)
        {
            InitializeComponent();

            appForm = mainForm;
            //konfiguracija izgleda            
            EditAndDeleteListShow(false);
        }

        //ProductManager tab
        private void cmbArticleManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Refreshes list box
            listBoxArticleManagerArticles.Items.Clear();
            FIllListBox();

            switch (cmbArticleManager.SelectedItem.ToString())
            {
                case "Insert product":
                    txtBoxEnabled(true);
                    EditAndDeleteListShow(false);
                    //Generate next avalible ID for Product, max 1000
                    txtBoxArticleManagerId.Text = XmlManager.getNextIDArticle().ToString();
                    break;
                case "Delete product":
                    txtBoxEnabled(false);
                    EditAndDeleteListShow(true);
                    txtBoxArticleManagerId.Text = "";
                    break;
                case "Edit product":
                    txtBoxEnabled(true);
                    EditAndDeleteListShow(true);
                    txtBoxArticleManagerId.Text = "";
                    break;
                default:
                    break;
            }
        }

        //ProductManager tab
        private void btnArticleManagerComplete_Click(object sender, EventArgs e)
        {
            //Refresh list box
            listBoxArticleManagerArticles.Items.Clear();
            FIllListBox();

            switch (cmbArticleManager.SelectedItem.ToString())
            {
                case "Insert article":                    
                    if(GetFormArticle() != null)
                    {
                        XmlManager.addObjectToXml(GetFormArticle());
                        InserAndEditControlsClear();
                        txtBoxArticleManagerId.Text = XmlManager.getNextIDArticle().ToString();
                    }                    
                    break;
                case "Delete article":
                    if (GetFormArticle() != null)
                    {
                        XmlManager.DeleteArticle(GetFormArticle());
                        InserAndEditControlsClear();
                    }
                    break;
                case "Edit article":
                    if (GetFormArticle() != null)
                    {
                        XmlManager.ReplaceArticle(GetFormArticle());
                        InserAndEditControlsClear();
                    }                    
                    break;
                default:
                    break;
            }
        }

        //Gets selected article from listBox in ProductManager tab
        private void listBoxArticleManagerArticles_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Article articleSelected = (Article)listBoxArticleManagerArticles.SelectedItem;
            FillTxtBoxesWithSelectedArticle(articleSelected);

        }

        //Add product to sale tab
        private void btnAddToSale_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbAddToSale.Text))
            {
                if (listBoxAddToSale.SelectedItems.Count != 0)
                {
                    Article articleSelected = (Article)listBoxAddToSale.SelectedItem;
                    appForm.ChangeButtonText(cmbAddToSale.Text, articleSelected.buttonName);

                    //Saves button names layout
                    IniFilesManager MyIni = new IniFilesManager("Settings.ini");
                    MyIni.Write(cmbAddToSale.Text, articleSelected.buttonName);
                }
                else
                {
                    MessageBox.Show("Plesae select article");
                }
            }
            else
            {
                MessageBox.Show("Please select button");
            }

        }


//Helper functions used in product manager tab ------------------------------------------------------------------------------------
        //clear txtBoxes at ProductManager tab
        private void InserAndEditControlsClear()
        {
            txtBoxArticleManagerId.Clear();
            txtBoxArticleManagerName.Clear();
            txtBoxArticleManagerBtnName.Clear();
            txtBoxArticleManagerPrice.Clear();
        }
        //Show or hide article list at ProductManager tab
        private void EditAndDeleteListShow(bool Show)            
        {
            if (Show)
            {
                listBoxArticleManagerArticles.Show();
                lblChoseArticle.Show();
            }
            else
            {
                listBoxArticleManagerArticles.Hide();
                lblChoseArticle.Hide();
            }
            
        }
        //Enable or disable txtBoxes at ProductManager tab
        private void txtBoxEnabled(bool enabled)
        {
            if (enabled)
            {
                txtBoxArticleManagerBtnName.Enabled = true;
                txtBoxArticleManagerName.Enabled = true;
                txtBoxArticleManagerPrice.Enabled = true;
            }
            else
            {
                txtBoxArticleManagerBtnName.Enabled = false;
                txtBoxArticleManagerName.Enabled = false;
                txtBoxArticleManagerPrice.Enabled = false;
            }
            
        }
        //Create article from txtBoxes text in ProductManager tab
        //If article is returned null it won't be saved
        //WARNING!!! 
        //Before calling this function make sure to check if value returned is not null
        private Article GetFormArticle()
        {
            Article article = new Article();
            float price = 0;
            article.ID = int.Parse(txtBoxArticleManagerId.Text);
            if(float.TryParse(txtBoxArticleManagerPrice.Text,out price))
            {
                article.price = price;
            }
            else
            {
                MessageBox.Show("Price must be number");
                return null;
            }
            
            article.name = txtBoxArticleManagerName.Text;
            if (string.IsNullOrEmpty(txtBoxArticleManagerName.Text))
            {
                MessageBox.Show("Name can not be empty");
                return null;
            }

            article.buttonName = txtBoxArticleManagerBtnName.Text;
            if (string.IsNullOrEmpty(txtBoxArticleManagerBtnName.Text))
            {
                MessageBox.Show("Button name can not be empty");
                return null;
            }

            if (string.IsNullOrEmpty(txtBoxArticleManagerPrice.Text))
            {
                MessageBox.Show("Price can not be empty");
                return null;
            }
            if (price == 0)
            {
                MessageBox.Show("Warning, price is 0");
            }

            return article;
        }
        //Puts info from article selected in listBox to txtBoxes in ProductManager tab
        private void FillTxtBoxesWithSelectedArticle(Article articleSelected)
        {
            txtBoxArticleManagerId.Text = articleSelected.ID.ToString();
            txtBoxArticleManagerName.Text = articleSelected.name;
            txtBoxArticleManagerBtnName.Text = articleSelected.buttonName;
            txtBoxArticleManagerPrice.Text = articleSelected.price.ToString();
        }
        //Fills listBox with all articles in product manager tab
        private void FIllListBox()
        {
            articlesCollection = XmlManager.GetArticles();
            for (int i = 0; i < articlesCollection.articles.Count; i++)
            {
                listBoxArticleManagerArticles.Items.Add(articlesCollection.articles[i]);
            }
        }

//Add product to sale tab----------------------------------------------------------------------------------------
        //Fills list box with articles in add product to sale tab
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listBoxAddToSale.Items.Clear();
            articlesCollection = XmlManager.GetArticles();
            for (int i = 0; i < articlesCollection.articles.Count; i++)
            {
                listBoxAddToSale.Items.Add(articlesCollection.articles[i]);
            }
        }

        
    }
}

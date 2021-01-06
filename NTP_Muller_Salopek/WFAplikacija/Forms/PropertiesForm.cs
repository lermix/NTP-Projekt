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
        

        public PropertiesForm()
        {
            InitializeComponent();

            //konfiguracija izgleda            
            EditAndDeleteListShow(false);

        }

        private void cmbArticleManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxArticleManagerArticles.Items.Clear();
            FIllListBox();
            switch (cmbArticleManager.SelectedItem.ToString())
            {
                case "Insert product":
                    txtBoxEnabled(true);
                    EditAndDeleteListShow(false);
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

        private void btnArticleManagerComplete_Click(object sender, EventArgs e)
        {
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

                        listBoxArticleManagerArticles.Items.Clear();
                        FIllListBox();
                    }                    
                    break;
                default:
                    break;
            }
        }

        private void listBoxArticleManagerArticles_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Article articleSelected = (Article)listBoxArticleManagerArticles.SelectedItem;
            FillTxtBoxesWithSelectedArticle(articleSelected);

        }


        //Functions used inside this class --------------------------------------------------------------------
        private void InsertAndEditControlsShow(bool Show)
        {
            if (Show)
            {
                txtBoxArticleManagerId.Show();
                txtBoxArticleManagerName.Show();
                txtBoxArticleManagerBtnName.Show();
                txtBoxArticleManagerPrice.Show();
                lblArticleManagerID.Show();
                lblArticleManagerName.Show();
                lblArticleManagerbtnName.Show();
                lblArticleManagerPrice.Show();
            }
            else
            {
                txtBoxArticleManagerId.Hide();
                txtBoxArticleManagerName.Hide();
                txtBoxArticleManagerBtnName.Hide();
                txtBoxArticleManagerPrice.Hide();
                lblArticleManagerID.Hide();
                lblArticleManagerName.Hide();
                lblArticleManagerbtnName.Hide();
                lblArticleManagerPrice.Hide();
            }
        }
        private void InserAndEditControlsClear()
        {
            txtBoxArticleManagerId.Clear();
            txtBoxArticleManagerName.Clear();
            txtBoxArticleManagerBtnName.Clear();
            txtBoxArticleManagerPrice.Clear();
        }
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
        private Article GetFormArticle()
        {
            Article article = new Article();
            float price = 0;
            article.ID = int.Parse(txtBoxArticleManagerId.Text);
            if(float.TryParse(txtBoxArticleManagerPrice.Text,out price))
            {
                article.price = price;
            }
            
            article.buttonName = txtBoxArticleManagerBtnName.Text;
            article.name = txtBoxArticleManagerName.Text;
            if (string.IsNullOrEmpty(txtBoxArticleManagerName.Text))
            {
                MessageBox.Show("Name can not be empty");
                return null;
            }
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
        private void FillTxtBoxesWithSelectedArticle(Article articleSelected)
        {
            txtBoxArticleManagerId.Text = articleSelected.ID.ToString();
            txtBoxArticleManagerName.Text = articleSelected.name;
            txtBoxArticleManagerBtnName.Text = articleSelected.buttonName;
            txtBoxArticleManagerPrice.Text = articleSelected.price.ToString();
        }
        private void FIllListBox()
        {
            articlesCollection = XmlManager.GetArticles();
            for (int i = 0; i < articlesCollection.articles.Count; i++)
            {
                listBoxArticleManagerArticles.Items.Add(articlesCollection.articles[i]);
            }
        }

        
    }
}

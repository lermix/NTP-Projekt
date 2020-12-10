using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAplikacija.dataObjects;

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

            articlesCollection = XmlManager.GetArticles();



        }

        private void cmbArticleManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxArticleManagerArticles.Items.Clear();
            FIllListBox();
            switch (cmbArticleManager.SelectedItem.ToString())
            {
                case "Insert article":
                    txtBoxEnabled(true);
                    EditAndDeleteListShow(false);
                    break;
                case "Delete article":
                    txtBoxEnabled(false);
                    EditAndDeleteListShow(true);
                    break;
                case "Edit article":
                    txtBoxEnabled(true);
                    EditAndDeleteListShow(true);
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
                    }                    
                    break;
                case "Delete article":
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

        private void listBoxArticleManagerArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ID prema listBoxu
            int Id = int.Parse(listBoxArticleManagerArticles.SelectedItem.ToString()[4].ToString());
            Article articleSelected = articlesCollection.articles.First(item => item.ID == Id);
            FillTxtBoxesWithSelectedArticle(articleSelected);

        }

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
            article.ID = 11;
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
            for (int i = 0; i < articlesCollection.articles.Count; i++)
            {
                listBoxArticleManagerArticles.Items.Add(articlesCollection.articles[i].ToString());
            }
        }

        
    }
}

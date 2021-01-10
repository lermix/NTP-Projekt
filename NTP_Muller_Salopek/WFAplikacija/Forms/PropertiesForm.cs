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

            //Ini manager
        }

        /// <summary>
        /// Load layout from an INI file if exists
        /// </summary>
        public void LoadFormLayout()
        {
            IniFilesManager settings = new IniFilesManager(WFAplikacija.Properties.Resources.SettingsIniFile);

            if (settings.KeyExists(WFAplikacija.Properties.Resources.IniWidthKey))
                this.Width = Int32.Parse(settings.Read(WFAplikacija.Properties.Resources.IniWidthKey));
            if (settings.KeyExists(WFAplikacija.Properties.Resources.IniHeightKey))
                this.Height = Int32.Parse(settings.Read(WFAplikacija.Properties.Resources.IniHeightKey));
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
            string selectedItem = cmbArticleManager.SelectedItem.ToString();
            if (selectedItem == WFAplikacija.Lang.Dictionary.PFActionInsert)
            {
                // Insert
                if (GetFormArticle() != null)
                {
                    XmlManager.addObjectToXml(GetFormArticle());
                    InserAndEditControlsClear();
                    txtBoxArticleManagerId.Text = XmlManager.getNextIDArticle().ToString();
                }
            }
            else if (selectedItem == WFAplikacija.Lang.Dictionary.PFActionDelete)
            {
                // Delete
                if (GetFormArticle() != null)
                {
                    XmlManager.DeleteArticle(GetFormArticle());
                    InserAndEditControlsClear();
                }
            }
            else if (selectedItem == WFAplikacija.Lang.Dictionary.PFActionEdit)
            {
                // Edit
                if (GetFormArticle() != null)
                {
                    XmlManager.ReplaceArticle(GetFormArticle());
                    InserAndEditControlsClear();

                    listBoxArticleManagerArticles.Items.Clear();
                    FIllListBox();
                }
            }
        }

        private void listBoxArticleManagerArticles_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Article articleSelected = (Article)listBoxArticleManagerArticles.SelectedItem;
            FillTxtBoxesWithSelectedArticle(articleSelected);

        }


//Functions used inside this class -------------------------------------------------------------------------------
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

        //CRYPTO---------------------------------------------------------------------------------
        private void tabControlProperties_Click(object sender, EventArgs e)
        {
            if (TxtManager.setAES)
            {
                cmbCrypto.Text = "AES";
            }
            else
            {
                cmbCrypto.Text = "CES";
            }

        }

        private void btnCryptoSet_Click(object sender, EventArgs e)
        {
            if (cmbCrypto.Text == "AES")
            {
                TxtManager.setAES = true;
            }
            else
            {
                TxtManager.setAES = false;
            }
        }

        private void btnCryptoShow_Click(object sender, EventArgs e)
        {
            int id;

            if (string.IsNullOrEmpty(txtBoxCrypto.Text)) { return; }
            if (int.TryParse(txtBoxCrypto.Text, out id))
            {
                rtbCrypto.Text = TxtManager.ReadFromFile(id);
            }
            else
            {
                MessageBox.Show("Id must be number!");
            }
            
        }


        //USER TAB
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name, username, password, surname, role;
            if (string.IsNullOrEmpty(txtBoxAddUserName.Text)){MessageBox.Show("Name can't be empty");return;}
            else{name = txtBoxAddUserName.Text;   }
            if (string.IsNullOrEmpty(txtBoxAddUserPassword.Text)){MessageBox.Show("Password can't be empty");return;}
            else{password = txtBoxAddUserPassword.Text;}
            if (string.IsNullOrEmpty(txtBoxAddUserSurname.Text)){MessageBox.Show("Surname can't be empty");return;}
            else{surname = txtBoxAddUserSurname.Text;       }
            if (string.IsNullOrEmpty(txtBoxAddUserUsername.Text)){MessageBox.Show("Username can't be empty");return;}
            else{username = txtBoxAddUserUsername.Text;}



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtManager.fileType = cmbFileType.Text;
        }
    }
}

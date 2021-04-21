using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ITWorkstationsInc.Database;
using ITWorkstationsInc.Model;
using ITWorkstationsInc.Utility;

namespace ITWorkstationsInc.View
{
    public partial class ProductForm : Form
    {
        private static ProductForm instance;
        FormITWorkstation mFormITWorkstation;
        ProductDAO mProductDAO = ProductDAO.getInstance();
        Dictionary<string, Product> itemDictionary = new Dictionary<string, Product>();
        int type = -1;

        public ProductForm(FormITWorkstation formITWorkstation, int type)
        {
            this.mFormITWorkstation = formITWorkstation;
            this.type = type;
            InitializeComponent();
        }

        public static ProductForm getInstance(FormITWorkstation formITWorkstation, int type)
        {
            if (instance == null)
            {
                instance = new ProductForm(formITWorkstation, type);
            }
            return instance;
        }

        public void ShowAddForm()
        {
            if (instance != null)
            {
                instance.BringToFront();
            }
            else
            {
                instance = new ProductForm(mFormITWorkstation, type);

            }
            instance.Show();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            initForm(type);
        }

        private void initForm(int type)
        {
            List<string> NamesList = new List<string>();
            itemDictionary.Clear();
            try
            {
                itemDictionary = mProductDAO.ProductDictionary(type);
                NamesList.AddRange(itemDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                cmbProductName.DataSource = NamesList;
                cmbProductName.SelectedIndex = -1;
                txtProductPrice.Text = "";
            }
            lblProductName.Text = getLabel(type);
        }

        private string getLabel(int type)
        {
            string lbl = "";
            if(type == Constant.CASEBOX)
            {
                lbl = "PC: ";
            }
            else if(type == Constant.CPU)
            {
                lbl = "CPU : ";
            }
            else if (type == Constant.SSD)
            {
                lbl = "SSD: ";
            }
            else if (type == Constant.HDD)
            {
                lbl = "HDD: ";
            }
            else if (type == Constant.RAM)
            {
                lbl = "RAM: ";
            }
            else if (type == Constant.NVIDIA)
            {
                lbl = "Nvidia: ";
            }
            return lbl;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cmbProductName.Text == "" || !Utility.ValidateInput.validateNumber(txtProductPrice.Text))
            {
                MessageBox.Show("Item Not Added, check the values");
                return;
            }
            try
            {
                Product item = new Product();
                item.Name = cmbProductName.Text;
                item.Price = Convert.ToDouble(txtProductPrice.Text);
                item.Type = type;
                if (mProductDAO.addData(item))
                {
                    SHowMessageInfo("Product saved");
                }
                else
                {
                    SHowMessageInfo("Item not naved, check the values");
                }
            }
            catch (Exception ex)
            {
                SHowMessageInfo("Item not naved, check the values");
            }
            initForm(type);
            mFormITWorkstation.ReLoadLists();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product item = new Product();
                item.Id = itemDictionary.GetValueOrDefault(cmbProductName.GetItemText(cmbProductName.SelectedItem)).Id;
                item.Price = Convert.ToDouble(txtProductPrice.Text);
                if (mProductDAO.UpdateData(item))
                {
                    SHowMessageInfo("Item Updated");
                }
                else
                {
                    SHowMessageInfo("Item Not Updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            initForm(type);
            mFormITWorkstation.ReLoadLists();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product item = itemDictionary.GetValueOrDefault(cmbProductName.GetItemText(cmbProductName.SelectedItem));
                if (mProductDAO.DeleteData(item))
                {
                    SHowMessageInfo("Item Deleted");
                }
                else
                {
                    SHowMessageInfo("Item Not Deleted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            initForm(type);
            if (itemDictionary.Count == 0)
            {
                cmbProductName.Text = "";
            }
            mFormITWorkstation.ReLoadLists();
        }

        private void btnCloseProductForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product item = null;
            try
            {
                item = itemDictionary.GetValueOrDefault(cmbProductName.GetItemText(cmbProductName.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (item != null)
            {
                txtProductPrice.Text = item.Price.ToString();
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void SHowMessageInfo(string txt)
        {
            MessageBox.Show(txt, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}

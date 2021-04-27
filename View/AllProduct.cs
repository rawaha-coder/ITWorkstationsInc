using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ITWorkstationsInc.Database;
using ITWorkstationsInc.Model;

namespace ITWorkstationsInc.View
{
    public partial class AllProduct : Form
    {
        ProductDAO productDAO = ProductDAO.getInstance();
        List<Product> listProduct = new List<Product>();
        FormITWorkstation mFormITWorkstation;
        public AllProduct(FormITWorkstation formITWorkstation)
        {
            this.mFormITWorkstation = formITWorkstation;
            InitializeComponent();
        }

        private void AllProduct_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            listProduct.Clear();
            try
            {
                listProduct = productDAO.getAllProduct();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvAllProduct.DataSource = listProduct;
        }


        private void dgvAllProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Product product = (Product)listProduct[e.RowIndex];
            if (product == null)
            {
                MessageBox.Show("Select Item");
                return;
            }
            try
            {
                productDAO.UpdateProduct(product);
                MessageBox.Show("Product Updated");
                mFormITWorkstation.ReLoadLists();
            }
            catch
            {
                MessageBox.Show("Product Not Updated");
            }

            //DialogResult res = MessageBox.Show("Are you sure you want to Update item", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //if (res == DialogResult.OK)
            //{

            //}
        }
    }
}

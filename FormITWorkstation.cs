using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITWorkstationsInc.View;
using ITWorkstationsInc.Database;
using ITWorkstationsInc.Model;
using ITWorkstationsInc.Utility;

namespace ITWorkstationsInc
{
    public partial class FormITWorkstation : Form
    {

        ProductDAO mProductDAO = ProductDAO.getInstance();

        Dictionary<string, Product> mPCDictionary = new Dictionary<string, Product>();
        Dictionary<string, Product> mCPUDictionary = new Dictionary<string, Product>();
        Dictionary<string, Product> mSDDDictionary = new Dictionary<string, Product>();
        Dictionary<string, Product> mHDDDictionary = new Dictionary<string, Product>();
        Dictionary<string, Product> mRAMDictionary = new Dictionary<string, Product>();
        Dictionary<string, Product> mNVIDIADictionary = new Dictionary<string, Product>();

        double mPCPrice = 0.0;
        double mCPUPrice = 0.0;
        double mSSDPrice = 0.0;
        double mHDDDPrice = 0.0;
        double mRAMPrice = 0.0;
        double mNVIDIAPrice = 0.0;

        string mCaseBoxName = "";
        string mCPU1Name = "";
        string mSSDName = "";
        string mHDDDName = "";
        string mRAMName = "";
        string mNVIDIAName = "";


        public FormITWorkstation()
        {
            InitializeComponent();
        }

        private void ITWorkstation_Load(object sender, EventArgs e)
        {
            ReLoadLists();
            initToZeo();
            initToZeroString();
        }

        private void initToZeo()
        {
            mPCPrice = 0.0;
            mCPUPrice = 0.0;
            mSSDPrice = 0.0;
            mHDDDPrice = 0.0;
            mRAMPrice = 0.0;
            mNVIDIAPrice = 0.0;
        }

        private void initToZeroString()
        {
            txtPCCasePrice.Text = "0.0";
            txtCPUV2Price.Text = "0.0";
            txtSDDPrice.Text = "0.0";
            txtHDDPrice.Text = "0.0";
            txtRAMPrice.Text = "0.0";
            txtNVIDIAPrice.Text = "0.0";
            txtMainResultCalcul.Text = "0.0";
            FeeTextBox.Text = "";
            ProfitTextBox.Text = "";

            mCaseBoxName = "";
            mCPU1Name = "";
            mSSDName = "";
            mHDDDName = "";
            mRAMName = "";
            mNVIDIAName = "";

        }

        public void ReLoadLists()
        {
            initPCCaseList();
            initCPUList();
            initSDDList();
            initHDDList();
            initRAMList();
            initNVIDIAList();
            initToZeo();
            initToZeroString();
        }

        private void initPCCaseList()
        {
            List<string> NamesList = new List<string>();
            mPCDictionary.Clear();
            try
            {
                mPCDictionary = mProductDAO.ProductDictionary(Constant.CASEBOX); 
                NamesList.AddRange(mPCDictionary.Keys);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetch data to list: " + e.Message);
            }
            if (NamesList != null)
            {
                PCCaseListComboBox.DataSource = NamesList;
                PCCaseListComboBox.SelectedIndex = -1;
            }
        }

        private void initCPUList()
        {
            List<string> NamesList = new List<string>();
            mCPUDictionary.Clear();
            try
            {
                mCPUDictionary = mProductDAO.ProductDictionary(Constant.CPU);
                NamesList.AddRange(mCPUDictionary.Keys);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetch data to list: " + e.Message);
            }
            if (NamesList != null)
            {
                CPUV2ListComboBox.DataSource = NamesList;
                CPUV2ListComboBox.SelectedIndex = -1;
            }
        }


        private void initSDDList()
        {
            List<string> NamesList = new List<string>();
            mSDDDictionary.Clear();
            try
            {
                mSDDDictionary = mProductDAO.ProductDictionary(Constant.SSD);
                NamesList.AddRange(mSDDDictionary.Keys);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetch data to list: " + e.Message);
            }
            if (NamesList != null)
            {
                SDDListComboBox.DataSource = NamesList;
                SDDListComboBox.SelectedIndex = -1;
            }
        }

        private void initHDDList()
        {
            List<string> NamesList = new List<string>();
            mHDDDictionary.Clear();
            try
            {
                mHDDDictionary = mProductDAO.ProductDictionary(Constant.HDD);
                NamesList.AddRange(mHDDDictionary.Keys);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetch data to list: " + e.Message);
            }
            if (NamesList != null)
            {
                HDDListComboBox.DataSource = NamesList;
                HDDListComboBox.SelectedIndex = -1;
            }
        }


        private void initRAMList()
        {
            List<string> NamesList = new List<string>();
            mRAMDictionary.Clear();
            try
            {
                mRAMDictionary = mProductDAO.ProductDictionary(Constant.RAM);
                NamesList.AddRange(mRAMDictionary.Keys);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetch data to list: " + e.Message);
            }
            if (NamesList != null)
            {
                RAMListComboBox.DataSource = NamesList;
                RAMListComboBox.SelectedIndex = -1;
            }
        }

        private void initNVIDIAList()
        {
            List<string> NamesList = new List<string>();
            mNVIDIADictionary.Clear();
            try
            {
                mNVIDIADictionary = mProductDAO.ProductDictionary(Constant.NVIDIA);
                NamesList.AddRange(mNVIDIADictionary.Keys);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetch data to list: " + e.Message);
            }
            if (NamesList != null)
            {
                NVIDIAListComboBox.DataSource = NamesList;
                NVIDIAListComboBox.SelectedIndex = -1;
            }
        }

        private void UpdateItemContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == PCCaseStripMenuItem.Name)
            {

                ProductForm AddItemForm = new ProductForm(this, Constant.CASEBOX);
                AddItemForm.ShowDialog();

            }
            else if (e.ClickedItem.Name == CPUStripMenuItem.Name)
            {
                ProductForm AddItemForm = new ProductForm(this, Constant.CPU);
                AddItemForm.ShowDialog();
            }
            else if (e.ClickedItem.Name == SSDStripMenuItem.Name)
            {
                ProductForm AddItemForm = new ProductForm(this, Constant.SSD);
                AddItemForm.ShowDialog();
            }
            else if (e.ClickedItem.Name == HDDStripMenuItem.Name)
            {
                ProductForm AddItemForm = new ProductForm(this, Constant.HDD);
                AddItemForm.ShowDialog();
            }
            else if (e.ClickedItem.Name == RAMStripMenuItem.Name)
            {
                ProductForm AddItemForm = new ProductForm(this, Constant.RAM);
                AddItemForm.ShowDialog();
            }
            else if (e.ClickedItem.Name == NVIDIAStripMenuItem.Name)
            {
                ProductForm AddItemForm = new ProductForm(this, Constant.NVIDIA);
                AddItemForm.ShowDialog();
            }
        }

        private void UpdateButton_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            UpdateItemContextMenuStrip.Show(ptLowerLeft);
        }

        private void ReloadButton_MouseClick(object sender, MouseEventArgs e)
        {
            ReLoadLists();
        }

        private void PCCaseListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product item = null;
            try
            {
                item = mPCDictionary.GetValueOrDefault(PCCaseListComboBox.GetItemText(PCCaseListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (item != null)
            {
                mPCPrice = item.Price;
                txtPCCasePrice.Text = mPCPrice.ToString();
                mCaseBoxName = item.Name;

            }
        }

        private void CPUV2ListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product item = null;
            try
            {
                item = mCPUDictionary.GetValueOrDefault(CPUV2ListComboBox.GetItemText(CPUV2ListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (item != null)
            {
                mCPUPrice = item.Price;
                txtCPUV2Price.Text = mCPUPrice.ToString();
                mCPU1Name = item.Name;

            }
        }

        private void SDDListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product item = null;
            try
            {
                item = mSDDDictionary.GetValueOrDefault(SDDListComboBox.GetItemText(SDDListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (item != null)
            {
                mSSDPrice = item.Price;
                txtSDDPrice.Text = mSSDPrice.ToString();
                mSSDName = item.Name;

            }
        }

        private void HDDListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product item = null;
            try
            {
                item = mHDDDictionary.GetValueOrDefault(HDDListComboBox.GetItemText(HDDListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (item != null)
            {
                mHDDDPrice = item.Price;
                txtHDDPrice.Text = mHDDDPrice.ToString();
                mHDDDName = item.Name;

            }
        }

        private void RAMListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product item = null;
            try
            {
                item = mRAMDictionary.GetValueOrDefault(RAMListComboBox.GetItemText(RAMListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (item != null)
            {
                mRAMPrice = item.Price;
                txtRAMPrice.Text = mRAMPrice.ToString();
                mRAMName = item.Name;
            }
        }

        private void NVIDIAListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product item = null;
            try
            {
                item = mNVIDIADictionary.GetValueOrDefault(NVIDIAListComboBox.GetItemText(NVIDIAListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (item != null)
            {
                mNVIDIAPrice = item.Price;
                txtNVIDIAPrice.Text = mNVIDIAPrice.ToString();
                 mNVIDIAName = item.Name;
            }
        }

        private void MainCalculButton_Click(object sender, EventArgs e)
        {
            var price = CalculTotalPay();
            txtMainResultCalcul.Text = price.ToString();
            GetArticle();
        }

        private double CalculTotalPay()
        {
            double total = 0.0;
            total = CalculTotalPrice() + (CalculTotalPrice() * FeePercentage()) + (CalculTotalPrice() * ProfitPercentage());
            return total;
        }

        private void GetArticle()
        {
            TxtResult.Clear();
            TxtResult.Text += "PC Model: " + mCaseBoxName + Environment.NewLine;
            TxtResult.Text += "CPU: " + mCPU1Name + Environment.NewLine;
            TxtResult.Text += "Memory: " + mRAMName + Environment.NewLine;
            TxtResult.Text += "Storage: " + mSSDName +  " + " + mHDDDName +  Environment.NewLine;
            TxtResult.Text += "Video Card: " + mNVIDIAName + Environment.NewLine;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            TxtResult.SelectAll();
            TxtResult.Copy();
        }


        private double CalculTotalPrice()
        {
            double CalculTotalPrice = mPCPrice + mCPUPrice + mSSDPrice + mHDDDPrice + mRAMPrice + mNVIDIAPrice;
            return CalculTotalPrice;

        }

        private double FeePercentage()
        {
            double dFee = 0;
            try
            {
                dFee = Convert.ToDouble(FeeTextBox.Text);
            }
            catch
            {

            }
            double feePercenage = dFee / 100;
            return feePercenage;
        }

        private double ProfitPercentage()
        {
            double dProfit = 0;
            try
            {
                dProfit = Convert.ToDouble(ProfitTextBox.Text);
            }
            catch{}
            double feePercenage = dProfit / 100;
            return feePercenage;
        }

        private void ProfitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void FeeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void buttonAllProduct_Click(object sender, EventArgs e)
        {
            AllProduct allProduct = new AllProduct(this);
            allProduct.ShowDialog();
        }
    }
}

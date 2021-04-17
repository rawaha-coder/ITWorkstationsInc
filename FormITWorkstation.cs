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

namespace ITWorkstationsInc
{
    public partial class FormITWorkstation : Form
    {
        PCCaseDAO mPCCaseDAO = PCCaseDAO.getInstance();
        CpuV2DAO mCPUV2DAO = CpuV2DAO.getInstance();
        CpuV3DAO mCPUV3DAO = CpuV3DAO.getInstance();
        SDDStorageDAO mSDDStorageDAO = SDDStorageDAO.getInstance();
        HDDStorageDAO mHDDStorageDAO = HDDStorageDAO.getInstance();
        RAMComponentDAO mRAMComponentDAO = RAMComponentDAO.getInstance();
        NVIDIAComponentDAO mNVIDIAComponentDAO = NVIDIAComponentDAO.getInstance();

        Dictionary<string, CaseBox> mCaseBoxDictionary = new Dictionary<string, CaseBox>();
        Dictionary<string, CPUV2> mCPUV2Dictionary = new Dictionary<string, CPUV2>();
        Dictionary<string, CPUV3> mCPUV3Dictionary = new Dictionary<string, CPUV3>();
        Dictionary<string, SDDStorage> mSDDDictionary = new Dictionary<string, SDDStorage>();
        Dictionary<string, HDDStorage> mHDDDictionary = new Dictionary<string, HDDStorage>();
        Dictionary<string, RAMComponent> mRAMComponentDictionary = new Dictionary<string, RAMComponent>();
        Dictionary<string, NVIDIAComponent> mNVIDIAComponentDictionary = new Dictionary<string, NVIDIAComponent>();

        double mCaseBoxPrice = 0.0;
        double mCPUV2Price = 0.0;
        double mCPUV3DPrice = 0.0;
        double mSDDPrice = 0.0;
        double mHDDDPrice = 0.0;
        double mRAMPrice = 0.0;
        double mNVIDIAPrice = 0.0;

        public FormITWorkstation()
        {
            InitializeComponent();
        }

        private void ITWorkstation_Load(object sender, EventArgs e)
        {
            //mNVIDIAComponentDAO.CreateTable();
            ReLoadLists();
            initToZeo();
            initToZeroString();
        }

        private void initToZeo()
        {
            mCaseBoxPrice = 0.0;
            mCPUV2Price = 0.0;
            mCPUV3DPrice = 0.0;
            mSDDPrice = 0.0;
            mHDDDPrice = 0.0;
            mRAMPrice = 0.0;
            mNVIDIAPrice = 0.0;
        }

        private void initToZeroString()
        {
            txtPCCasePrice.Text = "0.0";
            txtCPUV2Price.Text = "0.0";
            txtCPUV3Price.Text = "0.0";
            txtSDDPrice.Text = "0.0";
            txtHDDPrice.Text = "0.0";
            txtRAMPrice.Text = "0.0";
            txtNVIDIAPrice.Text = "0.0";
            txtMainResultCalcul.Text = "0.0";
        }

        public void ReLoadLists()
        {
            initPCCaseList();
            initCPUV2List();
            initCPUV3List();
            initSDDList();
            initHDDList();
            initRAMComponentList();
            initNVIDIAComponentList();
            initToZeo();
            initToZeroString();
        }

        private void initPCCaseList()
        {
            List<string> NamesList = new List<string>();
            mCaseBoxDictionary.Clear();
            try
            {
                mCaseBoxDictionary = mPCCaseDAO.CaseBoxDictionary();
                NamesList.AddRange(mCaseBoxDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                PCCaseListComboBox.DataSource = NamesList;
                PCCaseListComboBox.SelectedIndex = -1;
            }
        }

        private void initCPUV2List()
        {
            List<string> NamesList = new List<string>();
            mCPUV2Dictionary.Clear();
            try
            {
                mCPUV2Dictionary = mCPUV2DAO.CPUV2Dictionary();
                NamesList.AddRange(mCPUV2Dictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                CPUV2ListComboBox.DataSource = NamesList;
                CPUV2ListComboBox.SelectedIndex = -1;
            }
        }

        private void initCPUV3List()
        {
            List<string> NamesList = new List<string>();
            mCPUV3Dictionary.Clear();
            try
            {
                mCPUV3Dictionary = mCPUV3DAO.CPUV3Dictionary();
                NamesList.AddRange(mCPUV3Dictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                CPUV3ListComboBox.DataSource = NamesList;
                CPUV3ListComboBox.SelectedIndex = -1;
            }
        }

        private void initSDDList()
        {
            List<string> NamesList = new List<string>();
            mSDDDictionary.Clear();
            try
            {
                mSDDDictionary = mSDDStorageDAO.SDDDictionary();
                NamesList.AddRange(mSDDDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
                mHDDDictionary = mHDDStorageDAO.HDDDictionary();
                NamesList.AddRange(mHDDDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                HDDListComboBox.DataSource = NamesList;
                HDDListComboBox.SelectedIndex = -1;
            }
        }


        private void initRAMComponentList()
        {
            List<string> NamesList = new List<string>();
            mRAMComponentDictionary.Clear();
            try
            {
                mRAMComponentDictionary = mRAMComponentDAO.RAMComponentDictionary();
                NamesList.AddRange(mRAMComponentDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                RAMListComboBox.DataSource = NamesList;
                RAMListComboBox.SelectedIndex = -1;
            }
        }

        private void initNVIDIAComponentList()
        {
            List<string> NamesList = new List<string>();
            mRAMComponentDictionary.Clear();
            try
            {
                mNVIDIAComponentDictionary = mNVIDIAComponentDAO.NVIDIAComponentDictionary();
                NamesList.AddRange(mNVIDIAComponentDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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

                PCCaseForm AddItemForm = new PCCaseForm(this);
                AddItemForm.ShowAddForm();

            }
            else if (e.ClickedItem.Name == CPUV2StripMenuItem.Name)
            {
                CPUV2Form AddItemForm = new CPUV2Form(this);
                AddItemForm.ShowAddForm();
            }
            else if (e.ClickedItem.Name == CPUV3StripMenuItem.Name)
            {
                CPUV3Form AddItemForm = new CPUV3Form(this);
                AddItemForm.ShowAddForm();
            }
            else if (e.ClickedItem.Name == SDDStripMenuItem.Name)
            {
                SDDStorageForm AddItemForm = new SDDStorageForm(this);
                AddItemForm.ShowAddForm();
            }
            else if (e.ClickedItem.Name == HDDStripMenuItem.Name)
            {
                HDDStorageForm AddItemForm = new HDDStorageForm(this);
                AddItemForm.ShowAddForm();
            }
            else if (e.ClickedItem.Name == RAMStripMenuItem.Name)
            {
                RAMComponentForm AddItemForm = new RAMComponentForm(this);
                AddItemForm.ShowAddForm();
            }
            else if (e.ClickedItem.Name == NVIDIAStripMenuItem.Name)
            {
                NVIDIAComponentForm AddItemForm = new NVIDIAComponentForm(this);
                AddItemForm.ShowAddForm();
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
            CaseBox caseBox = null;
            try
            {
                caseBox = mCaseBoxDictionary.GetValueOrDefault(PCCaseListComboBox.GetItemText(PCCaseListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (caseBox != null)
            {
                mCaseBoxPrice = caseBox.CasePrice;
                txtPCCasePrice.Text = mCaseBoxPrice.ToString();
            }
        }

        private void CPUV2ListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPUV2 cpuv2 = null;
            try
            {
                cpuv2 = mCPUV2Dictionary.GetValueOrDefault(CPUV2ListComboBox.GetItemText(CPUV2ListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (cpuv2 != null)
            {
                mCPUV2Price = cpuv2.Cpuv2Price;
                txtCPUV2Price.Text = mCPUV2Price.ToString();
            }
        }

        private void CPUV3ListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPUV3 cpuv3 = null;
            try
            {
                cpuv3 = mCPUV3Dictionary.GetValueOrDefault(CPUV3ListComboBox.GetItemText(CPUV3ListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (cpuv3 != null)
            {
                mCPUV3DPrice = cpuv3.Cpuv3Price;
                txtCPUV3Price.Text = mCPUV3DPrice.ToString();
            }
        }

        private void SDDListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SDDStorage sDDStorage = null;
            try
            {
                sDDStorage = mSDDDictionary.GetValueOrDefault(SDDListComboBox.GetItemText(SDDListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (sDDStorage != null)
            {
                mSDDPrice = sDDStorage.Price;
                txtSDDPrice.Text = mSDDPrice.ToString();
            }
        }

        private void HDDListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HDDStorage hDDStorage = null;
            try
            {
                hDDStorage = mHDDDictionary.GetValueOrDefault(HDDListComboBox.GetItemText(HDDListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (hDDStorage != null)
            {
                mHDDDPrice = hDDStorage.Price;
                txtHDDPrice.Text = mHDDDPrice.ToString();
            }
        }

        private void RAMListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RAMComponent ram = null;
            try
            {
                ram = mRAMComponentDictionary.GetValueOrDefault(RAMListComboBox.GetItemText(RAMListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (ram != null)
            {
                mRAMPrice = ram.Price;
                txtRAMPrice.Text = mRAMPrice.ToString();
            }
        }

        private void NVIDIAListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NVIDIAComponent nVIDIA = null;
            try
            {
                nVIDIA = mNVIDIAComponentDictionary.GetValueOrDefault(NVIDIAListComboBox.GetItemText(NVIDIAListComboBox.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (nVIDIA != null)
            {
                mNVIDIAPrice = nVIDIA.Price;
                txtNVIDIAPrice.Text = mNVIDIAPrice.ToString();
            }
        }

        private void MainCalculButton_Click(object sender, EventArgs e)
        {
            var price = CalculTotalPay();
            txtMainResultCalcul.Text = price.ToString();
        }

        private double CalculTotalPay()
        {
            double total = 0.0;
            total = CalculTotalPrice() + (CalculTotalPrice() * FeePercentage()) + (CalculTotalPrice() * ProfitPercentage());
            return total;
        }

        private double CalculTotalPrice()
        {
            double CalculTotalPrice = mCaseBoxPrice + mCPUV2Price + mCPUV3DPrice + mSDDPrice + mHDDDPrice + mRAMPrice + mNVIDIAPrice;
            return CalculTotalPrice;

        }

        private double FeePercentage()
        {
            var sFee = FeeComboBox.Text;
            double dFee = Convert.ToDouble(sFee);
            double feePercenage = dFee / 100;
            return feePercenage;
        }

        private double ProfitPercentage()
        {
            var sProfit = ProfitComboBox.Text;
            double dProfit = Convert.ToDouble(sProfit);
            double feePercenage = dProfit / 100;
            return feePercenage;
        }


    }
}

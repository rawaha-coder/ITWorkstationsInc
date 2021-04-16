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

        Dictionary<string, CaseBox> mCaseBoxDictionary = new Dictionary<string, CaseBox>();
        Dictionary<string, CPUV2> mCPUV2Dictionary = new Dictionary<string, CPUV2>();
        Dictionary<string, CPUV3> mCPUV3Dictionary = new Dictionary<string, CPUV3>();
        Dictionary<string, SDDStorage> mSDDDictionary = new Dictionary<string, SDDStorage>();
        Dictionary<string, HDDStorage> mHDDDictionary = new Dictionary<string, HDDStorage>();

        public FormITWorkstation()
        {
            InitializeComponent();
        }

        private void ITWorkstation_Load(object sender, EventArgs e)
        {
            //mHDDStorageDAO.CreateTable();
            ReLoadLists();
        }

        public void ReLoadLists()
        {
            initPCCaseList();
            initCPUV2List();
            initCPUV3List();
            initSDDList();
            initHDDList();
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
            }
        }

        private void initHDDList()
        {
            List<string> NamesList = new List<string>();
            mHDDDictionary.Clear();
            try
            {
                mHDDDictionary = mHDDStorageDAO.HDDDictionary();
                NamesList.AddRange(mSDDDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                HDDListComboBox.DataSource = NamesList;
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
                MessageBox.Show(e.ClickedItem.Name);
            }
            else if (e.ClickedItem.Name == NVIDIAStripMenuItem.Name)
            {
                MessageBox.Show(e.ClickedItem.Name);
            }
        }

        private void UpdateButton_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            UpdateItemContextMenuStrip.Show(ptLowerLeft);
        }
    }
}

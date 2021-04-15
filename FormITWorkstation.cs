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
        Dictionary<string, CaseBox> mCaseBoxDictionary = new Dictionary<string, CaseBox>();

        public FormITWorkstation()
        {
            InitializeComponent();
        }

        private void ITWorkstation_Load(object sender, EventArgs e)
        {
            //mPCCaseDAO.CreateTable();
            initPCCaseList();
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

        private void UpdateItemContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == PCCaseStripMenuItem.Name)
            {

                PCCaseForm AddItemForm = new PCCaseForm(this);
                AddItemForm.ShowAddForm();

            }
            else if (e.ClickedItem.Name == PCCaseStripMenuItem.Name)
            {
                MessageBox.Show(e.ClickedItem.Name);
            }
            else if (e.ClickedItem.Name == CPUV2StripMenuItem.Name)
            {
                MessageBox.Show(e.ClickedItem.Name);
            }
            else if (e.ClickedItem.Name == CPUV3StripMenuItem.Name)
            {
                MessageBox.Show(e.ClickedItem.Name);
            }
            else if (e.ClickedItem.Name == SDDStripMenuItem.Name)
            {
                MessageBox.Show(e.ClickedItem.Name);
            }
            else if (e.ClickedItem.Name == HDDStripMenuItem.Name)
            {
                MessageBox.Show(e.ClickedItem.Name);
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

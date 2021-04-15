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
    public partial class PCCaseForm : Form
    {

        private static PCCaseForm instance;
        FormITWorkstation formITWorkstation;
        PCCaseDAO mPCCaseDAO = PCCaseDAO.getInstance();
        Dictionary<string, CaseBox> mCaseBoxDictionary = new Dictionary<string, CaseBox>();
        List<string> mCaseBoxList = new List<string>();
        


        public PCCaseForm(FormITWorkstation formITWorkstation)
        {
            this.formITWorkstation = formITWorkstation;
            InitializeComponent();
        }

        public static PCCaseForm getInstance(FormITWorkstation formITWorkstation)
        {
            if (instance == null)
            {
                instance = new PCCaseForm(formITWorkstation);
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
                instance = new PCCaseForm(formITWorkstation);

            }
            instance.Show();
        }

        private void PCCaseForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
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
                comboBoxAddPCCase.DataSource = NamesList;
            }
        }

        private void buttonAddPCCaseData_Click(object sender, EventArgs e)
        {
            CaseBox caseBox = new CaseBox();
            caseBox.CaseName = comboBoxAddPCCase.Text;
            caseBox.CasePrice = Convert.ToDouble(textBoxAddPCCasePrice.Text);
            mPCCaseDAO.addData(caseBox);
        }

        private void buttonEditPCCaseData_Click(object sender, EventArgs e)
        {
            CaseBox caseBox = new CaseBox();
            caseBox.CaseId = comboBoxAddPCCase.FindStringExact(comboBoxAddPCCase.Text);
            caseBox.CaseName = comboBoxAddPCCase.Text;
            caseBox.CasePrice = Convert.ToDouble(textBoxAddPCCasePrice.Text);
            mPCCaseDAO.UpdateData(caseBox);
        }

        private void buttonDeletePCCaseData_Click(object sender, EventArgs e)
        {

        }

        private void buttonPCCaseAddForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PCCaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}

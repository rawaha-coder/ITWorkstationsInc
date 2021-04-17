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
    public partial class PCCaseForm : Form
    {

        private static PCCaseForm instance;
        FormITWorkstation formITWorkstation;
        PCCaseDAO mPCCaseDAO = PCCaseDAO.getInstance();
        Dictionary<string, CaseBox> mCaseBoxDictionary = new Dictionary<string, CaseBox>();

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
                comboBoxAddPCCase.SelectedIndex = -1;
                textBoxAddPCCasePrice.Text = "";
            }
        }

        private void buttonAddPCCaseData_Click(object sender, EventArgs e)
        {
            if (comboBoxAddPCCase.Text == "" || !Utility.ValidateInput.validateNumber(textBoxAddPCCasePrice.Text))
            {
                MessageBox.Show("Item Not Added, check the values");
                return;
            }
            try
            {
                CaseBox caseBox = new CaseBox();
                caseBox.CaseName = comboBoxAddPCCase.Text;
                caseBox.CasePrice = Convert.ToDouble(textBoxAddPCCasePrice.Text);
                if (mPCCaseDAO.addData(caseBox))
                {
                    MessageBox.Show("Item Added");
                }
                else
                {
                    MessageBox.Show("Item Not Added, check the values");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item Not Added, check the values");
            }

            initForm();
        }

        private void buttonEditPCCaseData_Click(object sender, EventArgs e)
        {
            try
            {
                CaseBox caseBox = new CaseBox();
                caseBox.CaseId = mCaseBoxDictionary.GetValueOrDefault(comboBoxAddPCCase.GetItemText(comboBoxAddPCCase.SelectedItem)).CaseId;
                caseBox.CasePrice = Convert.ToDouble(textBoxAddPCCasePrice.Text);
                if (mPCCaseDAO.UpdateData(caseBox))
                {
                    MessageBox.Show("Item Updated");
                }
                else
                {
                    MessageBox.Show("Item Not Updated, check the values");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item Not Updated, check the values");
            }
            initForm();
        }

        private void buttonDeletePCCaseData_Click(object sender, EventArgs e)
        {
            try
            {
                CaseBox caseBox = mCaseBoxDictionary.GetValueOrDefault(comboBoxAddPCCase.GetItemText(comboBoxAddPCCase.SelectedItem));
                if (mPCCaseDAO.DeleteData(caseBox))
                {
                    MessageBox.Show("Item Deleted");
                }
                else
                {
                    MessageBox.Show("Item Not Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item Not Deleted");
            }
            initForm();
            if (mCaseBoxDictionary.Count == 0)
            {
                comboBoxAddPCCase.Text = "";
            }
        }

        private void buttonPCCaseAddForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PCCaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void comboBoxAddPCCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaseBox caseBox = null;
            try
            {
                caseBox = mCaseBoxDictionary.GetValueOrDefault(comboBoxAddPCCase.GetItemText(comboBoxAddPCCase.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (caseBox != null)
            {
                textBoxAddPCCasePrice.Text = caseBox.CasePrice.ToString();
            }
        }
    }
}

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
    public partial class CPUV2Form : Form
    {
        private static CPUV2Form instance;
        FormITWorkstation formITWorkstation;
        CpuV2DAO mCPUV2DAO = CpuV2DAO.getInstance();
        Dictionary<string, CPUV2> itemDictionary = new Dictionary<string, CPUV2>();
        public CPUV2Form(FormITWorkstation formITWorkstation)
        {
            this.formITWorkstation = formITWorkstation;
            InitializeComponent();
        }

        public static CPUV2Form getInstance(FormITWorkstation formITWorkstation)
        {
            if (instance == null)
            {
                instance = new CPUV2Form(formITWorkstation);
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
                instance = new CPUV2Form(formITWorkstation);

            }
            instance.Show();
        }

        private void CPUV2Form_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            List<string> NamesList = new List<string>();
            itemDictionary.Clear();
            try
            {
                itemDictionary = mCPUV2DAO.CPUV2Dictionary();
                NamesList.AddRange(itemDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                comboBoxAddCPUV2.DataSource = NamesList;
                comboBoxAddCPUV2.SelectedIndex = -1;
                textBoxAddCPUV2Price.Text = "";
            }
        }

        private void buttonAddCPUV2Data_Click(object sender, EventArgs e)
        {
            CPUV2 cpuv2 = new CPUV2();
            cpuv2.Cpuv2Name = comboBoxAddCPUV2.Text;
            cpuv2.Cpuv2Price = Convert.ToDouble(textBoxAddCPUV2Price.Text);
            if (mCPUV2DAO.addData(cpuv2))
            {
                MessageBox.Show("Item Added");
            }
            else
            {
                MessageBox.Show("Item Not Added, check the values");
            }
            initForm();
        }

        private void buttonEditCPUV2Data_Click(object sender, EventArgs e)
        {
            try
            {
                CPUV2 cpuv2 = new CPUV2();
                cpuv2.Cpuv2Id = itemDictionary.GetValueOrDefault(comboBoxAddCPUV2.GetItemText(comboBoxAddCPUV2.SelectedItem)).Cpuv2Id;
                cpuv2.Cpuv2Price = Convert.ToDouble(textBoxAddCPUV2Price.Text);
                if (mCPUV2DAO.UpdateData(cpuv2))
                {
                    MessageBox.Show("Item Updated");
                }
                else
                {
                    MessageBox.Show("Item Not Updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            initForm();
        }

        private void buttonDeleteCPUV2Data_Click(object sender, EventArgs e)
        {
            try
            {
                CPUV2 cpuv2 = itemDictionary.GetValueOrDefault(comboBoxAddCPUV2.GetItemText(comboBoxAddCPUV2.SelectedItem));
                if (mCPUV2DAO.DeleteData(cpuv2))
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
                Console.WriteLine(ex.Message);
            }
            initForm();
            if (itemDictionary.Count == 0)
            {
                comboBoxAddCPUV2.Text = "";
            }
        }

        private void buttonCloseCPUV2AddForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CPUV2Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void comboBoxAddCPUV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPUV2 cpuv2 = null;
            try
            {
                cpuv2 = itemDictionary.GetValueOrDefault(comboBoxAddCPUV2.GetItemText(comboBoxAddCPUV2.SelectedItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (cpuv2 != null)
            {
                textBoxAddCPUV2Price.Text = cpuv2.Cpuv2Price.ToString();
            }
        }
    }
}

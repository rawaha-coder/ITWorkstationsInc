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
    public partial class CPUV3Form : Form
    {
        private static CPUV3Form instance;
        FormITWorkstation formITWorkstation;
        CpuV3DAO mCPUV3DAO = CpuV3DAO.getInstance();
        Dictionary<string, CPUV3> itemDictionary = new Dictionary<string, CPUV3>();
       
        public CPUV3Form(FormITWorkstation formITWorkstation)
        {
            this.formITWorkstation = formITWorkstation;
            InitializeComponent();
        }

        public static CPUV3Form getInstance(FormITWorkstation formITWorkstation)
        {
            if (instance == null)
            {
                instance = new CPUV3Form(formITWorkstation);
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
                instance = new CPUV3Form(formITWorkstation);

            }
            instance.Show();
        }

        private void CPUV3Form_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            List<string> NamesList = new List<string>();
            itemDictionary.Clear();
            try
            {
                itemDictionary = mCPUV3DAO.CPUV3Dictionary();
                NamesList.AddRange(itemDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                comboBoxAddCPUV3.DataSource = NamesList;
                comboBoxAddCPUV3.SelectedIndex = -1;
                textBoxAddCPUV3Price.Text = "";
            }
        }

        private void buttonAddCPUV3Data_Click(object sender, EventArgs e)
        {
            CPUV3 cpuv3 = new CPUV3();
            cpuv3.Cpuv3Name = comboBoxAddCPUV3.Text;
            cpuv3.Cpuv3Price = Convert.ToDouble(textBoxAddCPUV3Price.Text);
            if (mCPUV3DAO.addData(cpuv3))
            {
                MessageBox.Show("Item Added");
            }
            else
            {
                MessageBox.Show("Item Not Added, check the values");
            }
            initForm();
        }

        private void buttonEditCPUV3Data_Click(object sender, EventArgs e)
        {
            try
            {
                CPUV3 cpuv3 = new CPUV3();
                cpuv3.Cpuv3Id = itemDictionary.GetValueOrDefault(comboBoxAddCPUV3.GetItemText(comboBoxAddCPUV3.SelectedItem)).Cpuv3Id;
                cpuv3.Cpuv3Price = Convert.ToDouble(textBoxAddCPUV3Price.Text);
                if (mCPUV3DAO.UpdateData(cpuv3))
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

        private void buttonDeleteCPUV3Data_Click(object sender, EventArgs e)
        {
            try
            {
                CPUV3 cpuv3 = itemDictionary.GetValueOrDefault(comboBoxAddCPUV3.GetItemText(comboBoxAddCPUV3.SelectedItem));
                if (mCPUV3DAO.DeleteData(cpuv3))
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
                comboBoxAddCPUV3.Text = "";
            }
        }

        private void buttonCloseCPUV3AddForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CPUV3Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void comboBoxAddCPUV3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPUV3 cpuv3 = null;
            try
            {
                cpuv3 = itemDictionary.GetValueOrDefault(comboBoxAddCPUV3.GetItemText(comboBoxAddCPUV3.SelectedItem));
                if (cpuv3 != null)
                {
                    textBoxAddCPUV3Price.Text = cpuv3.Cpuv3Price.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

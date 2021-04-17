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
    public partial class SDDStorageForm : Form
    {
        private static SDDStorageForm instance;
        FormITWorkstation formITWorkstation;
        SDDStorageDAO mSDDStorageDAO = SDDStorageDAO.getInstance();
        Dictionary<string, SDDStorage> itemDictionary = new Dictionary<string, SDDStorage>();

        public SDDStorageForm(FormITWorkstation formITWorkstation)
        {
            this.formITWorkstation = formITWorkstation;
            InitializeComponent();
        }

        public static SDDStorageForm getInstance(FormITWorkstation formITWorkstation)
        {
            if (instance == null)
            {
                instance = new SDDStorageForm(formITWorkstation);
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
                instance = new SDDStorageForm(formITWorkstation);

            }
            instance.Show();
        }

        private void SDDStorageForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            List<string> NamesList = new List<string>();
            itemDictionary.Clear();
            try
            {
                itemDictionary = mSDDStorageDAO.SDDDictionary();
                NamesList.AddRange(itemDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                comboBoxAddSDD.DataSource = NamesList;
                comboBoxAddSDD.SelectedIndex = -1;
                textBoxAddSDDPrice.Text = "";
            }
        }

        private void buttonAddSDDData_Click(object sender, EventArgs e)
        {
            if (comboBoxAddSDD.Text == "" || !Utility.ValidateInput.validateNumber(textBoxAddSDDPrice.Text))
            {
                MessageBox.Show("Item Not Added, check the values");
                return;
            }
            SDDStorage item = new SDDStorage();
            item.Name = comboBoxAddSDD.Text;
            item.Price = Convert.ToDouble(textBoxAddSDDPrice.Text);
            if (mSDDStorageDAO.addData(item))
            {
                MessageBox.Show("Item Added");
            }
            else
            {
                MessageBox.Show("Item Not Added, check the values");
            }
            initForm();
        }

        private void buttonEditSDDData_Click(object sender, EventArgs e)
        {
            try
            {
                SDDStorage item = new SDDStorage();
                item.Id = itemDictionary.GetValueOrDefault(comboBoxAddSDD.GetItemText(comboBoxAddSDD.SelectedItem)).Id;
                item.Price = Convert.ToDouble(textBoxAddSDDPrice.Text);
                if (mSDDStorageDAO.UpdateData(item))
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

        private void buttonDeleteSDDData_Click(object sender, EventArgs e)
        {
            try
            {
                SDDStorage item = itemDictionary.GetValueOrDefault(comboBoxAddSDD.GetItemText(comboBoxAddSDD.SelectedItem));
                if (mSDDStorageDAO.DeleteData(item))
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
                comboBoxAddSDD.Text = "";
            }
        }

        private void buttonCloseSDDAddForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SDDStorageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void comboBoxAddSDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            SDDStorage item = null;
            try
            {
                item = itemDictionary.GetValueOrDefault(comboBoxAddSDD.GetItemText(comboBoxAddSDD.SelectedItem));
                if (item != null)
                {
                    textBoxAddSDDPrice.Text = item.Price.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

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
    public partial class HDDStorageForm : Form
    {
        private static HDDStorageForm instance;
        FormITWorkstation formITWorkstation;
        HDDStorageDAO mHDDStorageDAO = HDDStorageDAO.getInstance();
        Dictionary<string, HDDStorage> itemDictionary = new Dictionary<string, HDDStorage>();

        public HDDStorageForm(FormITWorkstation formITWorkstation)
        {
            this.formITWorkstation = formITWorkstation;
            InitializeComponent();
        }

        public static HDDStorageForm getInstance(FormITWorkstation formITWorkstation)
        {
            if (instance == null)
            {
                instance = new HDDStorageForm(formITWorkstation);
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
                instance = new HDDStorageForm(formITWorkstation);

            }
            instance.Show();
        }

        private void HDDStorageForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            List<string> NamesList = new List<string>();
            itemDictionary.Clear();
            try
            {
                itemDictionary = mHDDStorageDAO.HDDDictionary();
                NamesList.AddRange(itemDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                comboBoxAddHDD.DataSource = NamesList;
                comboBoxAddHDD.SelectedIndex = -1;
                textBoxAddHDDPrice.Text = "";
            }
        }

        private void buttonAddHDDData_Click(object sender, EventArgs e)
        {
            HDDStorage item = new HDDStorage();
            item.Name = comboBoxAddHDD.Text;
            item.Price = Convert.ToDouble(textBoxAddHDDPrice.Text);
            if (mHDDStorageDAO.addData(item))
            {
                MessageBox.Show("Item Added");
            }
            else
            {
                MessageBox.Show("Item Not Added, check the values");
            }
            initForm();
        }

        private void buttonEditHDDData_Click(object sender, EventArgs e)
        {
            try
            {
                HDDStorage item = new HDDStorage();
                item.Id = itemDictionary.GetValueOrDefault(comboBoxAddHDD.GetItemText(comboBoxAddHDD.SelectedItem)).Id;
                item.Price = Convert.ToDouble(textBoxAddHDDPrice.Text);
                if (mHDDStorageDAO.UpdateData(item))
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

        private void buttonDeleteHDDData_Click(object sender, EventArgs e)
        {
            try
            {
                HDDStorage item = itemDictionary.GetValueOrDefault(comboBoxAddHDD.GetItemText(comboBoxAddHDD.SelectedItem));
                if (mHDDStorageDAO.DeleteData(item))
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
                comboBoxAddHDD.Text = "";
            }
        }

        private void buttonCloseHDDAddForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HDDStorageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void comboBoxAddHDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            HDDStorage item = null;
            try
            {
                item = itemDictionary.GetValueOrDefault(comboBoxAddHDD.GetItemText(comboBoxAddHDD.SelectedItem));
                if (item != null)
                {
                    textBoxAddHDDPrice.Text = item.Price.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

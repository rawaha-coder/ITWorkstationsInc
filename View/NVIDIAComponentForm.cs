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
    public partial class NVIDIAComponentForm : Form
    {
        private static NVIDIAComponentForm instance;
        FormITWorkstation formITWorkstation;
        NVIDIAComponentDAO mNVIDIAComponentDAO = NVIDIAComponentDAO.getInstance();
        Dictionary<string, NVIDIAComponent> itemDictionary = new Dictionary<string, NVIDIAComponent>();

        public NVIDIAComponentForm(FormITWorkstation formITWorkstation)
        {
            this.formITWorkstation = formITWorkstation;
            InitializeComponent();
        }

        public static NVIDIAComponentForm getInstance(FormITWorkstation formITWorkstation)
        {
            if (instance == null)
            {
                instance = new NVIDIAComponentForm(formITWorkstation);
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
                instance = new NVIDIAComponentForm(formITWorkstation);

            }
            instance.Show();
        }

        private void NVIDIAComponentForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            List<string> NamesList = new List<string>();
            itemDictionary.Clear();
            try
            {
                itemDictionary = mNVIDIAComponentDAO.NVIDIAComponentDictionary();
                NamesList.AddRange(itemDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                comboBoxAddNVIDIAComponent.DataSource = NamesList;
                comboBoxAddNVIDIAComponent.SelectedIndex = -1;
                textBoxAddNVIDIAComponentPrice.Text = "";
            }
        }

        private void buttonAddNVIDIAComponentData_Click(object sender, EventArgs e)
        {
            if (comboBoxAddNVIDIAComponent.Text == "" || !Utility.ValidateInput.validateNumber(textBoxAddNVIDIAComponentPrice.Text))
            {
                MessageBox.Show("Item Not Added, check the values");
                return;
            }
            try
            {
                NVIDIAComponent item = new NVIDIAComponent();
                item.Name = comboBoxAddNVIDIAComponent.Text;
                item.Price = Convert.ToDouble(textBoxAddNVIDIAComponentPrice.Text);
                if (mNVIDIAComponentDAO.addData(item))
                {
                    MessageBox.Show("Item Added");
                }
                else
                {
                    MessageBox.Show("Item Not Added, check the values");
                }
            }
            catch(Exception eex)
            {
                MessageBox.Show("Item Not Added, check the values");
            }

            initForm();
        }

        private void buttonEditNVIDIAComponentData_Click(object sender, EventArgs e)
        {
            try
            {
                NVIDIAComponent item = new NVIDIAComponent();
                item.Id = itemDictionary.GetValueOrDefault(comboBoxAddNVIDIAComponent.GetItemText(comboBoxAddNVIDIAComponent.SelectedItem)).Id;
                item.Price = Convert.ToDouble(textBoxAddNVIDIAComponentPrice.Text);
                if (mNVIDIAComponentDAO.UpdateData(item))
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

        private void buttonDeleteNVIDIAComponentData_Click(object sender, EventArgs e)
        {
            try
            {
                NVIDIAComponent item = itemDictionary.GetValueOrDefault(comboBoxAddNVIDIAComponent.GetItemText(comboBoxAddNVIDIAComponent.SelectedItem));
                if (mNVIDIAComponentDAO.DeleteData(item))
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
                comboBoxAddNVIDIAComponent.Text = "";
            }
        }

        private void buttonCloseNVIDIAComponentAddForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NVIDIAComponentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void comboBoxAddNVIDIAComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            NVIDIAComponent item = null;
            try
            {
                item = itemDictionary.GetValueOrDefault(comboBoxAddNVIDIAComponent.GetItemText(comboBoxAddNVIDIAComponent.SelectedItem));
                if (item != null)
                {
                    textBoxAddNVIDIAComponentPrice.Text = item.Price.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

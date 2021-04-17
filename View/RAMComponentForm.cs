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
    public partial class RAMComponentForm : Form
    {

        private static RAMComponentForm instance;
        FormITWorkstation formITWorkstation;
        RAMComponentDAO mRAMComponentDAO = RAMComponentDAO.getInstance();
        Dictionary<string, RAMComponent> itemDictionary = new Dictionary<string, RAMComponent>();

        public RAMComponentForm(FormITWorkstation formITWorkstation)
        {
            this.formITWorkstation = formITWorkstation;
            InitializeComponent();
        }

        public static RAMComponentForm getInstance(FormITWorkstation formITWorkstation)
        {
            if (instance == null)
            {
                instance = new RAMComponentForm(formITWorkstation);
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
                instance = new RAMComponentForm(formITWorkstation);

            }
            instance.Show();
        }

        private void RAMComponentForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            List<string> NamesList = new List<string>();
            itemDictionary.Clear();
            try
            {
                itemDictionary = mRAMComponentDAO.RAMComponentDictionary();
                NamesList.AddRange(itemDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                comboBoxAddRAMComponent.DataSource = NamesList;
                comboBoxAddRAMComponent.SelectedIndex = -1;
                textBoxAddRAMComponentPrice.Text = "";
            }
        }

        private void buttonAddRAMComponentData_Click(object sender, EventArgs e)
        {
            if (comboBoxAddRAMComponent.Text == "" || !Utility.ValidateInput.validateNumber(textBoxAddRAMComponentPrice.Text))
            {
                MessageBox.Show("Item Not Added, check the values");
                return;
            }
            try
            {
                RAMComponent item = new RAMComponent();
                item.Name = comboBoxAddRAMComponent.Text;
                item.Price = Convert.ToDouble(textBoxAddRAMComponentPrice.Text);
                if (mRAMComponentDAO.addData(item))
                {
                    MessageBox.Show("Item Added");
                }
                else
                {
                    MessageBox.Show("Item Not Added, check the values");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Item Not Added, check the values");
            }

            initForm();
        }

        private void buttonEditRAMComponentData_Click(object sender, EventArgs e)
        {
            try
            {
                RAMComponent item = new RAMComponent();
                item.Id = itemDictionary.GetValueOrDefault(comboBoxAddRAMComponent.GetItemText(comboBoxAddRAMComponent.SelectedItem)).Id;
                item.Price = Convert.ToDouble(textBoxAddRAMComponentPrice.Text);
                if (mRAMComponentDAO.UpdateData(item))
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

        private void buttonDeleteRAMComponentData_Click(object sender, EventArgs e)
        {
            try
            {
                RAMComponent item = itemDictionary.GetValueOrDefault(comboBoxAddRAMComponent.GetItemText(comboBoxAddRAMComponent.SelectedItem));
                if (mRAMComponentDAO.DeleteData(item))
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
                comboBoxAddRAMComponent.Text = "";
            }
        }

        private void buttonCloseRAMComponentAddForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RAMComponentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void comboBoxAddRAMComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            RAMComponent item = null;
            try
            {
                item = itemDictionary.GetValueOrDefault(comboBoxAddRAMComponent.GetItemText(comboBoxAddRAMComponent.SelectedItem));
                if (item != null)
                {
                    textBoxAddRAMComponentPrice.Text = item.Price.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

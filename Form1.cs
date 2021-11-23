using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarStoreFormGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new();
        BindingSource BindInventory = new();
        BindingSource BindCheckOut = new();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Create_button_Click(object sender, EventArgs e)
        {
            try
            {
                Car dealer = new(Make_textBox.Text, Model_textBox.Text, decimal.Parse(Price_textBox.Text), double.Parse(Engine_textBox.Text), Colour_textBox.Text, Condition_checkBox.Checked);
                myStore.CarList.Add(dealer);
                BindInventory.ResetBindings(false);
                Make_textBox.Text = "";
                Model_textBox.Text = "";
                Price_textBox.Text = "";
                Engine_textBox.Text = "";
                Colour_textBox.Text = "";
                Condition_checkBox.Checked = true;
            }
            catch
            {
                MessageBox.Show("invalid input");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindInventory.DataSource = myStore.CarList;
            Inventory_listBox.DataSource = BindInventory;
            Inventory_listBox.DisplayMember = ToString();

            BindCheckOut.DataSource = myStore.ShopList;
            CheckOut_listBox.DataSource = BindCheckOut;
            CheckOut_listBox.DisplayMember = ToString();
        }

        private void Inventory_button_Click(object sender, EventArgs e)
        {
            Car select = (Car)Inventory_listBox.SelectedItem;
            myStore.ShopList.Add(select);
            BindCheckOut.ResetBindings(false);
        }

        private void CheckOut_button_Click(object sender, EventArgs e)
        {
            decimal total = myStore.CheckOut();
            Currency_label.Text = "R" + total.ToString();
            BindCheckOut.ResetBindings(false);
        }

      
    }
}

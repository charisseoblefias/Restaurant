using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            QuantityListBox.Items.Add(QuantityTextBox.Text);
            MenuItemListBox.Items.Add(MenuItemTextBox.Text);
            PriceListBox.Items.Add(PriceTextBox.Text);
        }

        private void TotalBillButton_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
			for (int i = 0; i < QuantityListBox.Items.Count; i++)
			{
				sum += Convert.ToDecimal(QuantityListBox.Items[i]) * Convert.ToDecimal(PriceListBox.Items[i]);
			}
			TotalCostTextBox.Text = sum.ToString("c");
        }
    }
}

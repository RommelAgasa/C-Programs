using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_12___Duazo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayBill_Click(object sender, EventArgs e)
        {
            decimal decLaborCost = 0m;
            decimal decCostPart = 0m;
            decimal decTotal = 0m;
            decimal decSaleTax = .09m;

            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Empty Name", "Auto Repair Shop",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Focus();
                txtCustomerName.SelectAll();
                return;
            }

            try
            {
                decLaborCost = decimal.Parse(txtLaborCost.Text);
            }
            catch
            {
                MessageBox.Show("You entered invalid input.", "Auto Repair Shop",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLaborCost.Focus();
                txtLaborCost.SelectAll();
                return;
            }

            try
            {
                decCostPart = decimal.Parse(txtCostPart.Text);
            }
            catch
            {
                MessageBox.Show("You entered invalid input.", "Auto Repair Shop",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCostPart.Focus();
                txtCostPart.SelectAll();
                return;
            }


            // Calculate Total
            decTotal = decLaborCost + (decCostPart + (decCostPart * decSaleTax));

            string currentDate = DateTime.Now.ToString("dd MMM yyyy");
            listBox1.Items.Add(string.Format("{0,-30}{1,-10}", "", "Customer Bill"));
            listBox1.Items.Add("\n");
            listBox1.Items.Add(string.Format("{0,-5}{1,-10}", "Date: ", currentDate));
            listBox1.Items.Add(string.Format("{0,-10}{1,-30}", "Customer: ", txtCustomerName.Text));
            listBox1.Items.Add("\n");
            listBox1.Items.Add(string.Format("{0,-30}{1,30}", "ITEM", "PRICE"));
            listBox1.Items.Add(string.Format("{0,-30}{1,30}", "Labor Cost", decLaborCost));
            listBox1.Items.Add(string.Format("{0,-30}{1,30}", "Cost Part", decCostPart));
            listBox1.Items.Add(string.Format("{0,-30}{1,30}", "", "----------------------------"));
            listBox1.Items.Add(string.Format("{0,-30}{1,30}", "Total", decTotal.ToString("n2")));

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabSheet01___Agasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add elements in the combo box
            cbType.Items.Add("Regular");
            cbType.Items.Add("Decaffeinated");
            cbType.Items.Add("Special Blend");
        }

        /*
         * Program: Lab 01
         * Programmer: Rommel Agasa
         * Date: February 27, 2023
         * Description: Look up the price for bulk coffee
         * based upon quantity and type
         * Uses a structure and arrays, and prints a report
         * of the transactions from the array
         */

        // Declare structure and class-level variables
        private struct CoffeeSale
        {
            public string TypeString;
            public string QuantityString;
            public decimal PriceDecimal;
        }

        private class CoffeSale1
        {
            public string TypeString;
            public string QuantityString;
            public decimal PriceDecimal;
        }

       
        private CoffeeSale[] TransactionCoffeeSales = new CoffeeSale[21];
        private int NumberTransactionsInteger = 0;

        private decimal[,] priceDecimal =
        {   /*              Regular,  Caffeinated, Special Blend       */
        /*Quarter Pound*/   { 2.6M,   2.9M,        3.25M},
        /*Half Pound*/      { 4.9M,   5.6M,        6.1M},
        /*Full Pound*/      { 8.75M,  5.6M,        11.25M }

        };

        private string selectedButtonString;

        private void rdoQuarterPound_CheckedChanged(object sender, EventArgs e)
        {
            selectedButtonString = "Quarter Pound";
        }

        private void rdoHalfPound_CheckedChanged(object sender, EventArgs e)
        {
            selectedButtonString = "Half Pound";
        }

        private void rdoFullPound_CheckedChanged(object sender, EventArgs e)
        {
            selectedButtonString = "Full Pound";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int RowInteger = 0;
            int ColumnInteger = 0;
            decimal decSalePrice = 0M;

            // Allow only 21 transactions
            if (NumberTransactionsInteger < 21)
            {
                ColumnInteger = cbType.SelectedIndex;
                if (ColumnInteger != -1)
                {
                    // Coffee selection made, determine quantity selected
                    switch (selectedButtonString)
                    {
                        case "Quarter Pound":
                            RowInteger = 0;
                            TransactionCoffeeSales[NumberTransactionsInteger].QuantityString = selectedButtonString;
                            break;
                        case "Half Pound":
                            RowInteger = 1;
                            TransactionCoffeeSales[NumberTransactionsInteger].QuantityString = selectedButtonString;
                            break;
                        case "Full Pound":
                            RowInteger = 2;
                            TransactionCoffeeSales[NumberTransactionsInteger].QuantityString = selectedButtonString;
                            break;
                        default:
                            // No selection made; use quarter pound
                            RowInteger = 0;
                            TransactionCoffeeSales[NumberTransactionsInteger].QuantityString = selectedButtonString;
                            break;
                    }

                    // Retrieve price of selection.
                    //MessageBox.Show(RowInteger + " " + ColumnInteger);
                    decSalePrice = priceDecimal[RowInteger, ColumnInteger];
                    txtprice.Text = decSalePrice.ToString("C");

                    // Save the transaction
                    TransactionCoffeeSales[NumberTransactionsInteger].TypeString = cbType.Text;
                    TransactionCoffeeSales[NumberTransactionsInteger].PriceDecimal = decSalePrice;
                    NumberTransactionsInteger += 1;

                }
                else
                {
                    MessageBox.Show("Select the coffe type.", "Selection Incomplete",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Sorry, only 20 transactions allowed.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoQuarterPound.Select();
            cbType.SelectedIndex = -1;
            txtprice.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

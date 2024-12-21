namespace LabSheet03___Agasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load each product name into the comboBox
            for (int i = 0; i < strProducts.GetLength(0); i++)
            {
                cbDrink.Items.Add(strProducts[i, 0].ToString());
            }

            // Set the default selection to Wintermelon Special
            cbDrink.SelectedIndex = 0;

            // Assign sizes to comboBox
            cbSize.Items.Add(DrinkSize.Regular);
            cbSize.Items.Add(DrinkSize.Large);
            //Set the default selection to Regular size
            cbSize.SelectedIndex = 0;

        }

        #region Class Level Variables
        // Define product list
        private string[,] strProducts =
        {
            {"Wintermelon Special", "135.00", "155.00" },
            {"Wintermelon Overload", "155.00", "175.00" },
            {"Green Apple", "90.00", "100.00" },
            {"Lychee", "90.00", "100.00" },
            {"Matcha", "110.00", "125.00" }
        };

        // Define enum size
        private enum DrinkSize
        {
            Regular = 1,
            Large
        }

        private string fmtHead = "{0,-23}{1,-11}{2,-9}{3,-4}{4,15}"; // Bill format
        private decimal decTotal = 0m; // Class level total
        private string strDrinks = "";
        private decimal decPrice = 0m;
        private DrinkSize size; // Drink Size

        #endregion

        private void LoadForm()
        {
            // Show Reciept header
            lstBill.Items.Clear();
            lstBill.Items.Add(string.Format("{0,38}", "XYZ Refreshments"));
            lstBill.Items.Add(string.Format("{0,37}", "Customer Bill"));
            lstBill.Items.Add(string.Format("{0,39}", DateTime.Now.ToString("MM/dd/yyyy h:mm tt")));
            lstBill.Items.Add("");
            lstBill.Items.Add("");
            lstBill.Items.Add(string.Format(fmtHead, "Item", "Size", "Price", "Qty", "Sub Total"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int qty = 0;
            decimal subtotal = 0m;

            try
            {
                qty = int.Parse(txtQuantity.Text);
                if (qty < 0) throw new Exception();
            }
            catch
            {
                MessageBox.Show("Invalid Quantity", "XYZ Refreshment",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.SelectAll();
                txtQuantity.Focus();
                return;

            }
              
            cbSize_SelectedIndexChanged(sender, e); // Get the price and the size of the selected drink
            subtotal = decPrice * qty;  // Compute Sub Total
            // Increment Total
            decTotal += subtotal;
            // Add item to receipt
            lstBill.Items.Add(string.Format(fmtHead, cbDrink.SelectedItem, size,
                decPrice.ToString("n2"), qty.ToString(), subtotal.ToString("n2")));
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            lstBill.Items.Add("");
            lstBill.Items.Add("-------------------------------------------------------------------");
            decimal tax = decTotal * .1M;
            lstBill.Items.Add(string.Format(fmtHead, "", "", "TAX", "", tax.ToString("n2")));
            decTotal += tax;
            lstBill.Items.Add(string.Format(fmtHead, "", "", "TOTAL", "", decTotal.ToString("n2")));
            decTotal = 0; 
        }

        private void cbDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            strDrinks = cbDrink.Text;
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = (DrinkSize)cbSize.SelectedIndex + 1; // Assign Size
            decPrice = GetPrice(cbDrink.SelectedIndex, size); // Call the GetPrice method to identify the price
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            txtQuantity.Clear();
            LoadForm();
        }

        private decimal GetPrice(int intDrink, DrinkSize size)
        {
            if (size == DrinkSize.Regular)
                return decimal.Parse(strProducts[intDrink, 1]);
            else
                return decimal.Parse(strProducts[intDrink, 2]);
        }
    }
}
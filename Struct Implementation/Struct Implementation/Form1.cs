namespace Struct_Implementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbType.Items.Add("Regular");
            cbType.Items.Add("Caffeinated");
            cbType.Items.Add("Special Blend");
            
        }

        // Declare struct and class-level variables
        public struct CoffeeSales
        {
            public string TypeString;
            public string QuantityString;
            public decimal PriceDecimal;
        }

        private CoffeeSales[] CoffeeTransactions = new CoffeeSales[100];
        private int numberOfTransactions = 0;
        decimal salePrice = 0;
        private decimal[,] price = 
        {   /*              Regular,  Caffeinated, Special Blend       */
        /*Quarter Pound*/   { 2.6M,   2.9M,        3.25M},
        /*Half Pound*/      { 4.9M,   5.6M,        6.1M},
        /*Full Pound*/      { 8.75M,  5.6M,        11.25M }

        };

        private string selectedQuantity;

        private void rdoQuarterPound_CheckedChanged(object sender, EventArgs e)
        {
            selectedQuantity = "Quarter Pound";
        }
        private void rdoHalfPound_CheckedChanged(object sender, EventArgs e)
        {
            selectedQuantity = "Half Pound";
        }

        private void rdoFullPound_CheckedChanged(object sender, EventArgs e)
        {
            selectedQuantity = "Full Pound";
        }

        private void btnFindPrice_Click(object sender, EventArgs e)
        {
            int row = 0;
            int column = 0;
           

            if (numberOfTransactions < 100)
            {
                // get the Coffee Type
                column = cbType.SelectedIndex;
                if(column != -1)
                {
                    switch (selectedQuantity)
                    {
                        case "Quarter Pound":
                            row = 0;
                            break;
                        case "Half Pound":
                            row = 1;
                            break;
                        case "Full Pound":
                            row = 2;
                            break;
                        // Never executed
                        default:
                            break;
                    }

                    // Display Price
                    salePrice = price[row, column];
                    txtPrice.Text = salePrice.ToString("C");
                    // Record Transaction
                    CoffeeTransactions[numberOfTransactions].QuantityString = selectedQuantity;
                    CoffeeTransactions[numberOfTransactions].PriceDecimal = salePrice;
                    CoffeeTransactions[numberOfTransactions].TypeString = cbType.Text;
                    numberOfTransactions++;

                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoQuarterPound.Select();
            cbType.SelectedIndex = -1;
            txtPrice.Text = "";
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            LoadCoffeeTransactions();
        }

        private void LoadCoffeeTransactions()
        {

            //------------------------------------------------------------------------
            //IEnumerable<CoffeeSales> filter = from sale in CoffeeTransactions
            //                                  where sale.TypeString == "Regular"
            //                                  select sale;

            //var filter = from sale in CoffeeTransactions
            //                                  where sale.TypeString == "Regular"
            //                                  select sale;

            //------------------------------------------------------------------------
            lstTransactions.Items.Clear();
            string frmt = "{0,-20}{1,-15}{2,15}";
            lstTransactions.Items.Add(string.Format(frmt, "", "R n' R Coffee Sale", ""));
            lstTransactions.Items.Add(string.Format(frmt, "", DateTime.Now, ""));
            lstTransactions.Items.Add(string.Format(""));
            lstTransactions.Items.Add(string.Format(frmt, "Quantity", "Type", "Price"));
            decimal decTotal = 0;
            foreach (CoffeeSales trans in CoffeeTransactions)
            {
                if (trans.QuantityString == null) break;
                frmt = "{0,-20}{1,-15:n0}{2,15:n2}";
                lstTransactions.Items.Add(string.Format(frmt, trans.QuantityString, trans.TypeString
                    , trans.PriceDecimal));
                decTotal += trans.PriceDecimal;
            }
            lstTransactions.Items.Add(string.Format(""));
            lstTransactions.Items.Add("-----------------------------------------------------");
            lstTransactions.Items.Add(string.Format(frmt, "Total", "", decTotal));
        }
    }
}
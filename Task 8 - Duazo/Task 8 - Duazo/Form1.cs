namespace Task_8___Duazo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Class-level variables
        // Accessories
        private const decimal DEC_STEREO_SYSTEM = 25450M;
        private const decimal DEC_LEATHER_INTERIOR = 45600M;
        private const decimal DEC_COMPUTER_NAVIGATION = 60000M;

        // Exterior Finish
        private const decimal DEC_PEARLIZED = 18000;
        private const decimal DEC_CUSTOM_DEALING = 32000M;

        private const decimal DEC_TAX_RATE = .18M;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Local Variables
            decimal decCarSalesPrice = 0m;
            decimal decAccessoriesFinish = 0m;
            decimal decSubTotal = 0m;
            decimal decTotal = 0m;
            decimal decTradeInAllowance = 0m;
            decimal decAmountDue = 0m;

            if (chkStereoSystem.Checked) decAccessoriesFinish += DEC_STEREO_SYSTEM;
            if (chkLeatherInterior.Checked) decAccessoriesFinish += DEC_LEATHER_INTERIOR;
            if (chkComputerNavigation.Checked) decAccessoriesFinish += DEC_COMPUTER_NAVIGATION;

            // Standard is free, hence no sense to check
            if (rdoPearlized.Checked) decAccessoriesFinish += DEC_PEARLIZED;
            else if (rdoCustomizedDealing.Checked) decAccessoriesFinish += DEC_CUSTOM_DEALING;

            decCarSalesPrice = ValidateInputUser(decCarSalesPrice, txtCarSalesPrice);
            decTradeInAllowance = ValidateInputUser(decTradeInAllowance, txtTradeInAllowance);

            
            if ((decCarSalesPrice != -1) &&  (decTradeInAllowance != -1))
            {
                // Calculate
                decSubTotal = decAccessoriesFinish + decCarSalesPrice;
                decTotal = (decSubTotal * DEC_TAX_RATE) + decSubTotal;
                decAmountDue = decTotal - decTradeInAllowance;

                // Display
                txtAccessoriesFinish.Text = decAccessoriesFinish.ToString("n2");
                txtSubTotal.Text = decSubTotal.ToString("n2");
                txtTotal.Text = decTotal.ToString("n2");
                txtAmountDue.Text = decAmountDue.ToString("n2");
            }

        }

        private decimal ValidateInputUser(decimal amount, TextBox text)
        {
            try
            {
                amount = Convert.ToDecimal(text.Text);
                if (amount < 0) throw new Exception("Negative number was entered.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sorsogon Auto Center Bill Claculator");
                text.Focus(); text.SelectAll(); return -1;
            }

            return amount;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkStereoSystem.Checked = false;
            chkLeatherInterior.Checked = false;
            chkComputerNavigation.Checked = false;

            rdoStandard.Checked = false;
            rdoPearlized.Checked = false;
            rdoCustomizedDealing.Checked = false;

            txtCarSalesPrice.Clear();
            txtAccessoriesFinish.Clear();
            txtSubTotal.Clear();
            txtTotal.Clear();
            txtTradeInAllowance.Text = "0.00";
            txtAmountDue.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
namespace LabSheet04___Agasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnComputeSalary.Enabled = false;
        }

        Employee employee = new Employee();

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            employee.ID = txtEmpID.Text;
            employee.Name = txtEmpName.Text;
            employee.Position = cbPosition.Text;

            if (cbPosition.Text.ToLower() == "regular")
                employee.Rate = 300M;
            else if (cbPosition.Text.ToLower() == "engineer")
                employee.Rate = 450M;
            else if (cbPosition.Text.ToLower() == "linemen")
                employee.Rate = 350M;
            else // Manager
                employee.Rate = 400M;

            double dblworkedHrs = 0.00D;

            // Catch possible errors.
            try
            {
                dblworkedHrs = double.Parse(txtWorkedHrs.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWorkedHrs.Focus();
                txtWorkedHrs.SelectAll();
                return;
            }

            // Compute the Gross Pay
            employee.ComputeGrossPay(dblworkedHrs);

            MessageBox.Show("Employee added.", "Employee Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            btnComputeSalary.Enabled = true;
        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            string strinfo = "Employee: " + employee.Name + "\n"
                + "Position: " + employee.Position + "\n"
                + "Rate: " + employee.Rate + "\n\n" +
                "Gross Pay: " + employee.GetGrossPay().ToString("n2");

            MessageBox.Show(strinfo, "Employee Details",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
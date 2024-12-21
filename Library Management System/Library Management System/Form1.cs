using System.Data;
using System.Diagnostics;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            
        }

        //----------------------------------------------------------------------------------------

        public Boolean isEmpty()
        {
            // Check if the textBox is empty before saving the data
            if (String.IsNullOrEmpty(txtBookID.Text))
            {
                MessageBox.Show("Book ID is empty. Please fill the data.", "Library Management System",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookID.Focus();
                return true;
            }

            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Book name is empty. Please fill the data.", "Library Management System",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return true;
            }

            if (String.IsNullOrEmpty(txtCategory.Text))
            {
                MessageBox.Show("Book category is empty. Please fill the data.", "Library Management System",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return true;
            }

            if (String.IsNullOrEmpty(txtPublisher.Text))
            {
                MessageBox.Show("Book category is empty. Please fill the data.", "Library Management System",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPublisher.Focus();
                return true;
            }

            return false;

        }

        //----------------------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            long id = 0L;
            string name = "";
            string code = "";
            string category = "";
            string bookType = "Borrow";
            string publisher = "";
            decimal price = 0m;

            // check the field if empty ---------------------------------------------------------
            if (isEmpty())
            {
                return;
            }

            // validation and get data
            try
            {
                id = long.Parse(txtBookID.Text);

                name = txtName.Text.Trim();
                code = txtBookCode.Text.Trim();
                category = txtCategory.Text.Trim();

                if(cbBookType.SelectedIndex == 1)
                {
                    bookType = "Read Only";
                }

                publisher = txtPublisher.Text.Trim();

                try
                {
                    price = decimal.Parse(txtPrice.Text);


                    // add record ------------
                    addRecord(id, name, code, category, bookType, publisher, price);
                }
                catch
                {
                    MessageBox.Show("Invalid data.", "Library Management System",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.SelectAll();
                    txtPrice.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid data.", "Library Management System",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookID.SelectAll();
                txtBookID.Focus();
                return;
            }
            

        }

        //----------------------------------------------------------------------------------------

        public void addRecord(long id, string name, string bookCode, string category,
            string bookType, string publisher, decimal price)
        {
            int month = DateTime.Now.Month;
            String m = month.ToString();
            if(month < 10)
            {
                m = "0" + month;
            }
            String date = DateTime.Now.Day + "/" + m + "/" + DateTime.Now.Year;

            String sql = "INSERT INTO book_manage(id, name, code, date, category, type, publisher, price)" +
                "VALUES('" + id + "', '" + name + "', '" + bookCode + "', '" + date + "', '" + category + "', " +
                "'" + bookType + "', '" + publisher + "', '" + price.ToString() + "')";

            DatabaseConnection.executeQuery(sql);

            loadData();     // Load the dataGrid

            txtBookID.Text = "";
            txtName.Text = "";
            txtBookCode.Text = "";
            txtCategory.Text = "";
            cbBookType.SelectedValue = "";
            txtPublisher.Text = "";
            txtPrice.Text = "";

            MessageBox.Show("Record has been added.", "Library Management System", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //----------------------------------------------------------------------------------------

        private void loadData()
        {
            DataTable data = DatabaseConnection.queryData("SELECT * FROM book_manage;");

            if (data != null)
                dataGridView1.DataSource = data;
        }

        //----------------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {

            long id = 0L;
            string name = "";
            string code = "";
            string category = "";
            string bookType = "Borrow";
            string publisher = "";
            decimal price = 0m;

            // check the field if empty -------------------------------
            if (isEmpty())
            {
                return;
            }

            // validation and get data
            try
            {
                id = long.Parse(txtBookID.Text);

                name = txtName.Text.Trim();
                code = txtBookCode.Text.Trim();
                category = txtCategory.Text.Trim();

                if (cbBookType.SelectedIndex == 1)
                {
                    bookType = "Read Only";
                }
                publisher = txtPublisher.Text.Trim();

                try
                {
                    price = decimal.Parse(txtPrice.Text);


                    // update record ------------------------------------------------------------------------


                    int month = DateTime.Now.Month;
                    String m = month.ToString();
                    if (month < 10)
                    {
                        m = "0" + month;
                    }
                    String date = DateTime.Now.Day + "/" + m + "/" + DateTime.Now.Year;

                    string sql = "UPDATE book_manage\r\nSET id = '"+ id + "', NAME = '" + name + "', " +
                        "\r\nDATE = '" + date + "', category = '" + category + "', " +
                        "\r\nTYPE = '" + bookType + "', publisher = '" + publisher + "', " +
                        "\r\nprice = '"+ price + "'" +
                        "\r\nWHERE id = '" + id + "';";

                    DatabaseConnection.executeQuery(sql);

                    loadData();     // Load the dataGrid

                    txtBookID.Text = "";
                    txtName.Text = "";
                    txtBookCode.Text = "";
                    txtCategory.Text = "";
                    cbBookType.SelectedValue = "";
                    txtPublisher.Text = "";
                    txtPrice.Text = "";

                    MessageBox.Show("Record has been updated.", "Library Management System",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // end update record --------------------------------------------------------------------

                }
                catch
                {
                    MessageBox.Show("Invalid data.", "Library Management System",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.SelectAll();
                    txtPrice.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid data.", "Library Management System",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookID.SelectAll();
                txtBookID.Focus();
                return;
            }

        }

        //----------------------------------------------------------------------------------------

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtBookID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtBookCode.Text = row.Cells[2].Value.ToString();
                txtCategory.Text = row.Cells[4].Value.ToString();

                if (row.Cells[5].Value.ToString().Equals("Borrow"))
                {
                    cbBookType.SelectedIndex = 0;
                }
                else cbBookType.SelectedIndex = 1;

                txtPublisher.Text = row.Cells[6].Value.ToString();
                txtPrice.Text = row.Cells[7].Value.ToString();

                txtid.Text = row.Cells[0].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;

            string sql = "DELETE FROM book_manage" +
                "\r\nWHERE id = '"+ id + "';";

            DatabaseConnection.executeQuery(sql);

            loadData();     // Load the dataGrid

            txtBookID.Text = "";
            txtName.Text = "";
            txtBookCode.Text = "";
            txtCategory.Text = "";
            cbBookType.SelectedValue = "";
            txtPublisher.Text = "";
            txtPrice.Text = "";

            MessageBox.Show("Record has been deleted.", "Library Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string sql = "";

            if (cbSearch.SelectedIndex == 0)
            {
                sql = "SELECT * FROM book_manage\r\nWHERE id = '" + txtSearch.Text + "';";
            }
            else if (cbSearch.SelectedIndex == 1)
            {
                sql = "SELECT * FROM book_manage\r\nWHERE name LIKE '%" + txtSearch.Text + "%';";
            }
            else if (cbSearch.SelectedIndex == 2)
            {
                sql = "SELECT * FROM book_manage\r\nWHERE code LIKE '%" + txtSearch.Text + "%';";
            }
            else if (cbSearch.SelectedIndex == 3)
            {
                //sql = "DELETE FROM book_manage\r\nWHERE name LIKE '%" + txtSearch.Text + "%';";
            }
            else if (cbSearch.SelectedIndex == 4)
            {
                sql = "SELECT * FROM book_manage\r\nWHERE category LIKE '%" + txtSearch.Text + "%';";
            }
            else if (cbSearch.SelectedIndex == 5)
            {
                sql = "SELECT * FROM book_manage\r\nWHERE type LIKE '%" + txtSearch.Text + "%';";
            }
            else if (cbSearch.SelectedIndex == 6)
            {
                sql = "SELECT * FROM book_manage\r\nWHERE publisher LIKE '%" + txtSearch.Text + "%';";
            }

            DataTable dt = DatabaseConnection.queryData(sql);

            dataGridView1.DataSource = dt;
            
        }
    }
}
using System;
using System.Windows.Forms;

namespace Task_13___Duazo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAnalyze.Enabled = false;
            btnClear.Enabled = false;
        }

        const int intMaxInputs = 10;
        int intCountInput = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            float floatInputHold = 0;
            char text = txtGrade.Text.ToUpper()[0]; // get only the first letter
            if (string.IsNullOrEmpty(txtGrade.Text) || float.TryParse(txtGrade.Text, out floatInputHold) 
                || text != 'F' && text != 'P')
            {
                MessageBox.Show("Invalid Input. Please enter 'P' for Pass or 'F' for Failed.");
                return;
            }

            if(intCountInput < intMaxInputs)
            {
                listBox1.Items.Add(text);
                intCountInput += 1;
                if (intCountInput == intMaxInputs)
                {
                    btnAnalyze.Enabled = true;
                    btnSubmit.Enabled = false;
                    intCountInput = 0; // reset
                }
            }

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            int intCountPassed = 0;
            int intCountFailed = 0;
            foreach (char mark in listBox1.Items)
            {
                if (mark == 'P') intCountPassed++;
                else intCountFailed++;
            }

            string res = "PASSED: " + intCountPassed + "\n" + "FAILED: " + intCountFailed;
            lblResults.Text = res;
            if (intCountPassed > 8) lblResults.Text = res + "\nStudents are ready for Prelim Exams!";
            btnAnalyze.Enabled = false;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblResults.Text = "";
            btnSubmit.Enabled = true;
            btnClear.Enabled = false;
        }
    }
}

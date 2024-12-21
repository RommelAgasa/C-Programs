
namespace Task_12___Duazo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtLaborCost = new System.Windows.Forms.TextBox();
            this.txtCostPart = new System.Windows.Forms.TextBox();
            this.btnDisplayBill = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost Part:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(163, 32);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(375, 27);
            this.txtCustomerName.TabIndex = 3;
            // 
            // txtLaborCost
            // 
            this.txtLaborCost.Location = new System.Drawing.Point(163, 74);
            this.txtLaborCost.Name = "txtLaborCost";
            this.txtLaborCost.Size = new System.Drawing.Size(197, 27);
            this.txtLaborCost.TabIndex = 4;
            this.txtLaborCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostPart
            // 
            this.txtCostPart.Location = new System.Drawing.Point(163, 114);
            this.txtCostPart.Name = "txtCostPart";
            this.txtCostPart.Size = new System.Drawing.Size(197, 27);
            this.txtCostPart.TabIndex = 5;
            this.txtCostPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDisplayBill
            // 
            this.btnDisplayBill.Location = new System.Drawing.Point(374, 89);
            this.btnDisplayBill.Name = "btnDisplayBill";
            this.btnDisplayBill.Size = new System.Drawing.Size(163, 51);
            this.btnDisplayBill.TabIndex = 6;
            this.btnDisplayBill.Text = "Display Bill";
            this.btnDisplayBill.UseVisualStyleBackColor = true;
            this.btnDisplayBill.Click += new System.EventHandler(this.btnDisplayBill_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(26, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(512, 191);
            this.listBox1.TabIndex = 7;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(26, 379);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(163, 37);
            this.btnClearForm.TabIndex = 8;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(374, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 437);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDisplayBill);
            this.Controls.Add(this.txtCostPart);
            this.Controls.Add(this.txtLaborCost);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Repair Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtLaborCost;
        private System.Windows.Forms.TextBox txtCostPart;
        private System.Windows.Forms.Button btnDisplayBill;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnExit;
    }
}


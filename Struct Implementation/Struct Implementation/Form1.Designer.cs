namespace Struct_Implementation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindPrice = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoFullPound = new System.Windows.Forms.RadioButton();
            this.rdoHalfPound = new System.Windows.Forms.RadioButton();
            this.rdoQuarterPound = new System.Windows.Forms.RadioButton();
            this.lstTransactions = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFindPrice);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(29, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffe Prices";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(384, 126);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(198, 30);
            this.txtPrice.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(457, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 44);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type:";
            // 
            // btnFindPrice
            // 
            this.btnFindPrice.Location = new System.Drawing.Point(305, 190);
            this.btnFindPrice.Name = "btnFindPrice";
            this.btnFindPrice.Size = new System.Drawing.Size(125, 44);
            this.btnFindPrice.TabIndex = 4;
            this.btnFindPrice.Text = "Find Price";
            this.btnFindPrice.UseVisualStyleBackColor = true;
            this.btnFindPrice.Click += new System.EventHandler(this.btnFindPrice_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(384, 57);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(194, 31);
            this.cbType.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoFullPound);
            this.groupBox2.Controls.Add(this.rdoHalfPound);
            this.groupBox2.Controls.Add(this.rdoQuarterPound);
            this.groupBox2.Location = new System.Drawing.Point(30, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 195);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantity";
            // 
            // rdoFullPound
            // 
            this.rdoFullPound.AutoSize = true;
            this.rdoFullPound.Location = new System.Drawing.Point(33, 138);
            this.rdoFullPound.Name = "rdoFullPound";
            this.rdoFullPound.Size = new System.Drawing.Size(111, 27);
            this.rdoFullPound.TabIndex = 2;
            this.rdoFullPound.TabStop = true;
            this.rdoFullPound.Text = "Full Pound";
            this.rdoFullPound.UseVisualStyleBackColor = true;
            this.rdoFullPound.CheckedChanged += new System.EventHandler(this.rdoFullPound_CheckedChanged);
            // 
            // rdoHalfPound
            // 
            this.rdoHalfPound.AutoSize = true;
            this.rdoHalfPound.Location = new System.Drawing.Point(33, 90);
            this.rdoHalfPound.Name = "rdoHalfPound";
            this.rdoHalfPound.Size = new System.Drawing.Size(115, 27);
            this.rdoHalfPound.TabIndex = 1;
            this.rdoHalfPound.TabStop = true;
            this.rdoHalfPound.Text = "Half Pound";
            this.rdoHalfPound.UseVisualStyleBackColor = true;
            this.rdoHalfPound.CheckedChanged += new System.EventHandler(this.rdoHalfPound_CheckedChanged);
            // 
            // rdoQuarterPound
            // 
            this.rdoQuarterPound.AutoSize = true;
            this.rdoQuarterPound.Location = new System.Drawing.Point(33, 44);
            this.rdoQuarterPound.Name = "rdoQuarterPound";
            this.rdoQuarterPound.Size = new System.Drawing.Size(144, 27);
            this.rdoQuarterPound.TabIndex = 0;
            this.rdoQuarterPound.TabStop = true;
            this.rdoQuarterPound.Text = "Quarter Pound";
            this.rdoQuarterPound.UseVisualStyleBackColor = true;
            this.rdoQuarterPound.CheckedChanged += new System.EventHandler(this.rdoQuarterPound_CheckedChanged);
            // 
            // lstTransactions
            // 
            this.lstTransactions.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstTransactions.FormattingEnabled = true;
            this.lstTransactions.ItemHeight = 20;
            this.lstTransactions.Location = new System.Drawing.Point(29, 366);
            this.lstTransactions.Name = "lstTransactions";
            this.lstTransactions.Size = new System.Drawing.Size(614, 124);
            this.lstTransactions.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Summary of Transaction:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(486, 532);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(334, 532);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(125, 44);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "Print";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 600);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstTransactions);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPrice;
        private Button btnClear;
        private Label label2;
        private Label label1;
        private Button btnFindPrice;
        private ComboBox cbType;
        private GroupBox groupBox2;
        private RadioButton rdoFullPound;
        private RadioButton rdoHalfPound;
        private RadioButton rdoQuarterPound;
        private ListBox lstTransactions;
        private Label label3;
        private Button btnExit;
        private Button btnBuy;
    }
}
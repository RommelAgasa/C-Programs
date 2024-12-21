namespace LabSheet01___Agasa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoFullPound = new System.Windows.Forms.RadioButton();
            this.rdoHalfPound = new System.Windows.Forms.RadioButton();
            this.rdoQuarterPound = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(568, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffee Prices";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(364, 115);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(184, 32);
            this.txtprice.TabIndex = 4;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(364, 67);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(184, 33);
            this.cbType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoFullPound);
            this.groupBox2.Controls.Add(this.rdoHalfPound);
            this.groupBox2.Controls.Add(this.rdoQuarterPound);
            this.groupBox2.Location = new System.Drawing.Point(22, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 164);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantity";
            // 
            // rdoFullPound
            // 
            this.rdoFullPound.AutoSize = true;
            this.rdoFullPound.Location = new System.Drawing.Point(30, 107);
            this.rdoFullPound.Name = "rdoFullPound";
            this.rdoFullPound.Size = new System.Drawing.Size(122, 29);
            this.rdoFullPound.TabIndex = 2;
            this.rdoFullPound.TabStop = true;
            this.rdoFullPound.Text = "Full Pound";
            this.rdoFullPound.UseVisualStyleBackColor = true;
            this.rdoFullPound.CheckedChanged += new System.EventHandler(this.rdoFullPound_CheckedChanged);
            // 
            // rdoHalfPound
            // 
            this.rdoHalfPound.AutoSize = true;
            this.rdoHalfPound.Location = new System.Drawing.Point(30, 73);
            this.rdoHalfPound.Name = "rdoHalfPound";
            this.rdoHalfPound.Size = new System.Drawing.Size(126, 29);
            this.rdoHalfPound.TabIndex = 1;
            this.rdoHalfPound.TabStop = true;
            this.rdoHalfPound.Text = "Half Pound";
            this.rdoHalfPound.UseVisualStyleBackColor = true;
            this.rdoHalfPound.CheckedChanged += new System.EventHandler(this.rdoHalfPound_CheckedChanged);
            // 
            // rdoQuarterPound
            // 
            this.rdoQuarterPound.AutoSize = true;
            this.rdoQuarterPound.Location = new System.Drawing.Point(30, 43);
            this.rdoQuarterPound.Name = "rdoQuarterPound";
            this.rdoQuarterPound.Size = new System.Drawing.Size(157, 29);
            this.rdoQuarterPound.TabIndex = 0;
            this.rdoQuarterPound.TabStop = true;
            this.rdoQuarterPound.Text = "Quarter Pound";
            this.rdoQuarterPound.UseVisualStyleBackColor = true;
            this.rdoQuarterPound.CheckedChanged += new System.EventHandler(this.rdoQuarterPound_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(13, 266);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(119, 45);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find Price";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(157, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 45);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(462, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 325);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R\'n R Coffee Price Finder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoFullPound;
        private System.Windows.Forms.RadioButton rdoHalfPound;
        private System.Windows.Forms.RadioButton rdoQuarterPound;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}


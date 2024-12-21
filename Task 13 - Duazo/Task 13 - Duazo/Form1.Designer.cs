
namespace Task_13___Duazo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(33, 52);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(83, 290);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter \'P\' for Passed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "or \'F\' Failed:";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(308, 52);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 30);
            this.txtGrade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Analysis:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(135, 126);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(273, 36);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit Result";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(135, 168);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(273, 36);
            this.btnAnalyze.TabIndex = 7;
            this.btnAnalyze.Text = "Analyze Results";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(135, 245);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(277, 84);
            this.lblResults.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 344);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(277, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Results";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Assessment Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
    }
}


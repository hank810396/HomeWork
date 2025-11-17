namespace WindowsFormsApp1
{
    partial class Report
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
            this.MonthPaytext = new System.Windows.Forms.TextBox();
            this.Ratetext2 = new System.Windows.Forms.TextBox();
            this.Yeartext2 = new System.Windows.Forms.TextBox();
            this.Moneytext2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalPaytext = new System.Windows.Forms.TextBox();
            this.Emailbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonthPaytext
            // 
            this.MonthPaytext.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MonthPaytext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthPaytext.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MonthPaytext.Location = new System.Drawing.Point(221, 212);
            this.MonthPaytext.Name = "MonthPaytext";
            this.MonthPaytext.Size = new System.Drawing.Size(267, 34);
            this.MonthPaytext.TabIndex = 15;
            // 
            // Ratetext2
            // 
            this.Ratetext2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Ratetext2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Ratetext2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Ratetext2.Location = new System.Drawing.Point(221, 159);
            this.Ratetext2.Name = "Ratetext2";
            this.Ratetext2.Size = new System.Drawing.Size(267, 34);
            this.Ratetext2.TabIndex = 14;
            this.Ratetext2.Text = "10";
            // 
            // Yeartext2
            // 
            this.Yeartext2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Yeartext2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Yeartext2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Yeartext2.Location = new System.Drawing.Point(221, 106);
            this.Yeartext2.Name = "Yeartext2";
            this.Yeartext2.Size = new System.Drawing.Size(267, 34);
            this.Yeartext2.TabIndex = 13;
            this.Yeartext2.Text = "2";
            // 
            // Moneytext2
            // 
            this.Moneytext2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Moneytext2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Moneytext2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Moneytext2.Location = new System.Drawing.Point(221, 53);
            this.Moneytext2.Name = "Moneytext2";
            this.Moneytext2.Size = new System.Drawing.Size(267, 34);
            this.Moneytext2.TabIndex = 12;
            this.Moneytext2.Text = "100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(71, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "月付款";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(71, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "利率(%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(71, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "期限(年)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "貸款金額";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(71, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 36);
            this.label5.TabIndex = 16;
            this.label5.Text = "總付款";
            // 
            // TotalPaytext
            // 
            this.TotalPaytext.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TotalPaytext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalPaytext.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TotalPaytext.Location = new System.Drawing.Point(221, 265);
            this.TotalPaytext.Name = "TotalPaytext";
            this.TotalPaytext.Size = new System.Drawing.Size(267, 34);
            this.TotalPaytext.TabIndex = 17;
            // 
            // Emailbutton
            // 
            this.Emailbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Emailbutton.Location = new System.Drawing.Point(357, 323);
            this.Emailbutton.Name = "Emailbutton";
            this.Emailbutton.Size = new System.Drawing.Size(131, 65);
            this.Emailbutton.TabIndex = 18;
            this.Emailbutton.Text = "Email";
            this.Emailbutton.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 412);
            this.Controls.Add(this.Emailbutton);
            this.Controls.Add(this.TotalPaytext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MonthPaytext);
            this.Controls.Add(this.Ratetext2);
            this.Controls.Add(this.Yeartext2);
            this.Controls.Add(this.Moneytext2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MonthPaytext;
        private System.Windows.Forms.TextBox Ratetext2;
        private System.Windows.Forms.TextBox Yeartext2;
        private System.Windows.Forms.TextBox Moneytext2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalPaytext;
        private System.Windows.Forms.Button Emailbutton;
    }
}
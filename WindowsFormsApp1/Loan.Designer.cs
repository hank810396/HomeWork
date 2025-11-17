namespace LoanAmountForm
{
    partial class Loan
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
            this.label4 = new System.Windows.Forms.Label();
            this.Moneytext = new System.Windows.Forms.TextBox();
            this.Yeartext = new System.Windows.Forms.TextBox();
            this.Ratetext = new System.Windows.Forms.TextBox();
            this.DownPaytext = new System.Windows.Forms.TextBox();
            this.PMTbutton = new System.Windows.Forms.Button();
            this.Totalbutton = new System.Windows.Forms.Button();
            this.Reportbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(62, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(62, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(62, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(62, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "頭期款";
            // 
            // Moneytext
            // 
            this.Moneytext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Moneytext.Location = new System.Drawing.Point(212, 57);
            this.Moneytext.Name = "Moneytext";
            this.Moneytext.Size = new System.Drawing.Size(267, 34);
            this.Moneytext.TabIndex = 4;
            this.Moneytext.Text = "100000";
            // 
            // Yeartext
            // 
            this.Yeartext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Yeartext.Location = new System.Drawing.Point(212, 111);
            this.Yeartext.Name = "Yeartext";
            this.Yeartext.Size = new System.Drawing.Size(267, 34);
            this.Yeartext.TabIndex = 5;
            this.Yeartext.Text = "2";
            // 
            // Ratetext
            // 
            this.Ratetext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Ratetext.Location = new System.Drawing.Point(212, 165);
            this.Ratetext.Name = "Ratetext";
            this.Ratetext.Size = new System.Drawing.Size(267, 34);
            this.Ratetext.TabIndex = 6;
            this.Ratetext.Text = "10";
            // 
            // DownPaytext
            // 
            this.DownPaytext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DownPaytext.Location = new System.Drawing.Point(212, 219);
            this.DownPaytext.Name = "DownPaytext";
            this.DownPaytext.Size = new System.Drawing.Size(267, 34);
            this.DownPaytext.TabIndex = 7;
            this.DownPaytext.Text = "0";
            // 
            // PMTbutton
            // 
            this.PMTbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PMTbutton.Location = new System.Drawing.Point(68, 285);
            this.PMTbutton.Name = "PMTbutton";
            this.PMTbutton.Size = new System.Drawing.Size(131, 65);
            this.PMTbutton.TabIndex = 8;
            this.PMTbutton.Text = "PMT月付";
            this.PMTbutton.UseVisualStyleBackColor = true;
            this.PMTbutton.Click += new System.EventHandler(this.PMTbutton_Click);
            // 
            // Totalbutton
            // 
            this.Totalbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Totalbutton.Location = new System.Drawing.Point(208, 285);
            this.Totalbutton.Name = "Totalbutton";
            this.Totalbutton.Size = new System.Drawing.Size(131, 65);
            this.Totalbutton.TabIndex = 9;
            this.Totalbutton.Text = "總付款";
            this.Totalbutton.UseVisualStyleBackColor = true;
            this.Totalbutton.Click += new System.EventHandler(this.Totalbutton_Click);
            // 
            // Reportbutton
            // 
            this.Reportbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Reportbutton.Location = new System.Drawing.Point(348, 285);
            this.Reportbutton.Name = "Reportbutton";
            this.Reportbutton.Size = new System.Drawing.Size(131, 65);
            this.Reportbutton.TabIndex = 10;
            this.Reportbutton.Text = "Report";
            this.Reportbutton.UseVisualStyleBackColor = true;
            this.Reportbutton.Click += new System.EventHandler(this.Reportbutton_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 397);
            this.Controls.Add(this.Reportbutton);
            this.Controls.Add(this.Totalbutton);
            this.Controls.Add(this.PMTbutton);
            this.Controls.Add(this.DownPaytext);
            this.Controls.Add(this.Ratetext);
            this.Controls.Add(this.Yeartext);
            this.Controls.Add(this.Moneytext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Moneytext;
        private System.Windows.Forms.TextBox Yeartext;
        private System.Windows.Forms.TextBox Ratetext;
        private System.Windows.Forms.TextBox DownPaytext;
        private System.Windows.Forms.Button PMTbutton;
        private System.Windows.Forms.Button Totalbutton;
        private System.Windows.Forms.Button Reportbutton;
    }
}
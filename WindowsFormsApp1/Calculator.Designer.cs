namespace WindowsFormsApp1
{
    partial class Calculator
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
            this.Dividedbutton = new System.Windows.Forms.Button();
            this.Timesbutton = new System.Windows.Forms.Button();
            this.Minusbutton = new System.Windows.Forms.Button();
            this.Plusbutton = new System.Windows.Forms.Button();
            this.Anstext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Num2text = new System.Windows.Forms.TextBox();
            this.Num1text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dividedbutton
            // 
            this.Dividedbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Dividedbutton.Location = new System.Drawing.Point(377, 186);
            this.Dividedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Dividedbutton.Name = "Dividedbutton";
            this.Dividedbutton.Size = new System.Drawing.Size(72, 41);
            this.Dividedbutton.TabIndex = 21;
            this.Dividedbutton.Text = "÷";
            this.Dividedbutton.UseVisualStyleBackColor = true;
            this.Dividedbutton.Click += new System.EventHandler(this.Dividedbutton_Click);
            // 
            // Timesbutton
            // 
            this.Timesbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Timesbutton.Location = new System.Drawing.Point(377, 139);
            this.Timesbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Timesbutton.Name = "Timesbutton";
            this.Timesbutton.Size = new System.Drawing.Size(72, 41);
            this.Timesbutton.TabIndex = 20;
            this.Timesbutton.Text = "×";
            this.Timesbutton.UseVisualStyleBackColor = true;
            this.Timesbutton.Click += new System.EventHandler(this.Timesbutton_Click);
            // 
            // Minusbutton
            // 
            this.Minusbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Minusbutton.Location = new System.Drawing.Point(377, 93);
            this.Minusbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Minusbutton.Name = "Minusbutton";
            this.Minusbutton.Size = new System.Drawing.Size(72, 41);
            this.Minusbutton.TabIndex = 19;
            this.Minusbutton.Text = "-";
            this.Minusbutton.UseVisualStyleBackColor = true;
            this.Minusbutton.Click += new System.EventHandler(this.Minusbutton_Click);
            // 
            // Plusbutton
            // 
            this.Plusbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Plusbutton.Location = new System.Drawing.Point(377, 47);
            this.Plusbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Plusbutton.Name = "Plusbutton";
            this.Plusbutton.Size = new System.Drawing.Size(72, 41);
            this.Plusbutton.TabIndex = 18;
            this.Plusbutton.Text = "+";
            this.Plusbutton.UseVisualStyleBackColor = true;
            this.Plusbutton.Click += new System.EventHandler(this.Plusbutton_Click);
            // 
            // Anstext
            // 
            this.Anstext.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Anstext.Location = new System.Drawing.Point(172, 184);
            this.Anstext.Margin = new System.Windows.Forms.Padding(4);
            this.Anstext.Name = "Anstext";
            this.Anstext.ReadOnly = true;
            this.Anstext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Anstext.Size = new System.Drawing.Size(167, 39);
            this.Anstext.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(41, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "Answer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(57, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "-------------------------";
            // 
            // Num2text
            // 
            this.Num2text.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Num2text.Location = new System.Drawing.Point(172, 103);
            this.Num2text.Margin = new System.Windows.Forms.Padding(4);
            this.Num2text.Name = "Num2text";
            this.Num2text.Size = new System.Drawing.Size(167, 39);
            this.Num2text.TabIndex = 14;
            // 
            // Num1text
            // 
            this.Num1text.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Num1text.Location = new System.Drawing.Point(172, 47);
            this.Num1text.Margin = new System.Windows.Forms.Padding(4);
            this.Num1text.Name = "Num1text";
            this.Num1text.Size = new System.Drawing.Size(167, 39);
            this.Num1text.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(57, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "Num2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Num1:";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 284);
            this.Controls.Add(this.Dividedbutton);
            this.Controls.Add(this.Timesbutton);
            this.Controls.Add(this.Minusbutton);
            this.Controls.Add(this.Plusbutton);
            this.Controls.Add(this.Anstext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Num2text);
            this.Controls.Add(this.Num1text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "MyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dividedbutton;
        private System.Windows.Forms.Button Timesbutton;
        private System.Windows.Forms.Button Minusbutton;
        private System.Windows.Forms.Button Plusbutton;
        private System.Windows.Forms.TextBox Anstext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Num2text;
        private System.Windows.Forms.TextBox Num1text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
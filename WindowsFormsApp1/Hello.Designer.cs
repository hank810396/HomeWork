namespace WindowsFormsApp1
{
    partial class Helloform
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
            this.Nametext = new System.Windows.Forms.TextBox();
            this.Engtext = new System.Windows.Forms.TextBox();
            this.Gendertext = new System.Windows.Forms.TextBox();
            this.Startext = new System.Windows.Forms.TextBox();
            this.Hellobutton = new System.Windows.Forms.Button();
            this.Hibutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(58, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "英文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(58, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "性別";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(58, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "星座";
            // 
            // Nametext
            // 
            this.Nametext.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Nametext.Location = new System.Drawing.Point(156, 49);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(223, 38);
            this.Nametext.TabIndex = 4;
            // 
            // Engtext
            // 
            this.Engtext.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Engtext.Location = new System.Drawing.Point(156, 104);
            this.Engtext.Name = "Engtext";
            this.Engtext.Size = new System.Drawing.Size(223, 38);
            this.Engtext.TabIndex = 5;
            // 
            // Gendertext
            // 
            this.Gendertext.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gendertext.Location = new System.Drawing.Point(156, 159);
            this.Gendertext.Name = "Gendertext";
            this.Gendertext.Size = new System.Drawing.Size(223, 38);
            this.Gendertext.TabIndex = 6;
            // 
            // Startext
            // 
            this.Startext.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Startext.Location = new System.Drawing.Point(156, 214);
            this.Startext.Name = "Startext";
            this.Startext.Size = new System.Drawing.Size(223, 38);
            this.Startext.TabIndex = 7;
            // 
            // Hellobutton
            // 
            this.Hellobutton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Hellobutton.Location = new System.Drawing.Point(54, 279);
            this.Hellobutton.Name = "Hellobutton";
            this.Hellobutton.Size = new System.Drawing.Size(152, 54);
            this.Hellobutton.TabIndex = 8;
            this.Hellobutton.Text = "Say Hello";
            this.Hellobutton.UseVisualStyleBackColor = true;
            this.Hellobutton.Click += new System.EventHandler(this.Hellobutton_Click);
            // 
            // Hibutton
            // 
            this.Hibutton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Hibutton.Location = new System.Drawing.Point(227, 279);
            this.Hibutton.Name = "Hibutton";
            this.Hibutton.Size = new System.Drawing.Size(152, 54);
            this.Hibutton.TabIndex = 9;
            this.Hibutton.Text = "Say Hi";
            this.Hibutton.UseVisualStyleBackColor = true;
            this.Hibutton.Click += new System.EventHandler(this.Hibutton_Click);
            // 
            // Helloform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 373);
            this.Controls.Add(this.Hibutton);
            this.Controls.Add(this.Hellobutton);
            this.Controls.Add(this.Startext);
            this.Controls.Add(this.Gendertext);
            this.Controls.Add(this.Engtext);
            this.Controls.Add(this.Nametext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Helloform";
            this.Text = "Hello C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nametext;
        private System.Windows.Forms.TextBox Engtext;
        private System.Windows.Forms.TextBox Gendertext;
        private System.Windows.Forms.TextBox Startext;
        private System.Windows.Forms.Button Hellobutton;
        private System.Windows.Forms.Button Hibutton;
    }
}
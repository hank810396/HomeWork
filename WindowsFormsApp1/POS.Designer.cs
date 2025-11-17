namespace WindowsFormsApp1
{
    partial class POSform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSform));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Winebutton = new System.Windows.Forms.Button();
            this.Whiskybutton = new System.Windows.Forms.Button();
            this.Tequilabutton = new System.Windows.Forms.Button();
            this.Beerbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Cleanbutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Totaltext = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Creditbutton = new System.Windows.Forms.Button();
            this.Cashbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Winebutton);
            this.groupBox1.Controls.Add(this.Whiskybutton);
            this.groupBox1.Controls.Add(this.Tequilabutton);
            this.groupBox1.Controls.Add(this.Beerbutton);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 470);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單 Meum";
            // 
            // Winebutton
            // 
            this.Winebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Winebutton.BackgroundImage")));
            this.Winebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Winebutton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Winebutton.Location = new System.Drawing.Point(135, 201);
            this.Winebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Winebutton.Name = "Winebutton";
            this.Winebutton.Size = new System.Drawing.Size(124, 150);
            this.Winebutton.TabIndex = 3;
            this.Winebutton.Text = "紅酒Wine NT320";
            this.Winebutton.UseVisualStyleBackColor = true;
            this.Winebutton.Click += new System.EventHandler(this.Winebutton_Click);
            // 
            // Whiskybutton
            // 
            this.Whiskybutton.BackColor = System.Drawing.SystemColors.Control;
            this.Whiskybutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Whiskybutton.BackgroundImage")));
            this.Whiskybutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Whiskybutton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Whiskybutton.Location = new System.Drawing.Point(8, 201);
            this.Whiskybutton.Margin = new System.Windows.Forms.Padding(4);
            this.Whiskybutton.Name = "Whiskybutton";
            this.Whiskybutton.Size = new System.Drawing.Size(124, 150);
            this.Whiskybutton.TabIndex = 2;
            this.Whiskybutton.Text = "威士忌Whisky NT350";
            this.Whiskybutton.UseVisualStyleBackColor = false;
            this.Whiskybutton.Click += new System.EventHandler(this.Whiskybutton_Click);
            // 
            // Tequilabutton
            // 
            this.Tequilabutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tequilabutton.BackgroundImage")));
            this.Tequilabutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tequilabutton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tequilabutton.Location = new System.Drawing.Point(135, 44);
            this.Tequilabutton.Margin = new System.Windows.Forms.Padding(4);
            this.Tequilabutton.Name = "Tequilabutton";
            this.Tequilabutton.Size = new System.Drawing.Size(124, 150);
            this.Tequilabutton.TabIndex = 1;
            this.Tequilabutton.Text = "龍舌蘭Tequila NT180";
            this.Tequilabutton.UseVisualStyleBackColor = true;
            this.Tequilabutton.Click += new System.EventHandler(this.Tequilabutton_Click);
            // 
            // Beerbutton
            // 
            this.Beerbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Beerbutton.BackgroundImage")));
            this.Beerbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Beerbutton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Beerbutton.Location = new System.Drawing.Point(8, 44);
            this.Beerbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Beerbutton.Name = "Beerbutton";
            this.Beerbutton.Size = new System.Drawing.Size(124, 150);
            this.Beerbutton.TabIndex = 0;
            this.Beerbutton.Text = "啤酒Beer NT120";
            this.Beerbutton.UseVisualStyleBackColor = true;
            this.Beerbutton.Click += new System.EventHandler(this.Beerbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.Cleanbutton);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(538, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 470);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "購物清單 List";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(8, 44);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 340);
            this.listBox1.TabIndex = 1;
            // 
            // Cleanbutton
            // 
            this.Cleanbutton.Location = new System.Drawing.Point(107, 418);
            this.Cleanbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Cleanbutton.Name = "Cleanbutton";
            this.Cleanbutton.Size = new System.Drawing.Size(152, 45);
            this.Cleanbutton.TabIndex = 2;
            this.Cleanbutton.Text = "清除清單";
            this.Cleanbutton.UseVisualStyleBackColor = true;
            this.Cleanbutton.Click += new System.EventHandler(this.Cleanbutton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Totaltext);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(288, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(243, 235);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "總金額 Total Price";
            // 
            // Totaltext
            // 
            this.Totaltext.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Totaltext.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Totaltext.ForeColor = System.Drawing.SystemColors.Menu;
            this.Totaltext.Location = new System.Drawing.Point(8, 44);
            this.Totaltext.Margin = new System.Windows.Forms.Padding(4);
            this.Totaltext.Name = "Totaltext";
            this.Totaltext.ReadOnly = true;
            this.Totaltext.Size = new System.Drawing.Size(225, 39);
            this.Totaltext.TabIndex = 0;
            this.Totaltext.Text = "NT$0";
            this.Totaltext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Creditbutton);
            this.groupBox4.Controls.Add(this.Cashbutton);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(288, 248);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(243, 235);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "付款方式 Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(57, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "信用卡享9折!";
            // 
            // Creditbutton
            // 
            this.Creditbutton.Location = new System.Drawing.Point(39, 136);
            this.Creditbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Creditbutton.Name = "Creditbutton";
            this.Creditbutton.Size = new System.Drawing.Size(152, 45);
            this.Creditbutton.TabIndex = 1;
            this.Creditbutton.Text = "信用卡";
            this.Creditbutton.UseVisualStyleBackColor = true;
            this.Creditbutton.Click += new System.EventHandler(this.Creditbutton_Click);
            // 
            // Cashbutton
            // 
            this.Cashbutton.Location = new System.Drawing.Point(39, 64);
            this.Cashbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Cashbutton.Name = "Cashbutton";
            this.Cashbutton.Size = new System.Drawing.Size(152, 45);
            this.Cashbutton.TabIndex = 0;
            this.Cashbutton.Text = "現金";
            this.Cashbutton.UseVisualStyleBackColor = true;
            this.Cashbutton.Click += new System.EventHandler(this.Cashbutton_Click);
            // 
            // POSform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "POSform";
            this.Text = "Bar POS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Winebutton;
        private System.Windows.Forms.Button Whiskybutton;
        private System.Windows.Forms.Button Tequilabutton;
        private System.Windows.Forms.Button Beerbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Cleanbutton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Totaltext;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Creditbutton;
        private System.Windows.Forms.Button Cashbutton;
    }
}
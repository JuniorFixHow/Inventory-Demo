namespace InventoryDemo
{
    partial class Form8
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
            this.button1 = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sProd = new System.Windows.Forms.TextBox();
            this.sId = new System.Windows.Forms.TextBox();
            this.sCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sQuant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sPrice = new System.Windows.Forms.TextBox();
            this.catText = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.markIcon = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(24)))), ((int)(((byte)(149)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(214, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLbl.AutoSize = true;
            this.errorLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.errorLbl.Location = new System.Drawing.Point(60, 301);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(45, 21);
            this.errorLbl.TabIndex = 26;
            this.errorLbl.Text = "Error";
            this.errorLbl.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(24)))), ((int)(((byte)(144)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(368, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 41);
            this.button3.TabIndex = 25;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(141)))), ((int)(((byte)(149)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(60, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 24;
            this.button2.Text = "Post";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(46, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Stock ID";
            // 
            // sProd
            // 
            this.sProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sProd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sProd.ForeColor = System.Drawing.Color.Gray;
            this.sProd.Location = new System.Drawing.Point(52, 153);
            this.sProd.Multiline = true;
            this.sProd.Name = "sProd";
            this.sProd.PasswordChar = '*';
            this.sProd.Size = new System.Drawing.Size(237, 31);
            this.sProd.TabIndex = 20;
            this.sProd.UseSystemPasswordChar = true;
            // 
            // sId
            // 
            this.sId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sId.ForeColor = System.Drawing.Color.Gray;
            this.sId.Location = new System.Drawing.Point(51, 80);
            this.sId.Multiline = true;
            this.sId.Name = "sId";
            this.sId.PasswordChar = '*';
            this.sId.Size = new System.Drawing.Size(129, 31);
            this.sId.TabIndex = 21;
            this.sId.UseSystemPasswordChar = true;
            // 
            // sCat
            // 
            this.sCat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sCat.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sCat.ForeColor = System.Drawing.Color.DarkGray;
            this.sCat.FormattingEnabled = true;
            this.sCat.Location = new System.Drawing.Point(322, 230);
            this.sCat.Name = "sCat";
            this.sCat.Size = new System.Drawing.Size(243, 31);
            this.sCat.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label3.Location = new System.Drawing.Point(316, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Add To Category";
            // 
            // sQuant
            // 
            this.sQuant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sQuant.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sQuant.ForeColor = System.Drawing.Color.Gray;
            this.sQuant.Location = new System.Drawing.Point(322, 153);
            this.sQuant.Multiline = true;
            this.sQuant.Name = "sQuant";
            this.sQuant.PasswordChar = '*';
            this.sQuant.Size = new System.Drawing.Size(129, 31);
            this.sQuant.TabIndex = 21;
            this.sQuant.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label4.Location = new System.Drawing.Point(316, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label7.Location = new System.Drawing.Point(49, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 30);
            this.label7.TabIndex = 32;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label6.Location = new System.Drawing.Point(72, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Set Price";
            // 
            // sPrice
            // 
            this.sPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sPrice.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sPrice.ForeColor = System.Drawing.Color.Gray;
            this.sPrice.Location = new System.Drawing.Point(78, 227);
            this.sPrice.Multiline = true;
            this.sPrice.Name = "sPrice";
            this.sPrice.PasswordChar = '*';
            this.sPrice.Size = new System.Drawing.Size(129, 31);
            this.sPrice.TabIndex = 30;
            this.sPrice.UseSystemPasswordChar = true;
            // 
            // catText
            // 
            this.catText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.catText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catText.ForeColor = System.Drawing.Color.Gray;
            this.catText.Location = new System.Drawing.Point(610, 80);
            this.catText.Multiline = true;
            this.catText.Name = "catText";
            this.catText.PasswordChar = '*';
            this.catText.Size = new System.Drawing.Size(237, 31);
            this.catText.TabIndex = 20;
            this.catText.UseSystemPasswordChar = true;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLbl.AutoSize = true;
            this.titleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.titleLbl.Location = new System.Drawing.Point(604, 52);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(175, 25);
            this.titleLbl.TabIndex = 22;
            this.titleLbl.Text = "Add New Category";
            // 
            // markIcon
            // 
            this.markIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.markIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.markIcon.FlatAppearance.BorderSize = 0;
            this.markIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markIcon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.markIcon.ForeColor = System.Drawing.Color.White;
            this.markIcon.Image = global::InventoryDemo.Properties.Resources.icons8_check_mark_30__1_;
            this.markIcon.Location = new System.Drawing.Point(539, 80);
            this.markIcon.Name = "markIcon";
            this.markIcon.Size = new System.Drawing.Size(65, 31);
            this.markIcon.TabIndex = 24;
            this.markIcon.UseVisualStyleBackColor = false;
            this.markIcon.Visible = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(141)))), ((int)(((byte)(149)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(610, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 35);
            this.button5.TabIndex = 27;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(24)))), ((int)(((byte)(144)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(710, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 35);
            this.button6.TabIndex = 27;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(905, 604);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sPrice);
            this.Controls.Add(this.sCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.markIcon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catText);
            this.Controls.Add(this.sProd);
            this.Controls.Add(this.sQuant);
            this.Controls.Add(this.sId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label errorLbl;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label label1;
        private TextBox sProd;
        private TextBox sId;
        private ComboBox sCat;
        private Label label3;
        private TextBox sQuant;
        private Label label4;
        private Label label7;
        private Label label6;
        private TextBox sPrice;
        private TextBox catText;
        private Label titleLbl;
        private Button markIcon;
        private Button button5;
        private Button button6;
    }
}
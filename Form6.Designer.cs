namespace InventoryDemo
{
    partial class Form6
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
            this.errorLbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.urole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.upass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLbl.AutoSize = true;
            this.errorLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.errorLbl.Location = new System.Drawing.Point(71, 326);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(45, 21);
            this.errorLbl.TabIndex = 18;
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
            this.button3.Location = new System.Drawing.Point(379, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 41);
            this.button3.TabIndex = 17;
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
            this.button2.Location = new System.Drawing.Point(71, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "Post";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // urole
            // 
            this.urole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.urole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urole.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urole.ForeColor = System.Drawing.Color.Black;
            this.urole.FormattingEnabled = true;
            this.urole.Items.AddRange(new object[] {
            "Manager",
            "Attendant"});
            this.urole.Location = new System.Drawing.Point(65, 265);
            this.urole.Name = "urole";
            this.urole.Size = new System.Drawing.Size(170, 31);
            this.urole.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label3.Location = new System.Drawing.Point(59, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Role";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(58, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "User ID";
            // 
            // uid
            // 
            this.uid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uid.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uid.ForeColor = System.Drawing.Color.Black;
            this.uid.Location = new System.Drawing.Point(64, 42);
            this.uid.Multiline = true;
            this.uid.Name = "uid";
            this.uid.PasswordChar = '*';
            this.uid.Size = new System.Drawing.Size(129, 31);
            this.uid.TabIndex = 12;
            this.uid.UseSystemPasswordChar = true;
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
            this.button1.Location = new System.Drawing.Point(225, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uname
            // 
            this.uname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uname.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uname.ForeColor = System.Drawing.Color.Black;
            this.uname.Location = new System.Drawing.Point(65, 115);
            this.uname.Multiline = true;
            this.uname.Name = "uname";
            this.uname.PasswordChar = '*';
            this.uname.Size = new System.Drawing.Size(237, 31);
            this.uname.TabIndex = 12;
            this.uname.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(59, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // uemail
            // 
            this.uemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uemail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uemail.ForeColor = System.Drawing.Color.Black;
            this.uemail.Location = new System.Drawing.Point(364, 115);
            this.uemail.Multiline = true;
            this.uemail.Name = "uemail";
            this.uemail.PasswordChar = '*';
            this.uemail.Size = new System.Drawing.Size(237, 31);
            this.uemail.TabIndex = 12;
            this.uemail.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label4.Location = new System.Drawing.Point(358, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // uphone
            // 
            this.uphone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uphone.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uphone.ForeColor = System.Drawing.Color.Black;
            this.uphone.Location = new System.Drawing.Point(65, 190);
            this.uphone.Multiline = true;
            this.uphone.Name = "uphone";
            this.uphone.PasswordChar = '*';
            this.uphone.Size = new System.Drawing.Size(237, 31);
            this.uphone.TabIndex = 12;
            this.uphone.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label5.Location = new System.Drawing.Point(59, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // upass
            // 
            this.upass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.upass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upass.ForeColor = System.Drawing.Color.Black;
            this.upass.Location = new System.Drawing.Point(364, 190);
            this.upass.Multiline = true;
            this.upass.Name = "upass";
            this.upass.PasswordChar = '*';
            this.upass.Size = new System.Drawing.Size(237, 31);
            this.upass.TabIndex = 12;
            this.upass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label6.Location = new System.Drawing.Point(358, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.upass);
            this.panel1.Controls.Add(this.errorLbl);
            this.panel1.Controls.Add(this.uid);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.uname);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.uphone);
            this.panel1.Controls.Add(this.urole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.uemail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(123, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 449);
            this.panel1.TabIndex = 20;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(905, 604);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label errorLbl;
        private Button button3;
        private Button button2;
        private ComboBox urole;
        private Label label3;
        private Label label1;
        private TextBox uid;
        private Button button1;
        private TextBox uname;
        private Label label2;
        private TextBox uemail;
        private Label label4;
        private TextBox uphone;
        private Label label5;
        private TextBox upass;
        private Label label6;
        private Panel panel1;
    }
}
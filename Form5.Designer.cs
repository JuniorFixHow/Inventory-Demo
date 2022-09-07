namespace InventoryDemo
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.tQuant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tProd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tCust = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tCat = new System.Windows.Forms.ComboBox();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.quantLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.prodLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.custLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.codeLbl = new System.Windows.Forms.Label();
            this.codeCmb = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trans ID";
            // 
            // tID
            // 
            this.tID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tID.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tID.ForeColor = System.Drawing.Color.Black;
            this.tID.Location = new System.Drawing.Point(40, 107);
            this.tID.Multiline = true;
            this.tID.Name = "tID";
            this.tID.PasswordChar = '*';
            this.tID.Size = new System.Drawing.Size(111, 31);
            this.tID.TabIndex = 2;
            this.tID.UseSystemPasswordChar = true;
            // 
            // tQuant
            // 
            this.tQuant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tQuant.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tQuant.ForeColor = System.Drawing.Color.Black;
            this.tQuant.Location = new System.Drawing.Point(317, 253);
            this.tQuant.Multiline = true;
            this.tQuant.Name = "tQuant";
            this.tQuant.PasswordChar = '*';
            this.tQuant.Size = new System.Drawing.Size(129, 31);
            this.tQuant.TabIndex = 2;
            this.tQuant.UseSystemPasswordChar = true;
            this.tQuant.TextChanged += new System.EventHandler(this.tQuant_TextChanged);
            this.tQuant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tQuant_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(311, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            // 
            // tProd
            // 
            this.tProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tProd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tProd.ForeColor = System.Drawing.Color.Black;
            this.tProd.FormattingEnabled = true;
            this.tProd.Items.AddRange(new object[] {
            "Prod 1",
            "Prod 2"});
            this.tProd.Location = new System.Drawing.Point(40, 253);
            this.tProd.Name = "tProd";
            this.tProd.Size = new System.Drawing.Size(225, 31);
            this.tProd.TabIndex = 4;
            this.tProd.SelectedIndexChanged += new System.EventHandler(this.tProd_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label3.Location = new System.Drawing.Point(34, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product";
            // 
            // tCust
            // 
            this.tCust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tCust.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tCust.ForeColor = System.Drawing.Color.Black;
            this.tCust.Location = new System.Drawing.Point(317, 182);
            this.tCust.Multiline = true;
            this.tCust.Name = "tCust";
            this.tCust.PasswordChar = '*';
            this.tCust.Size = new System.Drawing.Size(247, 31);
            this.tCust.TabIndex = 2;
            this.tCust.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label4.Location = new System.Drawing.Point(311, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label5.Location = new System.Drawing.Point(34, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Select Category";
            // 
            // tCat
            // 
            this.tCat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tCat.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tCat.ForeColor = System.Drawing.Color.Black;
            this.tCat.FormattingEnabled = true;
            this.tCat.Items.AddRange(new object[] {
            "Cat 1",
            "Cat 2"});
            this.tCat.Location = new System.Drawing.Point(40, 182);
            this.tCat.Name = "tCat";
            this.tCat.Size = new System.Drawing.Size(225, 31);
            this.tCat.TabIndex = 4;
            this.tCat.SelectedIndexChanged += new System.EventHandler(this.tCat_SelectedIndexChanged);
            // 
            // tPrice
            // 
            this.tPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPrice.Enabled = false;
            this.tPrice.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tPrice.ForeColor = System.Drawing.Color.Black;
            this.tPrice.Location = new System.Drawing.Point(348, 331);
            this.tPrice.Multiline = true;
            this.tPrice.Name = "tPrice";
            this.tPrice.PasswordChar = '*';
            this.tPrice.Size = new System.Drawing.Size(129, 31);
            this.tPrice.TabIndex = 2;
            this.tPrice.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label6.Location = new System.Drawing.Point(342, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label7.Location = new System.Drawing.Point(319, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "$";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.priceLbl);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.quantLbl);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.prodLbl);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.custLbl);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dateLbl);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(628, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 234);
            this.panel1.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(101, 198);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 17);
            this.label21.TabIndex = 4;
            this.label21.Text = "JuniorFixHow";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(3, 198);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "Attentant:";
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.Location = new System.Drawing.Point(101, 163);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(0, 17);
            this.priceLbl.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(3, 163);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Price:";
            // 
            // quantLbl
            // 
            this.quantLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quantLbl.AutoSize = true;
            this.quantLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantLbl.Location = new System.Drawing.Point(101, 136);
            this.quantLbl.Name = "quantLbl";
            this.quantLbl.Size = new System.Drawing.Size(0, 17);
            this.quantLbl.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(3, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Quantity:";
            // 
            // prodLbl
            // 
            this.prodLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prodLbl.AutoSize = true;
            this.prodLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodLbl.Location = new System.Drawing.Point(101, 109);
            this.prodLbl.Name = "prodLbl";
            this.prodLbl.Size = new System.Drawing.Size(0, 17);
            this.prodLbl.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Product:";
            // 
            // custLbl
            // 
            this.custLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.custLbl.AutoSize = true;
            this.custLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custLbl.Location = new System.Drawing.Point(101, 82);
            this.custLbl.Name = "custLbl";
            this.custLbl.Size = new System.Drawing.Size(0, 17);
            this.custLbl.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Customer:";
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLbl.Location = new System.Drawing.Point(101, 58);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(0, 17);
            this.dateLbl.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Date:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label9.Location = new System.Drawing.Point(57, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "JuniorFixHow";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label8.Location = new System.Drawing.Point(801, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Receipt";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(714, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
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
            this.button2.Location = new System.Drawing.Point(41, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Post";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button3.Location = new System.Drawing.Point(241, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::InventoryDemo.Properties.Resources._Barcode_32896;
            this.pictureBox1.Location = new System.Drawing.Point(40, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::InventoryDemo.Properties.Resources.icons8_add_25;
            this.button4.Location = new System.Drawing.Point(156, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 23);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLbl.AutoSize = true;
            this.errorLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.errorLbl.Location = new System.Drawing.Point(41, 419);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(45, 21);
            this.errorLbl.TabIndex = 11;
            this.errorLbl.Text = "Error";
            this.errorLbl.Visible = false;
            // 
            // codeLbl
            // 
            this.codeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codeLbl.AutoSize = true;
            this.codeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.codeLbl.Location = new System.Drawing.Point(460, 459);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(0, 25);
            this.codeLbl.TabIndex = 3;
            this.codeLbl.Visible = false;
            // 
            // codeCmb
            // 
            this.codeCmb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeCmb.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codeCmb.ForeColor = System.Drawing.Color.Black;
            this.codeCmb.FormattingEnabled = true;
            this.codeCmb.Location = new System.Drawing.Point(540, 453);
            this.codeCmb.Name = "codeCmb";
            this.codeCmb.Size = new System.Drawing.Size(225, 31);
            this.codeCmb.TabIndex = 4;
            this.codeCmb.Visible = false;
            this.codeCmb.SelectedIndexChanged += new System.EventHandler(this.tProd_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(905, 604);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tCat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.codeCmb);
            this.Controls.Add(this.tProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.codeLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.tQuant);
            this.Controls.Add(this.tCust);
            this.Controls.Add(this.tID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox tID;
        private TextBox tQuant;
        private Label label1;
        private ComboBox tProd;
        private Label label3;
        private TextBox tCust;
        private Label label4;
        private Label label5;
        private ComboBox tCat;
        private TextBox tPrice;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Label label8;
        private Label label21;
        private Label label20;
        private Label priceLbl;
        private Label label18;
        private Label quantLbl;
        private Label label16;
        private Label prodLbl;
        private Label label14;
        private Label custLbl;
        private Label label12;
        private Label dateLbl;
        private Label label10;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
        private Label errorLbl;
        private Label codeLbl;
        private ComboBox codeCmb;
        private System.Windows.Forms.Timer timer1;
    }
}
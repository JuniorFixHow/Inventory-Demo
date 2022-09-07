namespace InventoryDemo
{
    public partial class Form1 : Form
    {
        bool transCollapse;
        bool stockCollapse;
        bool reportCollapse;
        bool userCollapse;
        Thread thread;
        public Form1()     
        {
            InitializeComponent();
            ShowForm(new Form3());
        }

        private void closeApp(object form)
        {
            Application.Run(new Form2());
        }

        private void ShowForm(object form)
        {
            panel4.Controls.Clear();
            Form currentForm = form as Form;
            currentForm.TopLevel = false;
            currentForm.Dock = DockStyle.Fill;
            panel4.Tag = currentForm;
            panel4.Controls.Add(currentForm);
            currentForm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (transCollapse)
            {
                panel5.Height += 10;
                if(panel5.Height == panel5.MaximumSize.Height)
                {
                    transCollapse = false;
                    timer1.Stop();
                    panel8.SendToBack();
                    panel6.SendToBack();
                    panel7.SendToBack();
                }
            }
            else
            {
                panel5.Height -= 10;
                if(panel5.Height == panel5.MinimumSize.Height)
                {
                    transCollapse = true;
                    timer1.Stop();
                }
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (stockCollapse)
            {
                panel8.Height += 10;
                if (panel8.Height == panel8.MaximumSize.Height)
                {
                    stockCollapse = false;
                    timer2.Stop();
                    //panel8.SendToBack();
                    panel6.SendToBack();
                    panel7.SendToBack();
                }
            }
            else
            {
                panel8.Height -= 10;
                if (panel8.Height == panel8.MinimumSize.Height)
                {
                    stockCollapse = true;
                    timer2.Stop();
                }
            }
        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (userCollapse)
            {
                panel7.Height += 10;
                if (panel7.Height == panel7.MaximumSize.Height)
                {
                    userCollapse = false;
                    timer3.Stop();
                }
            }
            else
            {
                panel7.Height -= 10;
                if (panel7.Height == panel7.MinimumSize.Height)
                {
                    userCollapse = true;
                    timer3.Stop();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (reportCollapse)
            {
                panel6.Height += 10;
                if (panel6.Height == panel6.MaximumSize.Height)
                {
                    reportCollapse = false;
                    timer4.Stop();
                    //panel8.SendToBack();
                    //panel6.SendToBack();
                    panel7.SendToBack();
                }
            }
            else
            {
                panel6.Height -= 10;
                if (panel6.Height == panel6.MinimumSize.Height)
                {
                    reportCollapse = true;
                    timer4.Stop();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm(new Form3());
            titleLbl.Text = "Home";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowForm(new Form8());
            titleLbl.Text = "Stock Managements";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowForm(new Form7());
            titleLbl.Text = "Order For Stocks";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowForm(new Form9());
            titleLbl.Text = "Orders";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowForm(new Form10());
            titleLbl.Text = "Stock Report";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowForm(new Form5());
            titleLbl.Text = "Transactions";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowForm(new Form11());
            titleLbl.Text = "Today's Report";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ShowForm(new Form12());
            titleLbl.Text = "Users";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ShowForm(new Form13());
            titleLbl.Text = "Sales Report";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ShowForm(new Form14());
            titleLbl.Text = "Product Categories";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowForm(new Form15());
            titleLbl.Text = "Password Request";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            ShowForm(new Form6());
            titleLbl.Text = "Account Management";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(closeApp);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roleType.Text = Form2.utype;
            label3.Text = Form2.userId;
            timer5.Start();

            if(Form2.utype == "Manager")
            {
               
                panel5.Hide();
                panel8.Location = new Point(0, 120);
                panel6.Location = new Point(0, 158);
                panel7.Location = new Point(-1, 196);
                panel8.MaximumSize = new Size(200, 174);

                button6.Hide();
                button10.Location = new Point(3, 90);
                button9.Location = new Point(3, 135);
            }

            if (Form2.utype == "Attendant")
            {

                panel6.Hide();
                panel7.MaximumSize = new Size(200, 89);
                panel7.Location = new Point(-1, 196);
                panel8.MaximumSize = new Size(200, 90);
               

                button15.Hide();
                button8.Hide();
                button6.Location = new Point(3, 45);
                button10.Hide();
                button9.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            //label3.Hide();
            label4.Hide();
            label6.Text = DateTime.Now.ToLongTimeString();
            label7.Text = DateTime.Now.ToLongDateString();
        }
    }
}
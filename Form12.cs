using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDemo
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void fetchData()
        {
            string query = "select id as UserID, uname as Username, email as Email, phone as Phone, role as Role from users ";
            DataSet ds = new DataSet();
            DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand(query, db.connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                db.closeConnection();

                dv = ds.Tables[0].DefaultView;
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "select id as UserID, uname as Username, email as Email, phone as Phone, role as Role from users where uname like '" + searchTxt.Text + "%' ";
            DataSet ds = new DataSet();
            DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if (searchTxt.Text != "")
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, db.connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    db.closeConnection();
                    dv = ds.Tables[0].DefaultView;
                    dataGridView1.DataSource = dv;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                fetchData();
            }
        }


        public void print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Users";
            printer.SubTitle = string.Format("Date {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "JuniorFixHow";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}

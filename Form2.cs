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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Thread thread;
        public static string utype;
        public static string userId;
        private void openReset(object form)
        {
            Application.Run(new Form4());
        }

        private void openApp(object form)
        {
            Application.Run(new Form1());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string Decrypt(string dec)
        {
            var decode = Convert.FromBase64String(dec);
            return Encoding.UTF8.GetString(decode);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openReset);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void showHidePassword(object sender, EventArgs e)
        {
            if(passTxt.UseSystemPasswordChar == true)
            {
                passTxt.UseSystemPasswordChar = false;
            }
            else
            {
                passTxt.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();

            if(nameTxt.Text!="" & passTxt.Text != "")
            {
                try
                {
                    string countQuery = "select * from users where uname = '" + nameTxt.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        db.openConnection();
                        string query = "select pass from users  where uname = '" + nameTxt.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        MySqlDataReader read = command.ExecuteReader();
                        read.Read();
                        string data = read.GetValue(0).ToString();
                        db.closeConnection();

                        db.openConnection();
                        string roleQuery = "select id, role from users where uname = '" + nameTxt.Text + "' ";
                        command = new MySqlCommand(roleQuery, db.connection);
                        MySqlDataReader rd = command.ExecuteReader();
                        rd.Read();
                        utype = rd.GetValue(1).ToString();
                        userId = rd.GetValue(0).ToString();
                        db.closeConnection();

                        try
                        {
                            bool verified = Decrypt(data) == passTxt.Text;
                            if (verified)
                            {
                                this.Close();
                                thread = new Thread(openApp);
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();
                            }
                            else
                            {
                                errorLbl.Visible = true;
                                errorLbl.ForeColor = Color.Crimson;
                                errorLbl.Text = "Incorrect Username or password";
                            }
                        }
                        catch(Exception ex)
                        {
                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.Crimson;
                            errorLbl.Text = ex.Message;
                        }

                        
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Crimson;
                        errorLbl.Text = "Incorrect Username or password";
                    }
                }
                catch(Exception ex)
                {
                    errorLbl.Visible = true;
                    errorLbl.ForeColor = Color.Crimson;
                    errorLbl.Text = ex.Message;
                }
            }
            else
            {
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.Crimson;
                errorLbl.Text = "Username and password are required";
            }

            /*this.Close();
            thread = new Thread(openApp);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();*/
        }
    }
}

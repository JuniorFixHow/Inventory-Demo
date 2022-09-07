using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDemo
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }


        public static string Encrypt(string enc)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(enc);
            return Convert.ToBase64String(data);
        }

        string password = CreatePassword(8);

        private void sendEmail()
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(email.fromEmail);
            message.Subject = "Account Created With JuniorFixHow";
            message.To.Add(new MailAddress(uemail.Text));
            message.Body = "<html>  <body>   <p>Hello Welcome To JuniorFixHow</p>  <p>You can log in with <p>Username: <b> '" + uname.Text + "' </b> </p>  <p>Password: <b> '" + password + "' </b> </p>  </p>  </body>   </html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(email.fromEmail, email.password),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            if(Form2.utype == "Attendant")
            {
                button2.Hide();
                button3.Hide();
                label6.Hide();
                label3.Hide();
                urole.Hide();
                upass.Hide();
                button1.Location = new Point(65, 265);
                errorLbl.Location = new Point(59, 237);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();
            if(uemail.Text!="" & uname.Text!="" & uphone.Text!="" & urole.Text != "")
            {
                try
                {
                    string countQuery = "select * from users where uname = '" + uname.Text + "' or email = '" + uemail.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Crimson;
                        errorLbl.Text = "User already exists";
                    }
                    else
                    {
                        db.openConnection();
                        string query = "insert into users (uname, email, pass, phone, role) values('" + uname.Text + "', '" + uemail.Text + "', '" + Encrypt(password) + "', '" + uphone.Text + "', '" + urole.Text + "') ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Green;
                        errorLbl.Text = "User Created Successfully";
                        sendEmail();
                        clear();
                    }
                }
                catch (Exception ex)
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
                errorLbl.Text = "Complete the required fields";
            }
        }

        public void clear()
        {
            uname.Clear();
            uemail.Clear();
            upass.Clear();
            uphone.Clear();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();

            if (uid.Text != "")
            {
                try
                {
                    string countQuery = "select * from users where id = '" + uid.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();

                    if (count > 0)
                    {
                        db.openConnection();
                        string query = "delete from users where id = '" + uid.Text + "'";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Green;
                        errorLbl.Text = "User deleted successfully";
                        clear();
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Crimson;
                        errorLbl.Text = "No user bears the the provided ID";
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
                errorLbl.Text = "Enter the ID of the user you are deleting";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();

            if (uid.Text != "")
            {
                try
                {
                    string countQuery = "select * from users where id = '" + uid.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();

                    if (count > 0)
                    {
                        if(uname.Text=="" & uemail.Text =="" & uphone.Text =="" & upass.Text=="" & urole.Text == "")
                        {
                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.Crimson;
                            errorLbl.Text = "Enter something to update";
                        }
                        else
                        {
                            if (uemail.Text != "")
                            {
                                db.openConnection();
                                string query = "update users set email = '" + uemail.Text + "' where id = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                command.ExecuteNonQuery();
                                db.closeConnection();
                            }

                            if (uname.Text != "")
                            {
                                db.openConnection();
                                string query = "update users set uname = '" + uname.Text + "' where id = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                command.ExecuteNonQuery();
                                db.closeConnection();
                            }

                            if (uphone.Text != "")
                            {
                                db.openConnection();
                                string query = "update users set phone = '" + uphone.Text + "' where id = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                command.ExecuteNonQuery();
                                db.closeConnection();
                            }

                            if (upass.Text != "" & upass.Text.Length>=8)
                            {
                                db.openConnection();
                                string query = "update users set pass = '" + Encrypt(upass.Text) + "' where id = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                command.ExecuteNonQuery();
                                db.closeConnection();
                            }

                            if (urole.Text != "")
                            {
                                db.openConnection();
                                string query = "update users set role = '" + urole.Text + "' where id = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                command.ExecuteNonQuery();
                                db.closeConnection();
                            }



                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.Green;
                            errorLbl.Text = "User details upated successfully";
                        }
                        
                        
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Crimson;
                        errorLbl.Text = "No user bears the the provided ID";
                    }
                }
                catch (Exception ex)
                {
                    errorLbl.Visible = true;
                    errorLbl.ForeColor = Color.Crimson;
                    errorLbl.Text = ex.Message;
                }
            }
            else{
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.Crimson;
                errorLbl.Text = "Enter the ID of the user you are updating";
            }
        }
    }
}

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Thread thread;
        private void openLogin(object form)
        {
            Application.Run(new Form2());
        }

        private void sendEmail()
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(resetEmail.Text);
            message.Subject = "Reset Password Request";
            message.To.Add(new MailAddress(email.fromEmail));
            message.Body = "<html>  <body>   <p>Hello JuniorFixHow</p>  <p>A user with <p>email: <b> '" + resetEmail.Text + "' </b> has requested for a password reset </p>   </p>  </body>   </html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(email.fromEmail, email.password),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();

            if (resetEmail.Text != "")
            {
                try {
                    string countQuery = "select * from users where email = '" + resetEmail.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        db.openConnection();
                        string query = "insert into pwdreq(dat, email) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + resetEmail.Text + "')";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        resetEmail.Clear();

                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Green;
                        errorLbl.Text = "Request sent";
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Crimson;
                        errorLbl.Text = "User doesn't exist";
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
                errorLbl.Text = "Enter a valid email";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}

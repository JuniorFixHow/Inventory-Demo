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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void loadCat()
        {
            try
            {
                db.openConnection();
                string query = "select id, catname from category";
                MySqlCommand command = new MySqlCommand(query, db.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                sCat.DataSource = dt;
                sCat.DisplayMember = "catname";
                sCat.ValueMember = "id";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            loadCat();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();

            if (catText.Text != "")
            {
                try
                {
                    string countQuery = "select * from category where catname ='" + catText.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        titleLbl.Visible = true;
                        titleLbl.ForeColor = Color.Crimson;
                        titleLbl.Text = "Category already exists";
                        markIcon.Visible = false;
                    }
                    else
                    {
                        db.openConnection();
                        string query = "insert into category(dat, catname) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + catText.Text + "')";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        catText.Clear();

                        titleLbl.Visible = true;
                        titleLbl.ForeColor = Color.FromArgb(185, 138, 233);
                        markIcon.Visible = true;
                        titleLbl.Text = "Add New Category";
                    }
                }
                catch(Exception ex)
                {
                    titleLbl.Visible = true;
                    titleLbl.ForeColor = Color.Crimson;
                    titleLbl.Text = ex.Message;
                    markIcon.Visible = false;
                }
            }
            else
            {
                titleLbl.Visible = true;
                titleLbl.ForeColor = Color.Crimson;
                titleLbl.Text = "Enter category name";
                markIcon.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();

            if (catText.Text != "")
            {
                try
                {
                    string countQuery = "select * from category where catname ='" + catText.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        db.openConnection();
                        string query = "delete from category where catname = '" + catText.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        catText.Clear();


                        titleLbl.Visible = true;
                        titleLbl.ForeColor = Color.FromArgb(185, 138, 233);
                        markIcon.Visible = true;
                        titleLbl.Text = "Add New Category";
                    }
                    else
                    {

                        titleLbl.Visible = true;
                        titleLbl.ForeColor = Color.Crimson;
                        titleLbl.Text = "Category doesn't exist";
                        markIcon.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    titleLbl.Visible = true;
                    titleLbl.ForeColor = Color.Crimson;
                    titleLbl.Text = ex.Message;
                    markIcon.Visible = false;
                }
            }
            else
            {
                titleLbl.Visible = true;
                titleLbl.ForeColor = Color.Crimson;
                titleLbl.Text = "Enter category name";
                markIcon.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();
            if(sProd.Text!="" & sPrice.Text!="" & sQuant.Text!="" & sCat.Text != "")
            {
                try
                {
                    string query = "insert into stocks (dat, category, product, quantity, price) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + sCat.Text + "', '" + sProd.Text + "', '" + sQuant.Text + "', '" + sPrice.Text + "')";
                    command = new MySqlCommand(query, db.connection);
                    command.ExecuteNonQuery();
                    db.closeConnection();

                    errorLbl.Visible = true;
                    errorLbl.ForeColor = Color.Green;
                    errorLbl.Text = "Stock loaded successfully";
                    clear();
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
                errorLbl.Text = "Complete the required fields";
               
            }
        }

        private void clear()
        {
            sPrice.Clear();
            sId.Clear();
            sProd.Clear();
            sQuant.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();

            if (sId.Text != "")
            {
                try
                {
                    string countQuery = "select * from stocks where id = '" + sId.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        db.openConnection();
                        string query = "delete from stocks where id = '" + sId.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();

                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Green;
                        errorLbl.Text = "Stock deleted successfully";
                        clear();
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Crimson;
                        errorLbl.Text = "There's no such stock";
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
                errorLbl.Text = "Enter the ID of the stock you are deleting";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();

            if (sId.Text != "")
            {
                try
                {
                    string countQuery = "select * from stocks where id = '" + sId.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                       if(sProd.Text=="" & sPrice.Text=="" & sQuant.Text=="" & sCat.Text == "")
                        {
                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.Crimson;
                            errorLbl.Text = "Enter something to update";
                        }
                        else
                        {
                            if (sProd.Text != "")
                            {
                                db.openConnection();
                                string query = "update stocks set product = '" + sProd.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                command.ExecuteNonQuery();
                                db.closeConnection();
                            }

                            if (sCat.Text != "")
                            {
                                db.openConnection();
                                string query = "update stocks set category = '" + sCat.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                command.ExecuteNonQuery();
                                db.closeConnection();
                            }

                            if (sQuant.Text != "")
                            {
                                db.openConnection();
                                string query = "update stocks set quantity = '" + sQuant.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                command.ExecuteNonQuery();
                                db.closeConnection();
                            }

                            if (sPrice.Text != "")
                            {
                                db.openConnection();
                                string query = "update stocks set price = '" + sPrice.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                command.ExecuteNonQuery();
                                db.closeConnection();
                            }


                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.Green;
                            errorLbl.Text = "Stock updated successfully";

                        }
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Crimson;
                        errorLbl.Text = "There's no such stock";
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
                errorLbl.Text = "Enter the ID of the stock you are updating";
            }
        }
    }
}

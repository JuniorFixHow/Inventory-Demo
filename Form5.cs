using AForge.Video;
using AForge.Video.DirectShow;
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
using ZXing;
using ZXing.Windows.Compatibility;

namespace InventoryDemo
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        private void receipt()
        {
            dateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd");
            custLbl.Text = tCust.Text;
            prodLbl.Text = tProd.Text;
            quantLbl.Text = tQuant.Text;
            priceLbl.Text = "$ "+ tPrice.Text;
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

                tCat.DataSource = dt;
                tCat.DisplayMember = "catname";
                tCat.ValueMember = "id";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filter)
                codeCmb.Items.Add(filterInfo.Name);
            codeCmb.SelectedIndex = 0;

            loadCat();
        }

        private void tProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();
            if(tProd.Text!="" & tQuant.Text!="" & tCust.Text!="" & tCat.Text!="" & tPrice.Text != "")
            {
                try
                {
                    string query = "insert into trans(dat, category, product, quantity, price, customer) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + tCat.Text + "', '" + tProd.Text + "', '" + tQuant.Text + "', '" + tPrice.Text + "', '" + tCust.Text + "', '"+codeLbl.Text+"' )";
                    command = new MySqlCommand(query, db.connection);
                    command.ExecuteNonQuery();
                    db.closeConnection();
                    errorLbl.Visible = true;
                    errorLbl.ForeColor = Color.Green;
                    errorLbl.Text = "Transaction posted";
                    receipt();
                    clear();
                }
                catch(Exception ex)
                {
                    errorLbl.Visible = true;
                    errorLbl.ForeColor = Color.Crimson;
                    errorLbl.Text = ex.Message;
                }
            }
            else{
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.Crimson;
                errorLbl.Text = "Complete the required fileds";
            }
        }

        private void clear()
        {
            tID.Clear();
            tPrice.Clear();
            tQuant.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();
            if (tID.Text!="") {
                try
                {
                    string countQuery = "select * from trans where id = '" + tID.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();

                    if (count > 0)
                    {
                        db.openConnection();
                        string query = "delete from trans where id = '" + tID.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();

                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Green;
                        errorLbl.Text = "Transaction deleted";
                        clear();
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Crimson;
                        errorLbl.Text = "There's no such transaction";
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
                errorLbl.Text = "Enter ID of the transaction your are deleting";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[codeCmb.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                BarcodeReader bar = new BarcodeReader();
                Result result = bar.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    codeLbl.Text = result.ToString();
                    timer1.Stop();

                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void tCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string query = "select id, product from stocks where category = '"+tCat.Text+"' ";
                MySqlCommand command = new MySqlCommand(query, db.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tProd.DataSource = dt;
                tProd.DisplayMember = "product";
                tProd.ValueMember = "id";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tQuant_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.Back)
            {
                tQuant.Text = "";
                e.Handled = true;
            }
        }

        private void tQuant_TextChanged(object sender, EventArgs e)
        {
            int val;
            bool result = int.TryParse(tQuant.Text, out val);
            if (!result)
            {
                tQuant.Text = null;
            }
            else
            {
                if(tQuant.Text!=null & Convert.ToDouble(tQuant.Text) > 0)
                {
                    db.openConnection();
                    MySqlCommand command;
                    try
                    {
                        string query = "select price, quantity from stocks where product = '" + tProd.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        MySqlDataReader price = command.ExecuteReader();
                        price.Read();

                        double getQuant = Convert.ToDouble(price.GetValue(1).ToString());
                        if(getQuant < Convert.ToDouble(tQuant.Text))
                        {
                            button2.Enabled = false;
                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.Crimson;
                            errorLbl.Text = tProd.Text + " is less than the quantity selling";
                        }
                        else
                        {
                            button2.Enabled = true;
                            errorLbl.Visible = false;
                            double setPrice = Convert.ToDouble(price.GetValue(0).ToString()) * Convert.ToDouble(tQuant.Text);
                            tPrice.Text = setPrice.ToString();
                        }

                        
                        db.closeConnection();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    tPrice.Text = "0.00";
                }
            }
        }
    }
}

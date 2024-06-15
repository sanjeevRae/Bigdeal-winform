using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using wfdbig;

namespace wfdbig
{
    public partial class Shipping : Form
    {
        private string connectionString = "server=localhost;user=root;database=bigdeal;port=3306;password=@Mysqlserver;";
        public Shipping()
        {
            InitializeComponent();



            pp1.Visible = false;
            pictureBox11.BackColor = Color.Transparent;
            MeroTimer();


            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer;
            timer.Start();

            LoadTotalFromDatabase();
        }

        private void Timer(object sender, EventArgs e)
        {

            MeroTimer();
        }

        private void MeroTimer()
        {

            lbldate.Text = DateTime.Now.ToShortDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ShowCustomMessageBox()
        {
            CustomMessageBox customMessageBox = new CustomMessageBox("Thank You for Your Purchase!", "Please let us know about your shopping experience.", this);
            customMessageBox.ShowDialog();
        }


        private void pictureBox10_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO payment (email, fullname, address, phone, payment_type, city, zip, state) VALUES (@Email, @Name, @Address, @Phone , @Payment, @City, @Zip,  @State)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Name", txtFullname.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Payment", txtPayment.Text);
                        cmd.Parameters.AddWithValue("@City", txtCity.Text);
                        cmd.Parameters.AddWithValue("@Zip", txtZip.Text);
                        cmd.Parameters.AddWithValue("@State", txtState.Text);
                        cmd.ExecuteNonQuery();

                        ShowCustomMessageBox();

                    }
                    pp1.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pp1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Cart ok = new Cart();
            ok.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Red;
            label8.ForeColor = Color.Black;
            txtPayment.Text = "Cash on delivery";
            pictureBox12.BackColor = Color.White;
            pictureBox13.BackColor = Color.LightGray;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
            label9.ForeColor = Color.Black;
            pictureBox13.BackColor = Color.White;

            txtPayment.Text = "Khalti (online payment)";

            string url = "https://sanjeevrae.github.io/Payment-v1/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });

        }


        public void SetItem1P(string value)
        {
            item1p.Text = value;

        }

        public void SetItem1(string value)
        {
            item1.Text = value;

        }


        public void SetItem2P(string value)
        {
            item2p.Text = value;

        }

        public void SetItem2(string value)
        {
            item2.Text = value;

        }

        public void SetItem3P(string value)
        {
            item3p.Text = value;

        }

        public void SetItem3(string value)
        {
            item3.Text = value;

        }

        private void LoadTotalFromDatabase()
        {
            int totalFromDatabase = DatabaseHelper.GetTotalPrice();
            alltotal2.Text = totalFromDatabase.ToString();
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.LightGray;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.White;
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.LightGray;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.White;
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            Cart ok = new Cart();
            ok.Show();
            this.Hide();
        }

        private void Shipping_Load(object sender, EventArgs e)
        {
            sst.Text = alltotal2.Text;
        }
    }
}

using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MimeKit;
using System;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;


namespace wfdbig
{
    public partial class sign : Form
    {
        private string connectionString = "server=localhost;user=root;database=bigdeal;port=3306;password=@Mysqlserver;";
       
        public sign()
        {
            InitializeComponent();

            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            txtPassword.PasswordChar = '*';
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            txtPassword.PasswordChar = '\0';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            sms gogo = new sms();
            gogo.Show();
            this.Close();
        }

        private void sign_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sms gogo = new sms();

            gogo.Show();
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsAdmin(email, password))
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else if (AuthenticateUser(email, password))
            {
                thankyou u = new thankyou();
                u.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string email, string password)
        {
            bool isAuthenticated = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM user_data WHERE email = @Email AND password = @Password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        isAuthenticated = count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return isAuthenticated;
        }

        private bool IsAdmin(string email, string password)
        {
            bool isAdmin = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM admin WHERE email = @Email AND password = @Password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        isAdmin = count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return isAdmin;
        }

    }
}


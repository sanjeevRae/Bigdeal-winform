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
    public partial class sms : Form
    {
        private string generatedOTP;
        private GmailService gmailService;
        private bool programmaticChange = false;
        private string connectionString = "server=localhost;user=root;database=bigdeal;port=3306;password=@Mysqlserver;";


        public sms()
        {
            InitializeComponent();
            txtEmail.TextChanged += TxtEmail_TextChanged;
            panel1.Visible = false;
        }


        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

            useremail.Text = txtEmail.Text;
        }


        private void SaveUserToDatabase(string username, string email, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO user_data (Username, Email, Password) VALUES (@Username, @Email, @Password)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save user to database: " + ex.Message);
                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            label6.Visible = false;

            string email = txtEmail.Text.Trim();
            string username = txtusername.Text.Trim();

            string password = txtPassword.Text;
            SaveUserToDatabase(username, email, password);

            generatedOTP = GenerateOTP();

            SendEmail(email, generatedOTP);

        }

        private void VerifyOTP_Click(object sender, EventArgs e)
        {
            string enteredOTP = txtVerify.Text.Trim();
            if (enteredOTP == generatedOTP)
            {
                sign goo = new sign();
                goo.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect OTP. Please try again.");
            }
        }

        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendEmail(string toEmail, string otp)
        {

            UserCredential credential;
            using (var stream = new FileStream(@"A:\4th sem\w.deal\client_secret_835106084989-9760750t1a6gj4jnvhn8299lt1r1ohmr.apps.googleusercontent.com.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { GmailService.Scope.GmailSend },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }


            gmailService = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "BIGDEAL",
            });


            MailMessage mail = new MailMessage("yourEmailAddress@gmail.com", toEmail);
            mail.Subject = "BIGDEAL Verification";
            mail.Body = "🎉🎉Thank You For Joining BIGDEAL!!🎉🎉\n\n\n" + "Your OTP for verification is: " + otp;

            try
            {
                Google.Apis.Gmail.v1.Data.Message message = CreateMessage(mail);
                SendMessage(message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP. Error: " + ex.Message);
            }
        }

        private Google.Apis.Gmail.v1.Data.Message CreateMessage(MailMessage mail)
        {
            MimeMessage mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress(mail.From.DisplayName, mail.From.Address));


            foreach (MailAddress toAddress in mail.To)
            {
                mimeMessage.To.Add(new MailboxAddress(toAddress.DisplayName, toAddress.Address));
            }

            mimeMessage.Subject = mail.Subject;

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mail.Body;

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            using (MemoryStream memoryStream = new MemoryStream())
            {
                mimeMessage.WriteTo(memoryStream);
                byte[] bytes = memoryStream.ToArray();
                string base64EncodedEmail = Convert.ToBase64String(bytes);
                return new Google.Apis.Gmail.v1.Data.Message { Raw = base64EncodedEmail };
            }
        }

        private void SendMessage(Google.Apis.Gmail.v1.Data.Message message)
        {
            gmailService.Users.Messages.Send(message, "me").Execute();
        }

        private void sms_Load(object sender, EventArgs e)
        {

        }

        private void useremail_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VerifyOTP_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtVerify_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            txtPassword.PasswordChar = '\0';
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            txtPassword.PasswordChar = '*';
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            

            sign gogo = new sign();
            gogo.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            


            sign gogo = new sign();
            gogo.Show();
            this.Close();
        }
    }


}

    

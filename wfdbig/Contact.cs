using System.Diagnostics;
using static System.Windows.Forms.Design.AxImporter;
using System;
using System.IO;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Text;
using MimeKit;
using System.Timers;
using wfdbig.Properties;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace wfdbig
{
    public partial class Contact : Form


    {
        private bool isDragging;
        private Point lastMousePosition;
        private Color originalLabelColor;
        private int remainingSeconds = 30 * 24 * 60 * 60;
        private System.Windows.Forms.Timer timer;
        private bool pictureBox11Clicked = false;
        private bool nameChanged = false;
        private bool emailChanged = false;
        private bool messageChanged = false;


        private string connectionString = "server=localhost;user=root;database=bigdeal;port=3306;password=@Mysqlserver;";



        public Contact()
        {
            InitializeComponent();


            this.MouseDown += Contact_MouseDown;
            this.MouseUp += Contact_MouseUp;

            pictureBox1.BackColor = Color.Transparent;

            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;


            label56.ForeColor = Color.Transparent;
            label41.ForeColor = Color.Transparent;

            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;


            pagesToolStripMenuItem.MouseHover += pagesToolStripMenuItem_MouseHover;
            pagesToolStripMenuItem.MouseLeave += pagesToolStripMenuItem_MouseLeave;




            pictureBox3.Click += MinimizePictureBox_Click;
            pictureBox2.Click += MaximizePictureBox_Click;

            pictureBox8.Visible = false;
            pictureBox12.Visible = false;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += timer1_Tick;

            panel8.Visible = false;
        }





        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizePictureBox_Click(object sender, EventArgs e)
        {
            // Maximize or restore the form
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {


        }

        private void Contact_Load(object sender, EventArgs e)
        {


        }





        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Contact_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void Contact_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = new Point(e.Location.X - lastMousePosition.X, e.Location.Y - lastMousePosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastMousePosition = e.Location;
            }
        }

        private void Contact_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            products nice = new products();
            nice.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Contact ContactForm = new Contact();
            ContactForm.Show();
            this.Hide();
        }


        private void pictureBox41_Click(object sender, EventArgs e)
        {
            string url = "https://sanjeevrae.github.io/v1/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }



        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }


        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label56.ForeColor = Color.Red;
            label57.ForeColor = Color.Transparent;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label56.ForeColor = Color.Transparent;
            label57.ForeColor = Color.Red;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {

        }



        private void pagesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void pagesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private async void pictureBox9_Click_1(object sender, EventArgs e)
        {

            if (!pictureBox11Clicked)
            {
                MessageBox.Show("Please verify first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO contact (email, name, message) VALUES (@Email, @Name, @Message)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                            cmd.Parameters.AddWithValue("@Name", txtname.Text);
                            cmd.Parameters.AddWithValue("@Message", txtmessage.Text);
                            cmd.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }

                UserCredential credential;

                using (var stream = new FileStream(@"A:\4th sem\w.deal\client_secret_835106084989-9760750t1a6gj4jnvhn8299lt1r1ohmr.apps.googleusercontent.com.json", FileMode.Open, FileAccess.Read))
                {
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        new[] { GmailService.Scope.GmailSend },
                        "user", CancellationToken.None);
                }

                var service = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "BIG DEAL",
                });

                var message = new MimeKit.MimeMessage();
                message.From.Add(new MimeKit.MailboxAddress(txtemail.Text.Trim(), txtemail.Text.Trim()));

                message.To.Add(new MimeKit.MailboxAddress("Admin: Sanjeev ", "sa.sanzeeprae@gmail.com"));

                message.Subject = "Message from " + txtname.Text.Trim() + " (" + txtemail.Text.Trim() + ")";


                var textPart = new MimeKit.TextPart("plain")
                {
                    Text = txtmessage.Text
                };

                message.Body = textPart;

                var rawMessage = message.ToString();

                var gmailMessage = new Google.Apis.Gmail.v1.Data.Message { Raw = Convert.ToBase64String(Encoding.UTF8.GetBytes(rawMessage)) };

                var result = service.Users.Messages.Send(gmailMessage, "me").Execute();

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            {


            }
        }



        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11Clicked = true;
            pictureBox8.Visible = true;
            pictureBox11.Visible = false;
            pictureBox10.Visible = false;
            timer.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
            pictureBox8.Visible = false;

            timer.Stop();

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

            if (!nameChanged)
            {
                txtname.Text = "";
                nameChanged = true;
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (!emailChanged)
            {
                txtemail.Text = "";
                emailChanged = true;
            }
        }

        private void txtmessage_TextChanged(object sender, EventArgs e)
        {
            if (!messageChanged)
            {
                txtmessage.Text = "";
                messageChanged = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void name_Enter(object sender, EventArgs e)
        {
            txtname.ForeColor = Color.Black;

        }

        private void name_Leave(object sender, EventArgs e)
        {

            txtname.ForeColor = Color.Green;
        }

        private void name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string input = txtname.Text;

            if (input.Any(char.IsDigit))
            {
                MessageBox.Show("Name should contain only characters, not numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Cancel = true;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {

            txtemail.ForeColor = Color.Black;
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            txtemail.ForeColor = Color.Green;
        }

        private void txtmessage_Enter(object sender, EventArgs e)
        {

            txtmessage.ForeColor = Color.Black;
        }

        private void txtmessage_Leave(object sender, EventArgs e)
        {
            txtmessage.ForeColor = Color.Green;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label41.ForeColor = Color.Red;
            label57.ForeColor = Color.Transparent;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label41.ForeColor = Color.Transparent;
            label57.ForeColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FAQ gogo = new FAQ();
            gogo.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home yosein = new Home();
            yosein.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Contact hih = new Contact();
            hih.Show();
            this.Hide();
        }

        private void pagesToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            pagesToolStripMenuItem.ShowDropDown();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sign ok = new sign();
            ok.Show();
            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ok = new About();
            ok.Show();
            this.Hide();
        }
    }

}
 

  


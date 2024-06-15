using System.Windows.Forms;
using System.Diagnostics;
using wfdbig.Properties;
using static System.Windows.Forms.Design.AxImporter;


namespace wfdbig
{
    public partial class Home : Form


    {
        private bool isDragging;
        private Point lastMousePosition;
        private Size originalPictureBoxSize;
        private Color originalLabelColor;
        private int remainingSeconds = 30 * 24 * 60 * 60;
        private readonly nice_logo nice;
        private readonly _1options optionsPanel1;
        private readonly _2options optionsPanel2;
        private readonly _3options optionsPanel3;
      


        public Home()
        {
            InitializeComponent();


            this.MouseDown += Home_MouseDown;
            this.MouseMove += Home_MouseMove;
            this.MouseUp += Home_MouseUp;

            pictureBox1.BackColor = Color.Transparent;

            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;


            label56.ForeColor = Color.Transparent;


            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;






            pictureBox3.Click += MinimizePictureBox_Click;
            pictureBox2.Click += MaximizePictureBox_Click;


            UpdateCountdownDisplay();


            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;


            timer1.Start();



            optionsPanel1 = new _1options();
            optionsPanel2 = new _2options();
            optionsPanel3 = new _3options();
            nice = new nice_logo();



            panel1.Controls.Add(nice);
            panel7.Controls.Add(optionsPanel1);

            optionsPanel2.Visible = false;
            optionsPanel3.Visible = false;


            panel7.Controls.Add(optionsPanel2);
            panel7.Controls.Add(optionsPanel3);


            label16.Click += label16_Click;
            label17.Click += label17_Click;
            label18.Click += label18_Click;

            label20.Visible = false;
            label21.Visible = true;
            label22.Visible = false;
            label23.Visible = false;

            AnC.Visible = false;
            

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

        private void Home_Load(object sender, EventArgs e)
        {
            originalPictureBoxSize = pictureBox9.Size;
            originalPictureBoxSize = pictureBox10.Size;
            originalPictureBoxSize = pictureBox11.Size;

            originalLabelColor = label12.ForeColor;
            originalLabelColor = label15.ForeColor;
            originalLabelColor = label13.ForeColor;




            pictureBox9.MouseHover += pictureBox9_MouseHover;
            pictureBox9.MouseLeave += pictureBox9_MouseLeave;

            pictureBox10.MouseHover += pictureBox10_MouseHover;
            pictureBox10.MouseLeave += pictureBox10_MouseLeave;

            pictureBox11.MouseHover += pictureBox11_MouseHover;
            pictureBox11.MouseLeave += pictureBox11_MouseLeave;


           


        }





        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = new Point(e.Location.X - lastMousePosition.X, e.Location.Y - lastMousePosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastMousePosition = e.Location;
            }
        }

        private void Home_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            products productsForm = new products();
            productsForm.Show();
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
            Home HomeForm = new Home();
            HomeForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;


            if (remainingSeconds <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Theis Deal is  Expired!");
            }
            UpdateCountdownDisplay();
        }

        private void UpdateCountdownDisplay()
        {

            int days = remainingSeconds / (24 * 60 * 60);
            int hours = (remainingSeconds % (24 * 60 * 60)) / (60 * 60);
            int minutes = (remainingSeconds % (60 * 60)) / 60;
            int seconds = remainingSeconds % 60;

            label5.Text = $"{days:D2} : {hours:D2} : {minutes:D2} : {seconds:D2}";
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(pictureBox9.Width + 5, pictureBox9.Height + 5);


            label12.ForeColor = Color.Red;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(originalPictureBoxSize.Width, originalPictureBoxSize.Height);


            label12.ForeColor = originalLabelColor;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(pictureBox10.Width + 5, pictureBox10.Height + 5);


            label13.ForeColor = Color.Red;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(originalPictureBoxSize.Width, originalPictureBoxSize.Height);


            label13.ForeColor = originalLabelColor;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.Size = new Size(pictureBox11.Width + 5, pictureBox11.Height + 5);


            label15.ForeColor = Color.Red;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Size = new Size(originalPictureBoxSize.Width, originalPictureBoxSize.Height);


            label15.ForeColor = originalLabelColor;
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label56.ForeColor = Color.Red;
            label41.ForeColor = Color.Transparent;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label56.ForeColor = Color.Transparent;
            label41.ForeColor = Color.Red;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label20.Visible = true;
            label41.ForeColor = Color.Transparent;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label20.Visible = false;
            label41.ForeColor = Color.Red;
        }

        private void pagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }





        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)

        {

            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = true;


            label16.ForeColor = Color.Black;
            label17.ForeColor = Color.Silver;
            label18.ForeColor = Color.Silver;

            optionsPanel1.Visible = false;
            optionsPanel2.Visible = true;
            optionsPanel3.Visible = false;


        }

        private void label17_Click(object sender, EventArgs e)
        {
            label21.Visible = true;
            label22.Visible = false;
            label23.Visible = false;


            label16.ForeColor = Color.Silver;
            label17.ForeColor = Color.Black;
            label18.ForeColor = Color.Silver;

            optionsPanel1.Visible = true;

            optionsPanel2.Visible = false;
            optionsPanel3.Visible = false;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            label21.Visible = false;
            label22.Visible = true;
            label23.Visible = false;


            label16.ForeColor = Color.Silver;
            label17.ForeColor = Color.Silver;
            label18.ForeColor = Color.Black;
            optionsPanel1.Visible = false;
            optionsPanel2.Visible = false;
            optionsPanel3.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FAQ yes = new FAQ();
            yes.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label20.Visible = true;
            Contact gog = new Contact();
            gog.Show();
            this.Hide();

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            string url = "https://sanjeevrae.github.io/Payment-v1/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cart ok = new Cart();
            ok.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sign wkwk = new sign();
            wkwk.Show();
            this.Hide();
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            AnC.Visible = true;
            label41.ForeColor = Color.Transparent;


        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {

            label41.ForeColor = Color.Red;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AnC_MouseEnter(object sender, EventArgs e)
        {
            AnC.Visible = true;
            label56.ForeColor = Color.Transparent;
        }

        private void AnC_MouseLeave(object sender, EventArgs e)
        {

            label41.ForeColor = Color.Red;


        }

        private void label19_Click_1(object sender, EventArgs e)
        {
            label41.ForeColor = Color.Transparent;
            AnC.Visible = !AnC.Visible;

        }

        private void AnC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {
            About ok = new About();
            ok.Show();
            this.Hide();

        }
    }
}


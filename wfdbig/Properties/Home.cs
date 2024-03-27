using System.Windows.Forms;
using System.Diagnostics;
using wfdbig.Properties;

namespace wfdbig
{
    public partial class Home : Form


    {
        private bool isDragging;
        private Point lastMousePosition;
        private Size originalPictureBoxSize;
        private Color originalLabelColor;
        private int remainingSeconds = 30 * 24 * 60 * 60;

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
            label57.ForeColor = Color.Transparent;

            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;


            pagesToolStripMenuItem.MouseHover += pagesToolStripMenuItem_MouseHover;
            pagesToolStripMenuItem.MouseLeave += pagesToolStripMenuItem_MouseLeave;




            pictureBox3.Click += MinimizePictureBox_Click;
            pictureBox2.Click += MaximizePictureBox_Click;


            UpdateCountdownDisplay();


            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;


            timer1.Start();


            //label 16 ma 12, 15, 17, 19
            //label 33 27, 25, 21, 23
            //label 35 12, 15, 21, 23

            label16.ForeColor = System.Drawing.Color.Black;
            label33.ForeColor = System.Drawing.Color.Gray;
            label35.ForeColor = System.Drawing.Color.Gray;

            label16.Click += label16_Click;
            label33.Click += label33_Click;
            label35.Click += label35_Click;



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

            pictureBox12.Size = new Size(pictureBox12.Width + 5, pictureBox12.Height + 5);


            label17.ForeColor = Color.Red;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            originalPictureBoxSize = pictureBox12.Size;
            originalPictureBoxSize = pictureBox9.Size;
            originalPictureBoxSize = pictureBox10.Size;
            originalPictureBoxSize = pictureBox11.Size;

            originalLabelColor = label17.ForeColor;
            originalLabelColor = label12.ForeColor;
            originalLabelColor = label15.ForeColor;
            originalLabelColor = label13.ForeColor;



            pictureBox12.MouseHover += pictureBox12_MouseHover;
            pictureBox12.MouseLeave += pictureBox12_MouseLeave;

            pictureBox9.MouseHover += pictureBox9_MouseHover;
            pictureBox9.MouseLeave += pictureBox9_MouseLeave;

            pictureBox10.MouseHover += pictureBox10_MouseHover;
            pictureBox10.MouseLeave += pictureBox10_MouseLeave;

            pictureBox11.MouseHover += pictureBox11_MouseHover;
            pictureBox11.MouseLeave += pictureBox11_MouseLeave;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(originalPictureBoxSize.Width, originalPictureBoxSize.Height);


            label17.ForeColor = originalLabelColor;
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
            label16.ForeColor = System.Drawing.Color.Black;
            label33.ForeColor = System.Drawing.Color.Gray;
            label35.ForeColor = System.Drawing.Color.Gray;

            pictureBox12.Visible = true;
            label17.Visible = true;
            pictureBox13.Visible = true;
            label18.Visible = true;


            pictureBox15.Visible = true;
            label20.Visible = true;
            pictureBox14.Visible = true;
            label19.Visible = true;


            pictureBox17.Visible = true;
            label22.Visible = true;
            pictureBox16.Visible = true;
            label21.Visible = true;


            pictureBox19.Visible = false;
            label24.Visible = false;
            pictureBox18.Visible = false;
            label23.Visible = false;




            pictureBox27.Visible = false;
            label32.Visible = false;
            pictureBox20.Visible = false;
            label31.Visible = false;

            pictureBox25.Visible = false;
            label30.Visible = false;
            pictureBox24.Visible = false;
            label29.Visible = false;

            pictureBox21.Visible = false;
            label28.Visible = false;
            pictureBox26.Visible = false;
            label27.Visible = false;

            pictureBox23.Visible = true;
            label26.Visible = true;
            pictureBox22.Visible = true;
            label25.Visible = true;
        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {
            label16.ForeColor = System.Drawing.Color.Gray;
            label33.ForeColor = System.Drawing.Color.Black;
            label35.ForeColor = System.Drawing.Color.Gray;

            pictureBox27.Visible = true;
            label32.Visible = true;
            pictureBox20.Visible = true;
            label31.Visible = true;

            pictureBox25.Visible = false;
            label30.Visible = false;
            pictureBox24.Visible = false;
            label29.Visible = false;

            pictureBox21.Visible = true;
            label28.Visible = true;
            pictureBox26.Visible = true;
            label27.Visible = true;

            pictureBox23.Visible = true;
            label26.Visible = true;
            pictureBox22.Visible = true;
            label25.Visible = true;

            pictureBox12.Visible = false;
            label17.Visible = false;
            pictureBox13.Visible = false;
            label18.Visible = false;


            pictureBox15.Visible = true;
            label20.Visible = true;
            pictureBox14.Visible = true;
            label19.Visible = true;


            pictureBox17.Visible = false;
            label22.Visible = false;
            pictureBox16.Visible = false;
            label21.Visible = false;


            pictureBox19.Visible = false;
            label24.Visible = false;
            pictureBox18.Visible = false;
            label23.Visible = false;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            label16.ForeColor = System.Drawing.Color.Gray;
            label33.ForeColor = System.Drawing.Color.Gray;
            label35.ForeColor = System.Drawing.Color.Black;

            pictureBox12.Visible = true;
            label17.Visible = true;
            pictureBox13.Visible = true;
            label18.Visible = true;


            pictureBox15.Visible = true;
            label20.Visible = true;
            pictureBox14.Visible = true;
            label19.Visible = true;

            pictureBox21.Visible = true;
            label28.Visible = true;
            pictureBox26.Visible = true;
            label27.Visible = true;

            pictureBox23.Visible = true;
            label26.Visible = true;
            pictureBox22.Visible = true;
            label25.Visible = true;



            pictureBox17.Visible = false;
            label22.Visible = false;
            pictureBox16.Visible = false;
            label21.Visible = false;


            pictureBox19.Visible = false;
            label24.Visible = false;
            pictureBox18.Visible = false;
            label23.Visible = false;

            pictureBox27.Visible = false;
            label32.Visible = false;
            pictureBox20.Visible = false;
            label31.Visible = false;

            pictureBox25.Visible = false;
            label30.Visible = false;
            pictureBox24.Visible = false;
            label29.Visible = false;
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
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
            label57.ForeColor = Color.Red;
            label41.ForeColor = Color.Transparent;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label57.ForeColor = Color.Transparent;
            label41.ForeColor = Color.Red;
        }

        private void pagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            pagesToolStripMenuItem.ShowDropDown();
        }

        private void pagesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pagesToolStripMenuItem.HideDropDown();
        }
    }
}


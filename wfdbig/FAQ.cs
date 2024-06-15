using System.Windows.Forms;
using System.Diagnostics;

using static System.Windows.Forms.Design.AxImporter;
using wfdbig.Properties;

namespace wfdbig
{
    public partial class FAQ : Form


    {
        private bool isDragging;
        private Point lastMousePosition;
        private Color originalLabelColor;
        private int remainingSeconds = 30 * 24 * 60 * 60;




        public FAQ()
        {
            InitializeComponent();


            this.MouseDown += FAQ_MouseDown;
            this.MouseMove += FAQ_MouseMove;
            this.MouseUp += FAQ_MouseUp;

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

        private void FAQ_Load(object sender, EventArgs e)
        {


        }





        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {

        }

        private void FAQ_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void FAQ_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = new Point(e.Location.X - lastMousePosition.X, e.Location.Y - lastMousePosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastMousePosition = e.Location;
            }
        }

        private void FAQ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            products hey = new products();
            hey.Show();
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
            FAQ FAQForm = new FAQ();
            FAQForm.Show();
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



        private void pagesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            pagesToolStripMenuItem.ShowDropDown();
        }

        private void pagesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pagesToolStripMenuItem.HideDropDown();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Contact ok = new Contact();
            ok.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FAQ ok = new FAQ();
            ok.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sign ok = new sign();
            ok.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cart ok = new Cart();
            ok.Show();
            this.Hide();
        }
    }
}


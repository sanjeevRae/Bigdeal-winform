using System.Windows.Forms;
using System.Diagnostics;

using static System.Windows.Forms.Design.AxImporter;
using wfdbig.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wfdbig
{
    public partial class Cart : Form


    {

        private bool isDragging;
        private Point lastMousePosition;

        private List<Up103> removedControls = new List<Up103>();





        public Cart()
        {
            InitializeComponent();



            this.MouseDown += Cart_MouseDown;
            this.MouseMove += Cart_MouseMove;
            this.MouseUp += Cart_MouseUp;

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

            AddUp103ToCart();

            AddUp101ToCart();

            AddUp102ToCart();




        }

        public void RemoveUserControlFromCart(UserControl controlToRemove)
        {

            FLP.Controls.Remove(controlToRemove);
        }

        public void AddUp101ToCart()
        {
            Up101 up101Control = new Up101(this);
            up101Control.Location = new Point(3, 3);
            up101Control.Size = new Size(946, 355);
            FLP.Controls.Add(up101Control);
        }

        public void AddUp102ToCart()
        {
            Up102 up101Control = new Up102();
            up101Control.Location = new Point(3, 3);
            up101Control.Size = new Size(946, 355);
            FLP.Controls.Add(up101Control);
        }


        public void AddUp103ToCart()
        {
            Up103 up103Control = new Up103();
            up103Control.Location = new Point(3, 3);
            up103Control.Size = new Size(946, 355);
            FLP.Controls.Add(up103Control);
        }

        public void RemoveFromCart(Up103 controlToRemove)
        {
            FLP.Controls.Remove(controlToRemove);
            removedControls.Add(controlToRemove);
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

        private void Cart_Load(object sender, EventArgs e)
        {
            foreach (var control in removedControls)
            {
                FLP.Controls.Add(control);
            }

        }





        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Cart_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void Cart_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = new Point(e.Location.X - lastMousePosition.X, e.Location.Y - lastMousePosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastMousePosition = e.Location;
            }
        }

        private void Cart_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            products ok = new products();
            ok.Show();
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
            Home home = new Home();
            home.Show();
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home ok = new Home();
            ok.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Contact wkwk = new Contact();
            wkwk.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

           
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}


using System.Windows.Forms;
using System.Diagnostics;

using static System.Windows.Forms.Design.AxImporter;

namespace wfdbig
{
    public partial class P103 : Form


    {
        private bool isDragging;
        private Point lastMousePosition;
        private Color originalLabelColor;
        private int remainingSeconds = 30 * 24 * 60 * 60;




        public P103()
        {
            InitializeComponent();
          



            this.MouseDown += P103_MouseDown;
            this.MouseMove += P103_MouseMove;
            this.MouseUp += P103_MouseUp;

            pictureBox1.BackColor = Color.Transparent;

            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;


            label41.ForeColor = Color.Transparent;
            label57.ForeColor = Color.Transparent;

            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;


            pagesToolStripMenuItem.MouseHover += pagesToolStripMenuItem_MouseHover;
            pagesToolStripMenuItem.MouseLeave += pagesToolStripMenuItem_MouseLeave;




            pictureBox3.Click += MinimizePictureBox_Click;
            pictureBox2.Click += MaximizePictureBox_Click;

            pictureBox5.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
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

        private void P103_Load(object sender, EventArgs e)
        {


        }





        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {

        }

        private void P103_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void P103_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = new Point(e.Location.X - lastMousePosition.X, e.Location.Y - lastMousePosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastMousePosition = e.Location;
            }
        }

        private void P103_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
          P103 P103Form = new P103();
          P103Form.Show();
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

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label57.ForeColor = Color.Red;
            label56.ForeColor = Color.Transparent;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label57.ForeColor = Color.Transparent;
            label56.ForeColor = Color.Red;
        }



        private void pagesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            pagesToolStripMenuItem.ShowDropDown();
        }

        private void pagesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pagesToolStripMenuItem.HideDropDown();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = true;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dowm_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(txtq.Text);
            currentValue++;
            txtq.Text = currentValue.ToString();
        }

        private void up_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(txtq.Text);
            currentValue--;
            if (currentValue >= 0)
                txtq.Text = currentValue.ToString();
        }

        private void txtq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = true;
            pictureBox13.Visible = false;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label56.ForeColor = Color.Transparent;
            label41.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label56.ForeColor = Color.Red;
            label41.ForeColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;



            button1.ForeColor = Color.White;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;



            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Transparent;



            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Black;



            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.White;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item added to cart successfully!");
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cart ok = new Cart();
            ok.Show();
            this.Hide();
        }
    }
}


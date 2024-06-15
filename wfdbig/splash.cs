using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wfdbig
{

    public partial class splash : Form
    {

      //  private SoundPlayer player;
        public splash()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            timer1.Start();

            timer2.Interval = 3000;

            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;

           //  player = new SoundPlayer(@"A:\4th sem\w.deal\sound\home.wav");

        }

        private void splash_Load(object sender, EventArgs e)

        {
           // player.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            pictureBox3.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GS GO = new GS();
            GO.Show();
          
        }
    }
}

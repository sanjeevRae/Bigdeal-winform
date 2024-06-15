using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfdbig
{
    public partial class Admin_control : Form
    {
        public Admin_control()
        {
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Done_MouseEnter(object sender, EventArgs e)
        {
            Done.BackColor = Color.Black;
            Done.ForeColor = Color.White;
        }

        private void Done_MouseLeave(object sender, EventArgs e)
        {
            Done.BackColor = Color.White;
            Done.ForeColor = Color.Black;
        }

        private void Done_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label13.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label16.Visible = false;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            label18.Visible = false;
        }

        private void ACPlblPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACPlblMU_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
            label22.Visible = false;
        }

        private void ACPlblC_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACPTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACPStyle_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACPRs_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACPARs_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACPTitle_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void ACPStyle_Click(object sender, EventArgs e)
        {
            label13.Visible = false;
        }

        private void ACPRs_Click(object sender, EventArgs e)
        {
            label14.Visible = false;
        }

        private void ACPARs_Click(object sender, EventArgs e)
        {
            label16.Visible = false;
        }

        private void ACPlblPI_Click(object sender, EventArgs e)
        {
            label18.Visible = false;
        }

        private void ACPlblMU_Click(object sender, EventArgs e)
        {
            label20.Visible = false;
        }

        private void ACPlblC_Click(object sender, EventArgs e)
        {
            label22.Visible = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            label20.Visible = false;
        }

        private void Admin_control_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

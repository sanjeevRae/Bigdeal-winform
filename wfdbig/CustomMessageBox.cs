using System;
using System.Drawing;
using System.Windows.Forms;

namespace wfdbig
{
    public partial class CustomMessageBox : Form
    {
        private Form _shippingForm;

        public CustomMessageBox(string heading, string subheading, Form shippingForm)
        {
            InitializeComponent();
            lblHeading.Text = heading;
            lblSubheading.Text = subheading;
            _shippingForm = shippingForm;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            if (_shippingForm != null)
            {
                _shippingForm.Hide();
            }

            this.Hide();
            Home yeosin = new Home();
            yeosin.Show();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Red;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}

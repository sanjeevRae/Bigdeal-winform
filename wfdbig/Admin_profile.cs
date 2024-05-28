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
    public partial class Admin_profile : UserControl
    {
        private Admin adminForm;
        public Admin_profile()
        {
            InitializeComponent();
           

            profile.Visible = false;
        }

        public void SetAdminForm(Admin admin)
        {
            adminForm = admin;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void blEditProfilePic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select a Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);
                    ProfilePic.Image = selectedImage;

                    if (adminForm != null)
                    {
                        adminForm.SetAdminPic(selectedImage);
                    }
                    else
                    {
                        MessageBox.Show("Admin form reference is not set.");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            profile.Visible = true;
        }
    }
}

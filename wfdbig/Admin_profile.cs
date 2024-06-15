using System;
using System.Drawing;
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
        public string AdminName
        {
            get => txtAdminName.Text;
            set => txtAdminName.Text = value;
        }

        private void txtAdminName_TextChanged(object sender, EventArgs e)
        {
            adminForm?.UpdateAdminNameInLabels(txtAdminName.Text);
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

                    adminForm?.SetAdminPic(selectedImage);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            profile.Visible = true;
        }

        private void txtAdminName_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
            txtAdminName.ReadOnly = false;
            label5.Visible = false;
        }

        private void txtAdminName_TextChanged_1(object sender, EventArgs e)
        {
            adminForm?.UpdateAdminNameInLabels(txtAdminName.Text);
        }
    }
}

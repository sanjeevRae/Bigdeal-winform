using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.Design.AxImporter;
using wfdbig;
using System.Transactions;
using wfdbig.Properties;

namespace wfdbig
{
    public partial class Admin : Form


    {
        private bool isDragging;
        private Point lastMousePosition;
        private Size originalPictureBoxSize;
        private Color originalLabelColor;

        private Admin_dash_top admin_dash_top;
        private Admin_project_top admin_project_top;
        private Admin_sale_top admin_sale_top;
        private Admin_settings_top admin_settings_top;
        private Admin_transaction_top admin_transaction_top;
     

        private Dashboard dashboard;
        private Projects projects;
        private Salesoverview salesoverview;
        private Settings settings;
        private Transaction transaction;
        private Admin_profile admin_profile;
       



        public Admin()
        {
            InitializeComponent();


            this.MouseDown += Admin_MouseDown;
            this.MouseMove += Admin_MouseMove;
            this.MouseUp += Admin_MouseUp;

            pictureBox1.BackColor = Color.Transparent;

            pictureBox3.Click += MinimizePictureBox_Click;
            pictureBox2.Click += MaximizePictureBox_Click;

            Dashboard2.Visible = true;
            Project2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;


            admin_dash_top = new Admin_dash_top();
            admin_project_top = new Admin_project_top();
            admin_sale_top = new Admin_sale_top();
            admin_settings_top = new Admin_settings_top();
            admin_transaction_top = new Admin_transaction_top();
            


            dashboard = new Dashboard();
            projects = new Projects();
            salesoverview = new Salesoverview();
            settings = new Settings();
            transaction = new Transaction();
            admin_profile = new Admin_profile();

          


            panel5.Controls.Add(admin_dash_top);
            panel5.Controls.Add(admin_project_top);
            panel5.Controls.Add(admin_sale_top);
            panel5.Controls.Add(admin_settings_top);
            panel5.Controls.Add(admin_transaction_top);

            panel7.Controls.Add(dashboard);
            panel7.Controls.Add(projects);
            panel7.Controls.Add(salesoverview);
            panel7.Controls.Add(settings);
            panel7.Controls.Add(transaction);
            panel7.Controls.Add(admin_profile);

            ShowUserControls("Dashboard");

            admin_profile.SetAdminForm(this);



        }

        public void UpdateAdminNameInLabels(string adminName)
        {
            admin_dash_top.UpdateAdminName(adminName);
          
            admin_project_top.UpdateAdminName(adminName);
            admin_sale_top.UpdateAdminName(adminName);
            admin_settings_top.UpdateAdminName(adminName);
            admin_transaction_top.UpdateAdminName(adminName);

            lblAdmin.Text = adminName;
        }

        public void SetAdminPic(Image image)
        {
            AdminPic.Image = image;
        }

        private void ShowUserControls(string controlName)
        {
            admin_dash_top.Visible = false;
            admin_project_top.Visible = false;
            admin_sale_top.Visible = false;
            admin_settings_top.Visible = false;
            admin_transaction_top.Visible = false;


            dashboard.Visible = false;
            projects.Visible = false;
            salesoverview.Visible = false;
            settings.Visible = false;
            transaction.Visible = false;
            admin_profile.Visible = false;


            switch (controlName)
            {
                case "Dashboard":
                    admin_dash_top.Visible = true;
                    dashboard.Visible = true;
                    break;

                case "Projects":
                    admin_project_top.Visible = true;
                    projects.Visible = true;
                    break;

                case "Salesoverview":
                    admin_sale_top.Visible = true;
                    salesoverview.Visible = true;
                    break;

                case "Transaction":
                    admin_transaction_top.Visible = true;
                    transaction.Visible = true;
                    break;

                case "Settings":
                    admin_settings_top.Visible = true;
                    settings.Visible = true;
                    break;

                case "Admin_profile":
                    admin_settings_top.Visible = true;
                    admin_profile.Visible = true;
                    break;
            }
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

        private void Admin_Load(object sender, EventArgs e)
        {


        }





        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void Admin_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = new Point(e.Location.X - lastMousePosition.X, e.Location.Y - lastMousePosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastMousePosition = e.Location;
            }
        }

        private void Admin_MouseUp(object sender, MouseEventArgs e)
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
            //Home home = new Home();
            //home.Show();
            //this.Hide();
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

        private void Dashboard2_MouseEnter(object sender, EventArgs e)
        {

            Project2.Visible = false;
            Dashboard2.Visible = true;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;

        }

        private void Dashboard2_MouseLeave(object sender, EventArgs e)
        {



        }

        private void Dashboard1_MouseEnter(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = true;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;

        }

        private void Dashboard1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Project2_Click(object sender, EventArgs e)
        {
            Project2.Visible = true;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;

            ShowUserControls("Projects");

        }

        private void Project1_MouseEnter(object sender, EventArgs e)
        {
            Project2.Visible = true;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;

        }

        private void Project1_MouseLeave(object sender, EventArgs e)
        {


        }

        private void Project1_Click(object sender, EventArgs e)
        {

        }

        private void Salesoverview1_MouseEnter(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = true;
            Transaction2.Visible = false;


        }

        private void Salesoverview1_Click(object sender, EventArgs e)
        {



        }

        private void Salesoverview2_Click(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = true;
            Transaction2.Visible = false;

            ShowUserControls("Salesoverview");




        }

        private void Salesoverview2_MouseEnter(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = true;
            Transaction2.Visible = false;


        }

        private void transaction1_MouseEnter(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = true;


        }

        private void Transaction2_MouseEnter(object sender, EventArgs e)
        {

            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = true;


        }

        private void Transaction2_Click(object sender, EventArgs e)
        {

            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = true;

            ShowUserControls("Transaction");





        }

        private void Invoice2_MouseEnter(object sender, EventArgs e)
        {


        }

        private void Invoice2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Invoice2_Click(object sender, EventArgs e)
        {


        }

        private void Invoice1_MouseEnter(object sender, EventArgs e)
        {


        }

        private void Customer2_Click(object sender, EventArgs e)
        {


        }

        private void Customer2_MouseEnter(object sender, EventArgs e)
        {


        }

        private void Customer1_MouseEnter(object sender, EventArgs e)
        {


        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Project_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard2_Click(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = true;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;

            ShowUserControls("Dashboard");
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            sign ok = new sign();
            ok.Show();
            this.Hide();
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox56_MouseEnter(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;

        }

        private void pictureBox56_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Enter(object sender, EventArgs e)
        {

        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel17_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel17_Click(object sender, EventArgs e)
        {
            Home ok = new Home();
            ok.Show();
            this.Hide();
        }

        private void panel16_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;

            ShowUserControls("Settings");

        }

        private void pictureBox58_MouseEnter(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;
            pictureBox57.Visible = false;
            panel17.Visible = true;
        }

        private void pictureBox58_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;
            pictureBox57.Visible = true;
            panel17.Visible = false;
        }

        private void panel15_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Click(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;

        }

        private void panel17_MouseEnter_1(object sender, EventArgs e)
        {
            Project2.Visible = false;
            Dashboard2.Visible = false;
            Salesoverview2.Visible = false;
            Transaction2.Visible = false;

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            ShowUserControls("Admin_profile");
        }
    }
}


    
    

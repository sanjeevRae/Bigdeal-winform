namespace wfdbig
{
    partial class sms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sms));
            txtEmail = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SendOTP = new Button();
            VerifyOTP = new Button();
            button4 = new Button();
            label2 = new Label();
            txtVerify = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            useremail = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            txtusername = new TextBox();
            txtPassword = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ImeMode = ImeMode.On;
            txtEmail.Location = new Point(61, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 32);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(52, 133);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(646, 159);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // SendOTP
            // 
            SendOTP.BackColor = Color.Black;
            SendOTP.Cursor = Cursors.Hand;
            SendOTP.Font = new Font("Segoe UI", 11F);
            SendOTP.ForeColor = Color.White;
            SendOTP.Location = new Point(51, 387);
            SendOTP.Name = "SendOTP";
            SendOTP.Size = new Size(354, 55);
            SendOTP.TabIndex = 3;
            SendOTP.Text = "Sign up";
            SendOTP.UseVisualStyleBackColor = false;
            SendOTP.Click += button2_Click;
            // 
            // VerifyOTP
            // 
            VerifyOTP.BackColor = Color.Black;
            VerifyOTP.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VerifyOTP.ForeColor = Color.White;
            VerifyOTP.Location = new Point(83, 530);
            VerifyOTP.Name = "VerifyOTP";
            VerifyOTP.Size = new Size(344, 60);
            VerifyOTP.TabIndex = 7;
            VerifyOTP.Text = "Verify OTP";
            VerifyOTP.UseVisualStyleBackColor = false;
            VerifyOTP.Click += VerifyOTP_Click;
            VerifyOTP.Paint += VerifyOTP_Paint;
            // 
            // button4
            // 
            button4.Location = new Point(240, 295);
            button4.Name = "button4";
            button4.Size = new Size(8, 8);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 266);
            label2.Name = "label2";
            label2.Size = new Size(492, 37);
            label2.TabIndex = 5;
            label2.Text = "One Time Password (OTP) has been sent via Email to ";
            // 
            // txtVerify
            // 
            txtVerify.BackColor = Color.White;
            txtVerify.BorderStyle = BorderStyle.FixedSingle;
            txtVerify.Cursor = Cursors.IBeam;
            txtVerify.Font = new Font("Segoe UI", 16F);
            txtVerify.Location = new Point(182, 389);
            txtVerify.Multiline = true;
            txtVerify.Name = "txtVerify";
            txtVerify.Size = new Size(151, 55);
            txtVerify.TabIndex = 4;
            txtVerify.TextChanged += txtVerify_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(useremail);
            panel1.Controls.Add(VerifyOTP);
            panel1.Controls.Add(txtVerify);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(761, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 665);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS PGothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(142, 175);
            label3.Name = "label3";
            label3.Size = new Size(225, 28);
            label3.TabIndex = 10;
            label3.Text = "OTP Verification";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // useremail
            // 
            useremail.AutoSize = true;
            useremail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            useremail.Location = new Point(148, 306);
            useremail.Name = "useremail";
            useremail.Size = new Size(100, 28);
            useremail.TabIndex = 8;
            useremail.Text = "useremail";
            useremail.Click += useremail_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(170, 197, 188);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 772);
            panel2.TabIndex = 9;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(334, 656);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 61);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(501, 277);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(119, 107);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(257, 656);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(106, 558);
            label5.Name = "label5";
            label5.Size = new Size(462, 60);
            label5.TabIndex = 2;
            label5.Text = "Create an account to unlock access to amazing\r\n        deals and a wide range of products.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(160, 482);
            label4.Name = "label4";
            label4.Size = new Size(317, 45);
            label4.TabIndex = 1;
            label4.Text = "Join BigDeal Today!";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(109, -31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(459, 524);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(905, 91);
            label6.Name = "label6";
            label6.Size = new Size(211, 34);
            label6.TabIndex = 10;
            label6.Text = "Create account";
            label6.Click += label6_Click;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI", 12F);
            txtusername.Location = new Point(56, 63);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(288, 32);
            txtusername.TabIndex = 11;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(56, 284);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(289, 32);
            txtPassword.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.FromArgb(55, 43, 37);
            label7.Location = new Point(52, 21);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 13;
            label7.Text = "Name";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(52, 242);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 14;
            label8.Text = "Password";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtusername);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(SendOTP);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(761, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(478, 613);
            panel3.TabIndex = 16;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(369, 276);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(370, 276);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 21;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(279, 497);
            label14.Name = "label14";
            label14.Size = new Size(107, 25);
            label14.TabIndex = 19;
            label14.Text = "Log in here";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Cursor = Cursors.Hand;
            label13.Location = new Point(73, 497);
            label13.Name = "label13";
            label13.Size = new Size(189, 25);
            label13.TabIndex = 18;
            label13.Text = "Already have account?";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(52, 299);
            label12.Name = "label12";
            label12.Size = new Size(348, 28);
            label12.TabIndex = 17;
            label12.Text = "__________________________________________";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(51, 78);
            label11.Name = "label11";
            label11.Size = new Size(348, 28);
            label11.TabIndex = 16;
            label11.Text = "__________________________________________";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(52, 188);
            label10.Name = "label10";
            label10.Size = new Size(348, 28);
            label10.TabIndex = 15;
            label10.Text = "__________________________________________";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(921, 77);
            label9.Name = "label9";
            label9.Size = new Size(0, 38);
            label9.TabIndex = 17;
            // 
            // sms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1314, 772);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sms";
            Load += sms_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private Button button1;
        private Button SendOTP;
        private Button VerifyOTP;
        private Button button4;
        private Label label2;
        private TextBox txtVerify;
        private Panel panel1;
        private Label useremail;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtusername;
        private TextBox txtPassword;
        private Label label7;
        private Label label8;
        private Panel panel3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}
namespace wfdbig
{
    partial class Admin_settings_top
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dashboard_top = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            settings_admin = new Label();
            label1 = new Label();
            label28 = new Label();
            dashboard_top.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dashboard_top
            // 
            dashboard_top.Controls.Add(flowLayoutPanel1);
            dashboard_top.Controls.Add(label28);
            dashboard_top.Location = new Point(8, 8);
            dashboard_top.Name = "dashboard_top";
            dashboard_top.Size = new Size(1302, 214);
            dashboard_top.TabIndex = 35;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(settings_admin);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(35, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(954, 53);
            flowLayoutPanel1.TabIndex = 37;
            // 
            // settings_admin
            // 
            settings_admin.AutoSize = true;
            settings_admin.Cursor = Cursors.Hand;
            settings_admin.Font = new Font("Tw Cen MT", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settings_admin.ForeColor = Color.DimGray;
            settings_admin.Location = new Point(3, 0);
            settings_admin.Name = "settings_admin";
            settings_admin.Size = new Size(103, 30);
            settings_admin.TabIndex = 36;
            settings_admin.Text = "@Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Tw Cen MT", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(112, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 30);
            label1.TabIndex = 36;
            label1.Text = "We're thrilled to have you here!";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Cursor = Cursors.Hand;
            label28.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(23, 23);
            label28.Name = "label28";
            label28.Size = new Size(184, 51);
            label28.TabIndex = 35;
            label28.Text = "Settings";
            // 
            // Admin_settings_top
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dashboard_top);
            Location = new Point(291, 6);
            Name = "Admin_settings_top";
            Size = new Size(1302, 214);
            dashboard_top.ResumeLayout(false);
            dashboard_top.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboard_top;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label settings_admin;
        private Label label1;
        private Label label28;
    }
}

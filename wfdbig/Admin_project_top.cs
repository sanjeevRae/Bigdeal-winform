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
    public partial class Admin_project_top : UserControl
    {
        public Admin_project_top()
        {
            InitializeComponent();
        }

        public void UpdateAdminName(string adminName)
        {
            project_admin.Text = adminName;
        }
    }
}

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
    public partial class Admin_settings_top : UserControl
    {
        public Admin_settings_top()
        {
            InitializeComponent();
        }

        public void UpdateAdminName(string adminName)
        {
           settings_admin.Text = adminName;
        }
    }
}

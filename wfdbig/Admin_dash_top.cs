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
    public partial class Admin_dash_top : UserControl
    {
        public Admin_dash_top()
        {
            InitializeComponent();
        }
        public void UpdateAdminName(string adminName)
        {
            dash_admin.Text = adminName;
        }
    }
}

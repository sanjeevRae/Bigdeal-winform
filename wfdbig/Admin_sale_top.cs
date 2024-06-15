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
    public partial class Admin_sale_top : UserControl
    {
        public Admin_sale_top()
        {
            InitializeComponent();
        }

        public void UpdateAdminName(string adminName)
        {
           sales_admin.Text = adminName;
        }
    }
}

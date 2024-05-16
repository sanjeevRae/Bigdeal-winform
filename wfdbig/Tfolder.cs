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
    public partial class Tfolder : Form
    {
        public Tfolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.ToLower(); // Get the text from the TextBox and convert it to lowercase for case-insensitivity

            if (userInput == "apple")
            {
                panel1.Visible = true;  // Show panel1
                panel2.Visible = false; // Hide panel2
            }
            else if (userInput == "banana")
            {
                panel1.Visible = false; // Hide panel1
                panel2.Visible = true;  // Show panel2
            }
            else
            {
                // Handle other cases here
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using wfdbig.Properties;
using wfdbig;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace wfdbig
{
    public partial class Cart : Form
    {
        private bool isDragging;
        private Point lastMousePosition;

        private List<UserControl> cartControls = new List<UserControl>();
        private HashSet<string> productIdsInCart = new HashSet<string>();
        private string connectionString = "server=localhost;user=root;database=bigdeal;port=3306;password=@Mysqlserver;";


        public Cart()
        {
            InitializeComponent();

            this.MouseDown += Cart_MouseDown;
            this.MouseMove += Cart_MouseMove;
            this.MouseUp += Cart_MouseUp;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;

            label56.ForeColor = Color.Transparent;
            label57.ForeColor = Color.Transparent;


            AddUp103ToCart();
            AddUp101ToCart();
            AddUp102ToCart();
            LoadCartState();





        }

        public void RemoveUserControlFromCart(UserControl controlToRemove)
        {
            FLP.Controls.Remove(controlToRemove);
            cartControls.Remove(controlToRemove);
            UpdateTotalPrice();
            RefreshTotalQuantity();

            if (controlToRemove is IProductIdentifier productIdentifier)
            {
                productIdsInCart.Remove(productIdentifier.ProductId);
                SaveCartState();
            }
        }



        private void SaveCartState()
        {

            using (StreamWriter writer = new StreamWriter("cart_state.txt"))
            {
                foreach (string productId in productIdsInCart)
                {
                    writer.WriteLine(productId);
                }
            }
        }


        private void LoadCartState()
        {
            if (File.Exists("cart_state.txt"))
            {
                using (StreamReader reader = new StreamReader("cart_state.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        AddProductToCart(line);
                    }
                }

                RefreshTotalQuantity();
                UpdateTotalPrice();
            }
        }

        public void AddProductToCart(string productId)
        {
            if (!productIdsInCart.Contains(productId))
            {
                switch (productId)
                {
                    case "P101":
                        AddUp101ToCart();
                        break;
                    case "P102":
                        AddUp102ToCart();
                        break;
                    case "P103":
                        AddUp103ToCart();
                        break;

                }

                productIdsInCart.Add(productId);
                SaveCartState();

                RefreshTotalQuantity();
                UpdateTotalPrice();
            }
        }




        public void AddUp101ToCart()
        {
            Up101 up101Control = new Up101(this);
            AddControlToCart(up101Control);
        }

        public void AddUp102ToCart()
        {
            Up102 up102Control = new Up102(this);
            AddControlToCart(up102Control);
        }

        public void AddUp103ToCart()
        {
            Up103 up103Control = new Up103(this);
            AddControlToCart(up103Control);
        }

        private void AddControlToCart(UserControl control)
        {
            control.Location = new Point(3, 3);
            control.Size = new Size(946, 355);
            FLP.Controls.Add(control);
            cartControls.Add(control);
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            products ok = new products();
            ok.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            string url = "https://sanjeevrae.github.io/v1/";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label56.ForeColor = Color.Red;
            label41.ForeColor = Color.Transparent;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label56.ForeColor = Color.Transparent;
            label41.ForeColor = Color.Red;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label57.ForeColor = Color.Red;
            label41.ForeColor = Color.Transparent;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label57.ForeColor = Color.Transparent;
            label41.ForeColor = Color.Red;
        }

        private void pagesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            pagesToolStripMenuItem.ShowDropDown();
        }

        private void pagesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pagesToolStripMenuItem.HideDropDown();
        }

        private void Cart_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void Cart_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = new Point(e.Location.X - lastMousePosition.X, e.Location.Y - lastMousePosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastMousePosition = e.Location;
            }
        }

        private void Cart_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        public void UpdateTotalPrice()
        {

            int totalPrice = cartControls.OfType<IPriceCalculator>().Sum(c => c.TotalPrice);


            alltotal.Text = $"Rs {totalPrice}";

            DatabaseHelper.UpdateTotalPrice(totalPrice);
        }



        private void cartgo(object sender, EventArgs e)
        {

        }

        public void RefreshTotalQuantity()
        {
            int totalQuantity = cartControls.OfType<IQuantityCounter>().Sum(c => c.QuantityValue);
            shtq.Text = $"{totalQuantity} items";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cart OK = new Cart();
            OK.Show();
            this.Hide();
        }

        public interface IQuantityCounter
        {
            int QuantityValue { get; }
        }

        public interface IPriceCalculator
        {
            int TotalPrice { get; }
        }

        public interface IProductIdentifier
        {
            string ProductId { get; }
        }

        private void up101_CheckBoxChecked(object sender, EventArgs e)
        {
            Up101 up101 = sender as Up101;
            if (up101 != null)
            {
                string productName = up101.ProductName;
                string price = up101.Price;

            }
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            int totalPrice = DatabaseHelper.GetTotalPrice();

        }

        private void okok_Click(object sender, EventArgs e)
        {
            Shipping shippingForm = new Shipping();

            foreach (var control in cartControls)
            {
                if (control is Up101 up101)
                {
                    string productName = up101.ProductName;
                    string price = up101.Price;
                    shippingForm.SetItem1P(productName);
                    shippingForm.SetItem1(price);
                }
                else if (control is Up102 up102)
                {
                    string productName = up102.ProductName;
                    string price = up102.Price;
                    shippingForm.SetItem2P(productName);
                    shippingForm.SetItem2(price);
                }
                else if (control is Up103 up103)
                {
                    string productName = up103.ProductName;
                    string price = up103.Price;
                    shippingForm.SetItem3P(productName);
                    shippingForm.SetItem3(price);
                }
            }

            shippingForm.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ok = new About();
            ok.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sign OK = new sign();
            OK.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void voucher_Click(object sender, EventArgs e)
        {
            voucher.Visible = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            voucher.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "HAPPY DEAL 2024")
            {
                MessageBox.Show("You good to go");
            }
            else
            {
                MessageBox.Show("⚠️ Wrong or Expired Voucher Please Try Again Later !!");
            }
        }
    }
}

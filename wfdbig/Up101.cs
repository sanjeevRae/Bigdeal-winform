using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static wfdbig.Cart;

namespace wfdbig
{
    public partial class Up101 : UserControl, IQuantityCounter, IPriceCalculator, IProductIdentifier
    {
        private string connectionString = "server=localhost;user=root;database=bigdeal;port=3306;password=@Mysqlserver;";
        private Cart cartForm;
        private string productId;
        public event EventHandler<EventArgs> CheckBoxChecked;


        public string ProductName 
        { 
            get
            { 
                return lblpname1.Text;
            } 
        }

        public string Price
        { 
            get
            { 
                return txtPrice.Text; 
            } 
        }


        public Up101(Cart cartForm)
        {
            InitializeComponent();
            this.cartForm = cartForm;

            txtq.Text = "1";
            up.Enabled = false;
            dowm.Enabled = false;

            productId = "P101";
            UpdatePrice();
        }

        public int QuantityValue
        {
            get { return cb.Checked ? int.Parse(txtq.Text) : 0; }
        }

        public int TotalPrice
        {
            get { return cb.Checked ? GetProductPrice(productId) * QuantityValue : 0; }
        }

        public string ProductId
        {
            get { return productId; }
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cb.Checked;
            up.Enabled = isChecked;
            dowm.Enabled = isChecked;

            if (isChecked)
            {
                UpdateProductNameAndPrice();
                CheckBoxChecked?.Invoke(this, EventArgs.Empty); 
            }
            else
            {
                lblpname1.Text = string.Empty;
            }

            UpdatePrice();
        }

        private void UpdateProductNameAndPrice()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT P_name, P_price FROM product WHERE P_id = @ProductId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            lblpname1.Text = reader["P_name"].ToString();
                            txtPrice.Text = reader["P_price"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Product details not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching product details: {ex.Message}");
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        private void UpdateQuantity()
        {
            cartForm.RefreshTotalQuantity();
            cartForm.UpdateTotalPrice();
        }

        private void UpdatePrice()
        {
            UpdateQuantity();
            txtPrice.Text = TotalPrice.ToString();
        }

        private int GetProductPrice(string productId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT P_price FROM product WHERE P_id = @ProductId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int price))
                        {
                            return price;
                        }
                        else
                        {
                            MessageBox.Show("Product price not found or invalid.");
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching product price: {ex.Message}");
                Console.WriteLine($"Exception: {ex.Message}");
                return 0;
            }
        }

        private void UpdateProductName()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT P_name FROM product WHERE P_id = @ProductId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            lblpname1.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Product name not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching product name: {ex.Message}");
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        private void PassValuesToShippingForm()
        {
            string productName = lblpname1.Text;
            string price = txtPrice.Text;

            Shipping shippingForm = new Shipping();
            shippingForm.SetItem1P(productName);
            shippingForm.SetItem1(price);

            if (!shippingForm.Visible)
            {
                shippingForm.Show();
            }
        }

        private void inc(object sender, EventArgs e)
        {
            int currentValue = int.Parse(txtq.Text);
            if (currentValue < 10)
            {
                txtq.Text = (currentValue + 1).ToString();
                UpdatePrice();
            }
        }

        private void dec(object sender, EventArgs e)
        {
            int currentValue = int.Parse(txtq.Text);
            if (currentValue > 1)
            {
                txtq.Text = (currentValue - 1).ToString();
                UpdatePrice();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null && parentForm is Cart cartForm)
            {
                cartForm.RemoveUserControlFromCart(this);
            }
        }
    }
}

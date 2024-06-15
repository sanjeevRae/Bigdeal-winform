using System;
using MySql.Data.MySqlClient;

namespace wfdbig
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "server=localhost;user=root;database=bigdeal;port=3306;password=@Mysqlserver;";

        public static void UpdateTotalPrice(int totalPrice)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE `order` SET `total` = @Total WHERE `oid` = 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Total", totalPrice);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Total price updated successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating total in database: " + ex.Message);
                }
            }
        }

        public static int GetTotalPrice()
        {
            int totalPrice = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT `total` FROM `order` WHERE `oid` = 1";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        totalPrice = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error retrieving total price: " + ex.Message);
                }
            }

            return totalPrice;
        }
    }
}

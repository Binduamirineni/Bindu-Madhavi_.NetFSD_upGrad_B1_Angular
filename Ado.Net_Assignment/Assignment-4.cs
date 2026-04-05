using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace OrderManagementSystem
{
    class Program
    {
        static string cs = @"Data Source=DESKTOP-3MDBT1A\SQLEXPRESS;Initial Catalog=NewPracticeDb;Integrated Security=True;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                // 1️⃣ Insert into Orders
                Console.Write("Enter Customer Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Total Amount: ");
                decimal total = decimal.Parse(Console.ReadLine());

                string orderQuery = "INSERT INTO Orders (CustomerName, TotalAmount) VALUES (@Name, @Total); SELECT SCOPE_IDENTITY();";

                SqlCommand orderCmd = new SqlCommand(orderQuery, con, transaction);
                orderCmd.Parameters.AddWithValue("@Name", name);
                orderCmd.Parameters.AddWithValue("@Total", total);

                // Get OrderId
                int orderId = Convert.ToInt32(orderCmd.ExecuteScalar());

                Console.WriteLine("Order Created with ID: " + orderId);

                // 2️⃣ Insert multiple OrderItems
                Console.Write("Enter number of items: ");
                int count = int.Parse(Console.ReadLine());

                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"\nItem {i}");

                    Console.Write("Product Name: ");
                    string product = Console.ReadLine();

                    Console.Write("Quantity: ");
                    int qty = int.Parse(Console.ReadLine());

                    string itemQuery = "INSERT INTO OrderItems (OrderId, ProductName, Quantity) VALUES (@OrderId, @Product, @Qty)";

                    SqlCommand itemCmd = new SqlCommand(itemQuery, con, transaction);
                    itemCmd.Parameters.AddWithValue("@OrderId", orderId);
                    itemCmd.Parameters.AddWithValue("@Product", product);
                    itemCmd.Parameters.AddWithValue("@Qty", qty);

                    itemCmd.ExecuteNonQuery();
                }

                // ✅ Commit if everything successful
                transaction.Commit();
                Console.WriteLine("\nTransaction Successful!");
            }
            catch (Exception ex)
            {
                // ❌ Rollback if any error
                transaction.Rollback();
                Console.WriteLine("\nTransaction Failed!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
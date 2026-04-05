using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ProductInventoryDisconnected
{
    class Program
    {
        static string cs = @"Data Source=DESKTOP-3MDBT1A\SQLEXPRESS;Initial Catalog=NewPracticeDb;Integrated Security=True;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(cs);

            // DataAdapter + DataSet
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products", con);

            // Command Builder (auto generates Insert/Update/Delete commands)
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataSet ds = new DataSet();

            // 1️⃣ Load data into DataSet
            adapter.Fill(ds, "Products");

            DataTable table = ds.Tables["Products"];

            // 2️⃣ Display data
            Console.WriteLine("\n--- Initial Data ---");
            Display(table);

            // 3️⃣ Add new product (OFFLINE)
            DataRow newRow = table.NewRow();
            newRow["ProductName"] = "Laptop";
            newRow["Price"] = 50000;
            newRow["Stock"] = 10;
            table.Rows.Add(newRow);

            // 4️⃣ Update product price (OFFLINE)
            if (table.Rows.Count > 0)
            {
                table.Rows[0]["Price"] = 9999;
            }

            // 5️⃣ Delete product (OFFLINE)
            if (table.Rows.Count > 1)
            {
                table.Rows[1].Delete();
            }

            Console.WriteLine("\n--- After Changes (Offline) ---");
            Display(table);

            // 6️⃣ Push changes to DB
            adapter.Update(ds, "Products");

            Console.WriteLine("\nChanges saved to database!");
        }

        static void Display(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                // Skip deleted rows
                if (row.RowState != DataRowState.Deleted)
                {
                    Console.WriteLine($"Id:{row["ProductId"]} Name:{row["ProductName"]} Price:{row["Price"]} Stock:{row["Stock"]}");
                }
            }
        }
    }
}
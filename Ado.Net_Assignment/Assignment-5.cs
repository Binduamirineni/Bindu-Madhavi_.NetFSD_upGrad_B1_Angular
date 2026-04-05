using System;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    class Program
    {
        static string cs = @"Data Source=DESKTOP-3MDBT1A\SQLEXPRESS;Initial Catalog=NewPracticeDb;Integrated Security=True;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Library Management System =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View Books");
                Console.WriteLine("3. Update Book");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. Search Book by Name");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        ViewBooks();
                        break;
                    case 3:
                        UpdateBook();
                        break;
                    case 4:
                        DeleteBook();
                        break;
                    case 5:
                        SearchBook();
                        break;
                }

            } while (choice != 6);
        }

        // ✅ ADD BOOK
        static void AddBook()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            string query = "INSERT INTO Books (Title, Author, Price) VALUES (@Title, @Author, @Price)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Author", author);
            cmd.Parameters.AddWithValue("@Price", price);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Book Added Successfully!");
        }

        // ✅ VIEW BOOKS
        static void ViewBooks()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM Books";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- Book List ---");

            while (reader.Read())
            {
                Console.WriteLine($"Id:{reader["BookId"]} Title:{reader["Title"]} Author:{reader["Author"]} Price:{reader["Price"]}");
            }

            con.Close();
        }

        // ✅ UPDATE BOOK
        static void UpdateBook()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Book Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            string query = "UPDATE Books SET Price=@Price WHERE BookId=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows > 0)
                Console.WriteLine("Book Updated!");
            else
                Console.WriteLine("Book Not Found!");
        }

        // ✅ DELETE BOOK
        static void DeleteBook()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Book Id: ");
            int id = int.Parse(Console.ReadLine());

            string query = "DELETE FROM Books WHERE BookId=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows > 0)
                Console.WriteLine("Book Deleted!");
            else
                Console.WriteLine("Book Not Found!");
        }

        // ✅ SEARCH BOOK
        static void SearchBook()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            string query = "SELECT * FROM Books WHERE Title LIKE @Title";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Title", "%" + title + "%");

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- Search Results ---");

            while (reader.Read())
            {
                Console.WriteLine($"Id:{reader["BookId"]} Title:{reader["Title"]} Author:{reader["Author"]} Price:{reader["Price"]}");
            }

            con.Close();
        }
    }
}
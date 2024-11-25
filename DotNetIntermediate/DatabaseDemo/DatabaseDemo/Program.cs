using System;
using System.Data.SqlClient;

namespace DatabaseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=DatabaseDemo; Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(conStr)) // Using ensures proper resource cleanup
            {
                try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO Student (Id, Name) VALUES (1, 'Ram')"; 

                    con.Open();
                    int i = cmd.ExecuteNonQuery(); 
                    Console.WriteLine($"Rows affected: {i}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            } 
        }
    }
}

using Microsoft.Data.SqlClient;
using System;


namespace DatabaseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Dot-Net\\DotNetIntermediate\\DatabaseDemo\\DatabaseDemo\\Databasedemo.mdf;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    con.Open();

                    // CREATE
                    using (SqlCommand insertCmd = con.CreateCommand())
                    {
                        insertCmd.CommandText = "INSERT INTO Student (Id, Name) VALUES (5, 'Hari')";
                        int insertResult = insertCmd.ExecuteNonQuery();
                        if (insertResult > 0)
                        {
                            Console.WriteLine("Data inserted");

                        }
                        else {
                            Console.WriteLine("Data is not inserted");
                        }
                      //  Console.WriteLine($"Insert - Rows affected: {insertResult}");
                    }

                    // READ
                    using (SqlCommand selectCmd = con.CreateCommand())
                    {
                        selectCmd.CommandText = "SELECT Id, Name FROM Student";
                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            Console.WriteLine("Read - Records:");
                            while (reader.Read())
                            {
                                Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}");
                            }
                        }
                    }

                    // UPDATE
                    using (SqlCommand updateCmd = con.CreateCommand())
                    {
                        updateCmd.CommandText = "UPDATE Student SET Name = 'Shyam' WHERE Id = 1";
                        int updateResult = updateCmd.ExecuteNonQuery();
                        Console.WriteLine($"Update - Rows affected: {updateResult}");
                    }

                    // DELETE
                    using (SqlCommand deleteCmd = con.CreateCommand())
                    {
                        deleteCmd.CommandText = "DELETE FROM Student WHERE Id = 1";
                        int deleteResult = deleteCmd.ExecuteNonQuery();
                        Console.WriteLine($"Delete - Rows affected: {deleteResult}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}

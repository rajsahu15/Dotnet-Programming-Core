using System;
using Microsoft.Data.SqlClient;

// Using + for concatenation as requested
string serverName = "localhost\\SQLEXPRESS";
string databaseName = "PracticeModule";

string connectionString = "Server=" + serverName + ";Database=" + databaseName + ";Trusted_Connection=True;TrustServerCertificate=True;";

using (SqlConnection con = new SqlConnection(connectionString))
{
    try
    {
        con.Open();
        Console.WriteLine("Connection Established Successfully to " + databaseName);
    }
    catch (Exception ex)
    {
        // Using + to combine the error message
        Console.WriteLine("Error: " + ex.Message);
    }
}
using System;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        IConfiguration config = builder.Build();
        var connectionString = config.GetConnectionString("crmConnectDb");

        using var connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            Console.WriteLine("Connected Successfully!\n");

            ExecuteNonQuery(connection);
            ExecuteScalar(connection);
            ExecuteReader(connection);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    
    static void ExecuteNonQuery(MySqlConnection connection)
    {
        string insertQuery = "INSERT INTO course (id,course) VALUES (4,'Data Science');";

        using var cmd = new MySqlCommand(insertQuery, connection);
        int rowsAffected = cmd.ExecuteNonQuery();

        Console.WriteLine($"ExecuteNonQuery: {rowsAffected} row(s) inserted.\n");
    }

    // ExecuteScalar (Get Single Value Example)
    static void ExecuteScalar(MySqlConnection connection)
    {
        string countQuery = "SELECT COUNT(*) FROM course;";

        using var cmd = new MySqlCommand(countQuery, connection);
        var result = cmd.ExecuteScalar();

        Console.WriteLine($"ExecuteScalar: Total Courses = {result}\n");
    }

    //  ExecuteReader
    static void ExecuteReader(MySqlConnection connection)
    {
        string selectQuery = "SELECT * FROM course;";

        using var cmd = new MySqlCommand(selectQuery, connection);
        using var reader = cmd.ExecuteReader();

        Console.WriteLine("ExecuteReader: Course Table Data");

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader["id"]}, Course: {reader["course"]}");
        }

        Console.WriteLine();
    }
}

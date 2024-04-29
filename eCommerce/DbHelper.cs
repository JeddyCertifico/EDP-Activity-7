using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

public class DbHelper
{
    private const string connectionString =
        "server=localhost;user=root;database=ecommercedb;port=3307;password=jeddy1234";

    public DbHelper() { }

    public void Create(string query, Dictionary<string, object> parameters = null)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable Read(string query, Dictionary<string, object> parameters = null)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                return dataTable;
            }
        }
    }

    public void Update(string query, Dictionary<string, object> parameters = null)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }
                command.ExecuteNonQuery();
            }
        }
    }

    public void Delete(string query)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }
                return command.ExecuteScalar();
            }
        }
    }

    public MySqlDataReader ExecuteReader(string query, Dictionary<string, object> parameters)
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand command = new MySqlCommand(query, connection);
        connection.Open();
        foreach (var parameter in parameters)
        {
            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
        }

        return command.ExecuteReader();
    }
}

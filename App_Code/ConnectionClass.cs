using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ConnectionClass
/// </summary>
public static class ConnectionClass

{

    private static SqlConnection conn;
    private static SqlCommand command;

    static ConnectionClass()
    {
        string connectionString = 
            ConfigurationManager.ConnectionStrings["bagsConnection"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }

    public static ArrayList GetBagsByType(string bagType)
    {
        ArrayList list = new ArrayList();
        string query = string.Format("SELECT * FROM Bags WHERE type LIKE '{0}'", bagType);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string type = reader.GetString(2);
                double price = reader.GetDouble(3);

                string image = reader.GetString(4);
                string review = reader.GetString(5);

                Bag bags = new Bag(id, name, type, price, image, review);
                list.Add(bags);
            }
        }
        finally
        {
            conn.Close();
        }

        return list;
    }
	
}
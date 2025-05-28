using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        LoadProductsWithStock();
    }

    static void LoadProductsWithStock()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        string query = "SELECT ProductID, ProductName, UnitsInStock FROM Products WHERE UnitsInStock > 20";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();

            try
            {
                adapter.Fill(dataSet, "Products");

                DataTable table = dataSet.Tables["Products"];

                Console.WriteLine("ProductID   ProductName                        UnitsInStock");
                Console.WriteLine("------------------------------------------------------------");

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"{row["ProductID"],-10} {row["ProductName"],-35} {row["UnitsInStock"],5}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        InsertOrderWithDetails();
    }

    static void InsertOrderWithDetails()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                // Insert into Orders
                SqlCommand insertOrder = new SqlCommand(@"
                    INSERT INTO Orders (CustomerID, OrderDate, ShipCountry)
                    VALUES (@CustomerID, @OrderDate, @ShipCountry);
                    SELECT SCOPE_IDENTITY();", conn, transaction);

                insertOrder.Parameters.AddWithValue("@CustomerID", "ALFKI");
                insertOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                insertOrder.Parameters.AddWithValue("@ShipCountry", "Germany");

                // Get newly inserted OrderID
                int newOrderId = Convert.ToInt32(insertOrder.ExecuteScalar());

                // Insert into Order Details
                SqlCommand insertDetails = new SqlCommand(@"
                    INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
                    VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)", conn, transaction);

                insertDetails.Parameters.AddWithValue("@OrderID", newOrderId);
                insertDetails.Parameters.AddWithValue("@ProductID", 1); // Example ProductID
                insertDetails.Parameters.AddWithValue("@UnitPrice", 25.00m);
                insertDetails.Parameters.AddWithValue("@Quantity", 5);
                insertDetails.Parameters.AddWithValue("@Discount", 0);

                insertDetails.ExecuteNonQuery();

                // All good, commit transaction
                transaction.Commit();
                Console.WriteLine("Order and Order Details inserted successfully.");
            }
            catch (Exception ex)
            {
                // Error occurred, rollback transaction
                transaction.Rollback();
                Console.WriteLine("Transaction failed. Rolled back.");
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
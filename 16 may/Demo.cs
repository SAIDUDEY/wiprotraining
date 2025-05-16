using System.Data.SqlClient;

class SqlConnectionDemo
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection(
            "data source = (localdb)\\MSSQLLocalDB;Initial CAtalog=Northwind;Integrated Security=SSPI");

        SqlDataReader rdr = null;

        try
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from Customers", conn);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[1]);
            }


        }
        catch
        {
        }
        finally
        {
            if (rdr != null)
            {
                rdr.Close();
            }

            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
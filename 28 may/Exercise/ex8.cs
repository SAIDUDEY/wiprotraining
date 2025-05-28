using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the id ");
            string id = Console.ReadLine();

            string CS = "Data Source = (localdb)\\MSSQLLocalDB;DataBase = NorthWind ; Integrated Security = true";

            SqlConnection con = new SqlConnection(CS);

            SqlCommand command = new SqlCommand("CustOrderHist", con);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CustomerID", id);

            try
            {
                con.Open();
                SqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0].ToString().PadRight(20) + rdr[1]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
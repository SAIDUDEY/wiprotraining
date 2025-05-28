using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            string CS = "Data Source = (localdb)\\MSSQLLocalDB;DataBase = NorthWind ; Integrated Security = true";

            string query = "SELECT ORDERID, SUM(UnitPrice * Quantity) AS TotalSales FROM[Order Details] GROUP BY ORDERID";

            SqlConnection conn = new SqlConnection(CS);

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                Console.WriteLine(row[0] + "         " + row[1]);
            }


        }
    }
}
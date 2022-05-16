using System;
using System.Linq;

namespace ECommApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EComm;Integrated Security=True";

            var db = new ECommContext(connStr);

            var suppliers = db.Suppliers.ToList();

            foreach (var s in suppliers) {
                Console.WriteLine(s.CompanyName);
            }

            Console.ReadKey();
        }
    }
}

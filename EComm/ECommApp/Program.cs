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

            var products = db.Products.ToList();

            foreach (var p in products) {
                Console.WriteLine($"{p.ProductName} ({p.UnitPrice})");
            }

            Console.ReadKey();
        }
    }
}


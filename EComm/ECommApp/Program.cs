using Microsoft.EntityFrameworkCore;
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

            var products = db.Products
                .Where(p => p.UnitPrice > 20)
                .Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

            //var p2 = db.Products.Where(p => p.UnitPrice > 20);

            foreach (var p in products) {
                Console.WriteLine($"{p.Name} ({p.Price:C})");
            }

            Console.ReadKey();
        }

      
    }
}


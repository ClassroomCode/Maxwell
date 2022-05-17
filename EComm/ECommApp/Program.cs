using EComm.Abstractions;
using EComm.Infrastructure;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECommApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EComm;Integrated Security=True";

            IRepository db; // = new ECommContext(connStr);

            var products = db.Products
                .Where(p => p.UnitPrice > 20)
                .Select(p => new { Name = p.ProductName, Price = p.UnitPrice })
                .ToList();

            //var p2 = db.Products.Where(p => p.UnitPrice > 20);

            foreach (var p in products) {
                Console.WriteLine($"{p.Name} ({p.Price:C})");
            }

            Console.ReadKey();
        }
    }
}


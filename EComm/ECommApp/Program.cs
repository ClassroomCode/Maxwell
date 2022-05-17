using EComm.Abstractions;
using EComm.Core;
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

            IRepository db = RepositoryFactory.CreateRepository(connStr);

            var products = db.AllProducts();

            var expensiveProducts = products
                .Where(p => p.UnitPrice > 20)
                .Select(p => new MiniProduct { Name = p.ProductName, Price = p.UnitPrice });

            var theProducts = await db.GetResults(expensiveProducts);

            //var p2 = db.Products.Where(p => p.UnitPrice > 20);

            foreach (var p in theProducts) {
                Console.WriteLine($"{p.Name} ({p.Price})");
            }

            Console.ReadKey();
        }
    }
}



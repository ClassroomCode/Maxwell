using EComm.Abstractions;
using EComm.Core;
using EComm.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ECommApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EComm;Integrated Security=True";

            IRepository db = RepositoryFactory.CreateRepository(connStr);

            //var ps = await db.GetAllProducts(includeSupplier: true);

            var p1 = db.AllProducts().Single(p => p.Id == 5);
            Console.WriteLine(p1.ProductName);

            Thread.Sleep(10000);

            var p2 = db.AllProducts().Single(p => p.Id == 5);
            Console.WriteLine(p2.ProductName);

            Console.WriteLine("---------");
            Console.WriteLine($"Same?  {p1 == p2}");

            /*
            var products = db.AllProducts();

            var expensiveProducts = products
                .Where(p => p.UnitPrice > 20)
                .Select(p => new MiniProduct { Name = p.ProductName, Price = p.UnitPrice });

            var theProducts = await db.GetResults(expensiveProducts);

            foreach (dynamic p in theProducts) {
                //var mp = p as MiniProduct;
                Console.WriteLine($"{p.Name} ({p.Price})");
            }
            */
            Console.ReadKey();
        }
    }

    public class MiniProduct
    {
        public string Name { get; set; } = string.Empty;
        public Decimal? Price { get; set; }
    }
}



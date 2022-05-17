using EComm.Abstractions;
using EComm.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Infrastructure
{
    internal class ECommContext : DbContext, IRepository
    {
        private readonly string _connStr;

        public ECommContext(string connStr)
        {
            _connStr = connStr;
        }

        public DbSet<Supplier> Suppliers => Set<Supplier>();
        public DbSet<Product> Products => Set<Product>();

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var retVal = await Products.ToArrayAsync();
            return retVal; 
        }

        public IQueryable<Product> AllProducts() => Products;

        public async Task<IEnumerable<object>> GetResults(IQueryable<object> q)
        {
            IEnumerable<object> retVal = new object[0];
            try {
                retVal = await q.ToArrayAsync();
            }
            catch {
                //
            }
            return retVal;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseSqlServer(_connStr)
                .LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

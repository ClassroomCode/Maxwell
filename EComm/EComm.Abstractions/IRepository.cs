using EComm.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Abstractions
{
    public interface IRepository : IDisposable
    {
        Task<IEnumerable<Product>> GetAllProducts(bool includeSupplier = false);

        IQueryable<Product> AllProducts();

        Task<IEnumerable<object>> GetResults(IQueryable<object> q);

        void Attach(Product product);

        Task Save();
    }
}

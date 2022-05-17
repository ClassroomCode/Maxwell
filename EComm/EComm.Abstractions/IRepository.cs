using EComm.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Abstractions
{
    public interface IRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();

        IQueryable<Product> AllProducts();

        Task<IEnumerable<MiniProduct>> GetResults(IQueryable<MiniProduct> q);
    }
}

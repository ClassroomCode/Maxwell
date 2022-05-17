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
        public Task<IEnumerable<Product>> GetAllProducts();
    }
}

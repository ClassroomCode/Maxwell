using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class Repository
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return DbSet.Where(i => i).ToList();
        }

        public IQueryable<Customer> GetCustomersDef()
        {
            return DbSet.Where(i => i);
        }


    }
}

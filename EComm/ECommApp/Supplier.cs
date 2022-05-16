using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommApp
{
    public class Supplier
    {
        public int Id { get; set; }

        public string CompanyName { get; set; } = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Core
{
    public class Supplier
    {
        public int Id { get; set; }

        public string CompanyName { get; set; } = string.Empty;
        public string? ContactName { get; set; } 
        public string? ContactTitle { get; set; }
        public string? City { get; set; } = string.Empty;
        public string? Country { get; set; }
        public string? Phone { get; set; } 
        public string? Fax { get; set; } 
    }
}

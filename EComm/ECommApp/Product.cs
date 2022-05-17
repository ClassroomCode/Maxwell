using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommApp
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;

        [Column(TypeName ="decimal(12,2)")]
        public Decimal? UnitPrice { get; set; }

        public string? Package { get; set; }
        public bool IsDiscontinued { get; set; }

        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
    }
}



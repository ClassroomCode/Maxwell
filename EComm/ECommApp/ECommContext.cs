﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommApp
{
    public class ECommContext : DbContext
    {
        private readonly string _connStr;

        public ECommContext(string connStr)
        {
            _connStr = connStr;
        }

        public DbSet<Supplier> Suppliers => Set<Supplier>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_connStr);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Vidly.Models;

namespace Oceans.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
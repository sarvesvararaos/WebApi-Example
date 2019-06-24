using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi_Example.Models
{
    public class ProductCommon:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
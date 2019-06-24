using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Example.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Remarks { get; set; }
    }
}
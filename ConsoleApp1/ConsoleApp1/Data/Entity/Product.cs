using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Data.Entity
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsNew { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Data.Entity
{
    internal class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Emaile { get; set; }

    }
}

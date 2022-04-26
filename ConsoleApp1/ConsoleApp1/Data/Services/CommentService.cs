using ConsoleApp1.Data.DAL;
using ConsoleApp1.Data.Entity;
using ConsoleApp1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Data.Services
{
    internal class CommentService
    {
        ShopDbContext db = new ShopDbContext();
        public void SearchByProduct(int number)
        {
            List<Comment> comments = db.Comments.Where(x => x.ProductId==number).ToList(); 
            if (comments.Count > 0) { 
            Console.WriteLine("\n\n=========================== MENU ============================\n");
            foreach (var item in comments)
            {
                Console.WriteLine($"Id:{item.Id}   Product Id:{item.ProductId}   User Id:{item.UserId}   Text:{item.Text}    Create Date:{item.CreateDate}   Name:{item.Name}   Name:{item.Emaile}");
            }
            Console.WriteLine("\n\n");
            }
            else
            {
                throw new NotFoudException("Bu id-li mehsulu commenti yoxdur!!!");
            }

        }
        public void SearchByUser(int number)
        {
            List<Comment> comments = db.Comments.Where(x => x.UserId == number).ToList();
            if (comments.Count > 0)
            {
                Console.WriteLine("\n\n=========================== MENU ============================\n");
                foreach (var item in comments)
                {
                    Console.WriteLine($"Id:{item.Id}   Product Id:{item.ProductId}   User Id:{item.UserId}   Text:{item.Text}    Create Date:{item.CreateDate}   Name:{item.Name}   Name:{item.Emaile}");
                }
                Console.WriteLine("\n\n");
            }
            else
            {
                throw new NotFoudException("Bu id-li userin commenti yoxdur!!!");
            }

        }
        public void Delete ( int number)
        {
            var data = db.Comments.FirstOrDefault(x => x.Id == number);
            if(data != null) 
            { 
            db.Comments.Remove(data);
            db.SaveChanges();
            }
            else
            {
                throw new NotFoudException("Bu id-li comment yoxdur");
            }
        }
        public void SearchDate(DateTime stratDate , DateTime endDate)
        {
            List<Comment> comments = db.Comments.Where(x => x.CreateDate >= stratDate && x.CreateDate<=endDate).ToList();
            if(comments.Count > 0) { 
            Console.WriteLine("\n\n=========================== MENU ============================\n");
            foreach (var item in comments)
            {
                Console.WriteLine($"Id:{item.Id}   Product Id:{item.ProductId}   User Id:{item.UserId}   Text:{item.Text}    Create Date:{item.CreateDate}   Name:{item.Name}   Name:{item.Emaile}");
            }
            Console.WriteLine("\n\n");
            }
            else
            {
                Console.WriteLine("Bu tarix araliginda comment yoxdur !!!");
            }
        }

    }
}

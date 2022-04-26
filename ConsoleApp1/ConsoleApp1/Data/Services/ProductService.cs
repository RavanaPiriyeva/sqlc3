using ConsoleApp1.Data.DAL;
using ConsoleApp1.Data.Entity;
using ConsoleApp1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Data.Services
{
    internal class ProductService
    {
        ShopDbContext db = new ShopDbContext();

        public void AddProduct(string name , int price ,DateTime createdAt )
        {
            List<Product> products = db.Products.Where(x => x.Name==name).ToList();
            bool isNew;
            if (products.Count>0)
            {
                throw new SameNameException("Bu adda product var!!!");
            }
           else  if  (price < 0)
              {
                throw new NegativeNumberException("Price menfi ola bilmez!!!");
               }
            else { 

            if (createdAt.Day == DateTime.Now.Day)
            {
                isNew = true;
            }
            else
            {
                isNew = false;
            }

            Product product = new Product()
            {
                Name = name,
                Price = price,
             CreatedAt = createdAt,
             IsNew = isNew
            };
            db.Products.Add(product);
            db.SaveChanges();
            }
        }

        public void Search(string word)
        {
            List<Product> products = db.Products.Where(x=>x.Name.Contains(word)).ToList();
            if(products.Count > 0) { 
            Console.WriteLine("\n\n=========================== MENU ============================\n");
            foreach (var item in products)
            {
                Console.WriteLine($"Id:{item.Id}   Name:{item.Name}   Price:{item.Price}    Create Date:{item.CreatedAt}   Is new:{item.IsNew}");
            }
            Console.WriteLine("\n\n");
            }
            else
            {
                throw new NotFoudException("Bu adda product yoxdur !!!");
            }

        }
        public double Avg ()
        {
            int sum = 0;
            

            List<Product> products = db.Products.ToList();
            if (products.Count > 0) { 
            foreach(var item in products)
            {
            
                sum = sum + item.Price;
            }
            return (sum / products.Count);
            }
            else
            {
                throw new NotFoudException("Mehsul yoxdur");
            }
        }
    }
}

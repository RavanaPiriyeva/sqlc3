using ConsoleApp1.Data.DAL;
using ConsoleApp1.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Data.Services
{
    internal class UserService
    {
        ShopDbContext db = new ShopDbContext();
        public void GetAll()
        {
            List<User> users = db.Users.ToList();
            Console.WriteLine("\n\n=========================== MENU ============================\n");
            foreach (var user in users)
            {
                Console.WriteLine($"Id:{user.Id}    Full Name:{user.FullName}    Email:{user.Emaile}    Password:{user.Password}");
            }
            Console.WriteLine("\n\n");
        }
    }
}

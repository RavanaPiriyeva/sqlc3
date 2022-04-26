using ConsoleApp1.Data.Services;
using ConsoleApp1.Exceptions;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService product = new ProductService();
            CommentService comment = new CommentService();
            UserService user =new UserService();
            Method method = new Method();
            do { 
            Console.WriteLine("1.Product elave et:");
                Console.WriteLine("2.Productlar uzre axtaris et:");
                Console.WriteLine("3.Secilmis productin commentlerine bax:");
                Console.WriteLine("4.Secilmis userin commentlerine bax:");
                Console.WriteLine("5.Commenti sil:");
                Console.WriteLine("6.Productlarin ortalama qiymetine bax:");
                Console.WriteLine("7.Verilmis 2 tarix araligindaki Commentlere bax");
                Console.WriteLine("8.Userleri goster");

                string checkstr ="";
                int check =method.CheckInt(checkstr);
            switch (check)
            {
                case 1:
                    
                    Console.WriteLine("Ad daxil et:");
                    string productName ="";
                       productName = method.CheckString(productName);
                    Console.WriteLine("Price daxil et:");
                        string productPriceStr = "";
                        int productPrice = method.CheckInt(productPriceStr);
                    Console.WriteLine("Yaranma tarixin daxil et:");
                    string productCreateDateStr="";
                        DateTime productCreateDate = method.CheckDate(productCreateDateStr);
                        try { product.AddProduct(productName, productPrice, productCreateDate); }
                        catch (NegativeNumberException ex) { Console.WriteLine(ex.Message); }
                        break;
                        case 2:
                        Console.WriteLine("Axtaris edeceyin sozu daxil et:");
                        string searchWord = "";
                        searchWord = method.CheckString(searchWord);
                        try { product.Search(searchWord); }
                        catch(NotFoudException ex){ Console.WriteLine(ex.Message);}
                        break;
                    case 3:
                        Console.WriteLine("Id daxil et:");
                        string productIdStr = "";
                        int productId = method.CheckInt(productIdStr);
                        try { comment.SearchByProduct(productId); }
                        catch (NotFoudException ex) { Console.WriteLine(ex.Message); }
                        break;
                    case 4:
                        Console.WriteLine("Id daxil et:");
                        string userIdStr = "";
                        int userId = method.CheckInt(userIdStr);
                        try { comment.SearchByUser(userId); }
                        catch (NotFoudException ex) { Console.WriteLine(ex.Message); }
                        break;
                    case 5:
                        Console.WriteLine("Id daxil et:");
                        string commentIdStr = "";
                        int commentId = method.CheckInt(commentIdStr);
                        try { comment.Delete(commentId); }
                        catch (NotFoudException ex) { Console.WriteLine(ex.Message); }
                        break;
                    case 6:
                        try { Console.WriteLine(product.Avg()); }
                        catch (NotFoudException ex)  {Console.WriteLine(ex.Message);}
                        
                        break;
                    case 7:
                        Console.WriteLine("Tarixleri daxil et:");
                        string startDateSt = "";
                        string endDateSt = "";
                        DateTime startDate = method.CheckDate(startDateSt);
                        DateTime endDate = method.CheckDate(endDateSt);
                        comment.SearchDate(startDate, endDate);
                        break;
                    case 8:
                        user.GetAll();
                        break;
                }
            }
            while (true);
        }
        
    }
}

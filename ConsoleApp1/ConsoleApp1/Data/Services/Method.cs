using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Data.Services
{
    internal class  Method
    {
         public  DateTime CheckDate(string date)
        {
            DateTime dateTime;
            bool check = true;
            do
            {
                if (!check)
                {
                    Console.WriteLine("Duzgun daxil edin !!!!");
                }
                check = false;
                date = Console.ReadLine();
            }
            while (!DateTime.TryParse(date, out dateTime));

            return dateTime;
        }
        public int CheckInt(string number)
        {
            int count;
            bool check = true;
            do
            {
                if (!check)
                {
                    Console.WriteLine("Duzgun daxil edin !!!!");
                }
                check = false;
                number = Console.ReadLine();
            }
            while (!int.TryParse(number, out count));

            return count;
        }
        public string CheckString(string word)
        {
            bool check = true;
            do
            {
                if (!check)
                {
                    Console.WriteLine("Duzgun daxil edin !!!!");
                }
                check = false;
                word = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(word));

            return word;
        }
    }
}

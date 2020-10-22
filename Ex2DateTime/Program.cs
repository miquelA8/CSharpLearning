using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var current = DateTime.Now;
            Console.WriteLine("Give me a date:          (dd-mm-yyyy)");
            string sDatePrevious = Console.ReadLine();
            DateTime datePrevious = DateTime.ParseExact(sDatePrevious, "d-M-yyyy", null);
            TimeSpan totalDate = DateTime.Now.Subtract(datePrevious);
            Console.WriteLine($"It have been {totalDate.Days} days since {sDatePrevious}");
            
            Console.WriteLine("Give me a time          HH:mm tt ");            
            string userDateString = Console.ReadLine();

            DateTime userDate = DateTime.ParseExact(userDateString, "h:mm tt", null);

            TimeSpan totalTime = DateTime.Now.Subtract(userDate);

            Console.WriteLine($"{userDateString} was {totalTime.Hours} hours and {totalTime.Minutes} minutes ago ");

            Console.ReadLine();
        }
    }
}

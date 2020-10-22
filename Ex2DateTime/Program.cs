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
            Console.ReadLine();
            //Console.WriteLine("Give me a time          HH:mm tt ");
            
            
           /* var notCurrent = DateTime.Parse(Console.ReadLine()) ;
            var totalCurrent = notCurrent - current;
            var notCurrentTT = notCurrent.ToString("hh:mm tt");
            var totalCurrentTT = totalCurrent.ToString("hh:mm tt");
            Console.WriteLine($"{notCurrentTT} was {totalCurrentTT)} ago ");
            Console.ReadLine();*/
        }
    }
}

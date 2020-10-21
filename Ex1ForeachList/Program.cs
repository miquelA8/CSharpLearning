using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex1ForeachList
{
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new List<String>() { "Pepe", "Jose", "Antonio", "Federico", "Bernardo" };

            foreach(var value in sort)
            {
                Console.WriteLine(value);
                Thread.Sleep(1000);
            }
        }
    }
}

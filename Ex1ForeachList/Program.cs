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
/*
            var sort = new List<String>() { "Pepe", "Jose", "Antonio", "Federico", "Bernardo" };

            foreach(var value in sort)
            {
                Console.WriteLine(value);
                
            }
           Console.ReadLine();
*/

            List<PersonModel> namesList = new List<PersonModel>();

            namesList.Add(new PersonModel {firstName ="Antonio Pepe", lastName="García Rodriguez" });
            namesList.Add(new PersonModel {firstName = "Bonifacio", lastName = "Smith" });
            namesList.Add(new PersonModel {firstName = "Matias", lastName = "Pons" });

            foreach (PersonModel name in namesList)
                Console.WriteLine($"Hola: {name.firstName} { name.lastName}");
            Console.ReadLine();
        }
    }
}

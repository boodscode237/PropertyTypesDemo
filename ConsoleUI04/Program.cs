using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Doe");

            person.FirstName = "Joe";
            person.Age = 25;
            person.BankCard = "5684-5816-8884-2569";

            Console.WriteLine(person.BankCard);
            Console.WriteLine(person.FullName);

            Console.ReadLine();
        }
    }
}

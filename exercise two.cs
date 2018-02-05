using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int number2;

            Console.WriteLine("Enter a number, and I will add one to it");
            number = Convert.ToInt32(Console.ReadLine());
            number2 = number + 1;
            Console.Write(number2 + " is answer    ");
        }
    }
}

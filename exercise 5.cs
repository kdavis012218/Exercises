using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution;
            
            Console.WriteLine("Please enter two numbers");
            int val = int.Parse(Console.ReadLine());
            int val1 = int.Parse(Console.ReadLine());
            Console.ReadKey();
            solution = val * val1;
            Console.WriteLine("the answer is " + solution);
            Console.ReadKey();
        }
    }
}

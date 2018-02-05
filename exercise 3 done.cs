using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            float solution;
            float val1 = 0.5f;
            Console.WriteLine("Please enter a number");
            float val = float.Parse(Console.ReadLine());
            Console.ReadKey();
            
            solution = val1 + val;
            Console.WriteLine(solution);

        }
    }
}

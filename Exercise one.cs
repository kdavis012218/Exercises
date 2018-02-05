using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Im the Echo Simulator, type something in, and I will repeat it...");
            string response = Console.ReadLine();
            Console.Write(response);
            Console.WriteLine("  Thanks for playing!  ");
        }
    }
}

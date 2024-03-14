using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number:");
            int n=int.Parse(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine($"{n} is an Even Number");
            }
            else
            {
                Console.WriteLine($"{n} is an Odd Number.");
            }
            Console.ReadKey();

        }
    }
}

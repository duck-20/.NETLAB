using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Console.ReadLine----");
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine(); // Reads entire line
            Console.WriteLine($"Your name is {name}.");

            Console.WriteLine("-----Console.Read--------");
            Console.Write("Enter a character:");
            char charac = (char)Console.Read(); // Reads only one character
            Console.WriteLine($"You entered {charac}.");


            Console.WriteLine("-----Console.Write-----");
            Console.Write("This is ");
            Console.Write("a single ");
            Console.Write("line."); // Outputs without newline
            
            Console.WriteLine();

            Console.WriteLine("-----Console.WriteLine---");
            Console.WriteLine("This is");
            Console.WriteLine("multiple");
            Console.WriteLine("lines."); // Outputs with newline each time

            Console.ReadKey();
        }
    }
}

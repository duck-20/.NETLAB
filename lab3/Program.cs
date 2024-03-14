using lab3.Classes;
using System;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wish Wish = new Wish();
            Console.WriteLine("-----Default Constructor----------");
            Wish.Happy();
            Console.WriteLine();
            Console.WriteLine("-----Parameterized Constructor----");
            Wish Wish2 = new Wish("Merry Christmas","Duck");
            Wish2.Happy();
            Console.ReadKey();
        }
    }
}

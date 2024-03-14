using System;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The Sum of 5 and 6 = {Sum(5, 6)}");
            Console.WriteLine();
            Console.WriteLine($"The Sum of 5,6 and 7 = {Sum(5,6,7)}");
            Console.ReadKey();
        }
        static int Sum(int x,int y)
        {
            return x + y;
        }
        static int Sum(int x,int y,int z)
        {
            return x + y + z;
        }
    }
}

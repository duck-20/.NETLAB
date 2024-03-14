using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab51
{
    public class Addition
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            Console.WriteLine($"Addition with Two parameter:{addition.Sum(5, 5)}");
            Console.WriteLine($"Addition with three parameter:{addition.Sum(5, 5, 5)}");
            Console.WriteLine($"Addition with Four parameter:{addition.Sum(5, 5, 5, 5)}");
            Console.ReadKey();
        }
    }
}

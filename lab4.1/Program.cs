using System;

namespace lab4._1
{
    public interface Addition
    {
        double add(double a, double b);
    }
    public interface Substraction
    {
        double sub(double a, double b);
    }
    public interface Multiply
    {
        double mul(double a, double b);
    }
    public interface Division
    {
        double div(double a, double b);
    }
   public class Calculation : Addition, Substraction, Division, Multiply
    {
        public double add(double a, double b)
        {
            return a + b;
        }
        public double sub(double a, double b)
        {
            return a - b;
        }

        public double mul(double a, double b)
        {
            return a * b;
        }
        public double div(double a, double b)
        {
            return a / b;
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Calculation calc = new Calculation();
                Console.WriteLine($"Addition:{calc.add(5, 6)}");
                Console.WriteLine($"Substraction:{calc.sub(10,5)}");
                Console.WriteLine($"Multiplication:{calc.mul(5,5)}");
                Console.WriteLine($"Division:{calc.div(10,5)}");
                Console.ReadKey();
            }
        }
    }
}

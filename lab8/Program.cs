using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab8
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Addition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Multiplication();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting the calculator. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                break;
                }
            }
        }
        static void Addition()
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double result = num1 + num2;
            Console.WriteLine($"Result: {num1} + {num2} = {result}");
        }
        static void Subtraction()
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double result = num1 - num2;
            Console.WriteLine($"Result: {num1} - {num2} = {result}");
        }
        static void Multiplication()
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double result = num1 * num2;
            Console.WriteLine($"Result: {num1} * {num2} = {result}");
        }
        static void Division()
        {
            Console.Write("Enter the dividend: ");
            double dividend = double.Parse(Console.ReadLine());
            Console.Write("Enter the divisor: ");
            double divisor = double.Parse(Console.ReadLine());
            if (divisor == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                double result = dividend / divisor;
                Console.WriteLine($"Result: {dividend} / {divisor} = {result}");
            }
            Console.ReadKey();
        }
    }
}
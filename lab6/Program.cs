using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Marks for Dotnet:");
            double mark1=double.Parse(Console.ReadLine());
            Console.Write("Enter Marks for MIS:");
            double mark2=double.Parse(Console.ReadLine());
            Console.Write("Enter Marks for ComputerNetworking:");
            double mark3=double.Parse(Console.ReadLine());
            Console.Write("Enter Marks for Management:");
            double mark4=double.Parse(Console.ReadLine());
            Console.Write("Enter Marks for Computer Graphics:");
            double mark5=double.Parse(Console.ReadLine());
            double total=mark1 + mark2 + mark3 + mark4+mark5;
            Console.WriteLine("-----------------------------");
            string grade;
            if(total >= 400 && total <= 500)
            {
                grade = "A";
            }
            else if(total>=300 && total < 400)
            {
                grade = "B";
            }
            else if(total>=200 && total < 300)
            {
                grade = "C";
            } 
            else if(total>=100 && total < 200)
            {
                grade = "D";
            }
            else
            {
                grade="E";
            }
            Console.WriteLine("Final Grade:"+grade);
            Console.ReadKey();
        }
    }
}

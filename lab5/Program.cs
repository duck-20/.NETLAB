using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class RoadHouse
    {
       public virtual void SpecialDish()
        {
            Console.WriteLine("Today's Special Dish is BBQ Pizza.");
        }
    }
    public class LavieHouse:RoadHouse
    {
        public override void SpecialDish()
        {
            Console.WriteLine("Today's Special Dish is Arabic Biryani.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            RoadHouse roadHouse = new RoadHouse();
            roadHouse.SpecialDish();
            LavieHouse lavie = new LavieHouse();
            lavie.SpecialDish();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Classes
{
    public class Wish
    {
        public string wish;
        public string name;
        public Wish()
        {
            wish = "Happy Birthday";
            name= "Ayush";
        }
        public Wish(string wish,string Name)
        {
            this.wish = wish;
            this.name = Name;

        }
        public void Happy()
        {
            Console.WriteLine($"{wish} {name}!");
        }
    }
}

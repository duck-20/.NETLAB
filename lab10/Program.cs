using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string[] movies = new string[] { "Eku", "Loot","Sankhar","Kabaddi","Nango Gau","PashupatiPrasad" };
            foreach (string movie in movies)
            {
                Console.WriteLine($"{i}. {movie}");
                i++;
            }
            Console.ReadKey();
        }
    }
}

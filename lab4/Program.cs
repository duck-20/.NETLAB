using System;

namespace lab4
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
    public class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
    public class Doberman:Dog 
    {
        public void Type() 
        {
            Console.WriteLine("Doberman is a security Type Dog.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Doberman doberman = new Doberman();
            doberman.Eat();
            doberman.Bark();
            doberman.Type();
            Console.ReadKey();
        }
    }
}

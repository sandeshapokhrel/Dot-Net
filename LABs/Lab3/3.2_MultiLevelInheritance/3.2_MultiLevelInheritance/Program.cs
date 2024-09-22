//Write a program to show the multilevel inheritance. 
using System.Runtime.InteropServices;

namespace _3._2_MultiLevelInheritance
{
    internal class Program
    {
        public class Animal
        {
            public void MakesSound()
            {
                Console.WriteLine("Animal MakesSound");
            }
        }
        public class Dog:Animal
        {
            public void Barks()
            {
                Console.WriteLine("Dog Barks");
            }
        }
        public class Cat:Dog
        {
            public void Meow()
            {
                Console.WriteLine("Cat Meows");
            }
        }
        static void Main(string[] args)
        {
            Cat animal = new Cat();
            animal.MakesSound();
            animal.Meow();
            animal.Barks();
           
        }
    }
}

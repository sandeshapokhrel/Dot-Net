// Write a program to demonstrate the sealing function and class.
using System;

namespace SealedExample
{
    // Base class
    public class BaseClass
    {
        public virtual void Show()
        {
            Console.WriteLine("BaseClass method.");
        }
    }

    // Derived class with sealed method
    public class DerivedClass : BaseClass
    {
        public sealed override void Show()
        {
            Console.WriteLine("DerivedClass sealed method.");
        }
    }

    // Sealed class
    public sealed class SealedClass : DerivedClass
    {
        public void Display()
        {
            Console.WriteLine("SealedClass cannot be inherited.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SealedClass obj = new SealedClass();
            obj.Display();
            obj.Show();
        }
    }
}


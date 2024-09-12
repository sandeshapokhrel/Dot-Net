using System;
namespace Generic_class_eg
{
    // Define a generic class
    public class Box<T>
    {
        private T _value;

        // Constructor to initialize the value
        public Box(T value)
        {
            _value = value;
        }

        // Method to get the value
        public T GetValue()
        {
            return _value;
        }

        // Method to set the value
        public void SetValue(T value)
        {
            _value = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Box of type int
            Box<int> intBox = new Box<int>(123);
            Console.WriteLine("Int value: " + intBox.GetValue());

            // Creating a Box of type string
            Box<string> strBox = new Box<string>("Hello, Generics");
            Console.WriteLine("String value: " + strBox.GetValue());
        }
    }

}

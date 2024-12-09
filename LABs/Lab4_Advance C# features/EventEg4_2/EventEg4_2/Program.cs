// Write a console application that has a class and an event in the class is raised when a method of the class is
// invoked.The raised event should also be handled.
using System;
using System;

namespace EventDemo
{
    // Declare a delegate type for the event
    public delegate void MyEventHandler();

    internal class Person
    {
        private string name;

        // Define an event using the delegate
        public event MyEventHandler NameChanged;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;

                // Raise the event when the Name property is set
                OnNameChanged();
            }
        }

        // Method to invoke the event
        protected virtual void OnNameChanged()
        {
            if (NameChanged != null)
            {
                NameChanged();
            }
        }
    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            SubscriberClass sc = new SubscriberClass();

            // Subscribe the event
            p.NameChanged += sc.OnNameChangeHandler;

            // Trigger the event by setting the Name property
            p.Name = "Shyam";
            p.Name = "Ram";

            // Ensure the program does not close immediately
            Console.ReadLine();
        }
    }
}

internal class SubscriberClass
{
    public void OnNameChangeHandler()
    {
        Console.WriteLine("The Name property has been updated.");
    }
}



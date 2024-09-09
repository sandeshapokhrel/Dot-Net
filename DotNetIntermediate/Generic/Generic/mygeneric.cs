//Queue using generic class
using System;
using System.Collections.Generic;  // Add this for List<T>

class SimpleQueue<T> // Generic class with <T>
{
    private List<T> elements = new List<T>();  // List to hold queue elements

    // Method to add an item
    public void Enqueue(T item)
    {
        elements.Add(item);
        Console.WriteLine(item + " added to the queue.");
    }

    // Method to remove an item
    public T Dequeue()
    {
        if (elements.Count == 0)
        {
            Console.WriteLine("Queue is empty!");
            return default(T);  // Returns default value (null or 0)
        }
        T value = elements[0];
        elements.RemoveAt(0);
        return value;
    }

    // Method to check if the queue is empty
    public bool IsEmpty()
    {
        return elements.Count == 0;
    }

    // Method to get the number of items in the queue
    public int Count()
    {
        return elements.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a queue for integers
        SimpleQueue<int> intQueue = new SimpleQueue<int>();
        intQueue.Enqueue(10);
        intQueue.Enqueue(20);
        Console.WriteLine("Dequeued: " + intQueue.Dequeue());

        // Creating a queue for strings
        SimpleQueue<string> stringQueue = new SimpleQueue<string>();
        stringQueue.Enqueue("Hello");
        stringQueue.Enqueue("World");
        Console.WriteLine("Dequeued: " + stringQueue.Dequeue());
    }
}

//Create a generic class and methods.Also show its implementation. 

using System;

class GenericClass<T>
{
    private T[] items;
    private int count;

    public GenericClass(int size)
    {
        items = new T[size];
        count = 0;
    }

    public void Add(T item)
    {
        if (count < items.Length)
        {
            items[count++] = item;
        }
        else
        {
            Console.WriteLine("Array is full.");
        }
    }

    public void DisplayItems()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(items[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        GenericClass<int> intList = new GenericClass<int>(5);
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        intList.DisplayItems();  // Output: 1, 2, 3

        GenericClass<string> stringList = new GenericClass<string>(5);
        stringList.Add("Hello");
        stringList.Add("World");
        stringList.DisplayItems();  // Output: Hello, World
    }
}

//inheritancs
using System;


public class Animal
{
    public void sleep()
    {
        Console.WriteLine("Sleeping");
    }
}


public class cat : Animal
{
    public void sound()
    {
        Console.WriteLine("meow..");
    }
}

public class Program
{
    public static void Main()
    {
        cat mycat = new cat();
        mycat.sound();  
        mycat.sleep(); 
    }
}

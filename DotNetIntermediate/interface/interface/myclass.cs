using interfaceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceDemo
{
    internal class MyClass : Imyinterface
    {
        public void MyMethod() // Implement the method as defined in the interface
        {
            Console.WriteLine("This is my class");
        }
    }
}
public class programMain
{
    public static void Main (String [] args)
    {
        Imyinterface newinterface = new MyClass();
        newinterface.MyMethod();
    }
}

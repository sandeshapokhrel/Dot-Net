// Insted of class we use structure sometime because structures in C# for efficiency and simplicity.
// They offer memory efficiency for small, immutable data types, improved performance due to stack allocation,
// and ensure that changes to one instance do not affect others due to their value-type nature. Structs are ideal
// when you need lightweight data containers that don’t require inheritance or reference-type semantics.

//Class-Constructor both Parameter and Default 
//Structure- Only Parametrized Constructor, NO (Default Constructor, virtual Method, Override,Destructure(Finalizer), inheritance, Field Initilization)
//solve- pass the value from Structure also change the value 
//distance method- also create a distance method and find the 

//internal class- assess only within the containing acessambly or friend assembly 
// by default it will be internal 
using Structure;
using System.Drawing;

namespace structure
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyPoint p = new MyPoint(10, 9);
            Console.WriteLine("Before change: " + p);

            Change(ref p);
            Console.WriteLine("After change: " + p);

            MyPoint p2 = new MyPoint(10, 9);
            MyPoint p3 = new MyPoint(20, 30);
            Console.WriteLine("Distance between p2 and p3: " + p2.DistanceTo(p3));
        }

        public static void Change(ref MyPoint p)
        {
            p.X = 20;
            p.Y = 30;
        }
    }
}

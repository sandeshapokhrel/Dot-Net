//Write a program to implement the features of multiple inheritance. 
namespace _3._4_MultipleInheritance
{
    internal class Program
    {   
        public class vechilee
        {
            public void Stop()
            {
                Console.WriteLine("Stopped...");
            }
        }
        public interface  Ivechile
        {
            public void Drive ();
        }
        public class RangeRover: vechilee, Ivechile
        {
            public void Drive()
            {
                Console.WriteLine("Driving....");
            }
            


        }
       
        static void Main(string[] args)
        {
            Ivechile obj1 = new RangeRover();
            obj1.Drive();
            vechilee obj2 = new vechilee();
            obj2.Stop();
        }
    }
}

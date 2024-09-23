//Write a program to show the single inheritance.  
namespace _3._1_Single_Inheritance
{
    internal class Program
    {
        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal eats");
            }
            public void Stop()
            {
                Console.WriteLine("Animal Stop Eating");
            }
        }
        public class dog : Animal
        {
            public void Eat()
            
                {
                base.Eat();

               // Console.WriteLine("dog is eating");
                }
            
            public new void Stop()
            {
                base.Stop();

                //Console.WriteLine("Dog stopped eating");
            }
        }
        class programMain
        {
            static void Main(string[] args)
            {
                Animal animal2 = new dog();
                animal2.Eat();
                animal2.Stop();
            }
        }
    }
}

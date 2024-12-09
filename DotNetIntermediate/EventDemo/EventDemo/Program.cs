namespace EventDemo
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            SubscriberClass sc = new SubscriberClass();

            // Subscribe methods to the delegate
            p.del += sc.abc;
            p.del += sc.xyz;

            // Trigger the delegate
            p.Name = "Shyam";
            p.Name = "Ram";
        }
    }
}

internal class SubscriberClass
        {
            public void abc()
            {
                Console.WriteLine("abc called");
            }

            public void xyz()
            {
                Console.WriteLine("xyz called");
            }
        }
    

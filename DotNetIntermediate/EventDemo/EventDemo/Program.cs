namespace EventDemo
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Person p = new Person();
            SubscriberClass sc = new SubscriberClass();
            p.del += sc.abc; // subscribe abc method
            p.del += sc.xyz;
            p.Name = "shyam";
          
        }
    }
}

internal class SubscriberClass
{
    public void abc()
    {
        System.Console.WriteLine("ABC Subscriber is Called");
    }
    public void xyz()
    {
        System.Console.WriteLine("xyz Subscriber is Called");
    }
}

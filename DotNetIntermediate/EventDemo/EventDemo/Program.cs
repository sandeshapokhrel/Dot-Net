namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.del += abc;
            p.del += xyz;
            p.Name = "Test"; // state change 
            p.Name = "RAM";
        }
        private static void abc()
        {
            System.Console.WriteLine("abc subscriber call");
        }
        private static void xyz()
        {
            System.Console.WriteLine(" xyz subscriber call ");
        }
    }
}

namespace LamdaExpressionBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Expression Lambda

            Func<int, int> abc= x => x * x;
            int a = abc(5);
            Console.WriteLine(a);

            //Statement Lambda

            Func<int, int> abcd = x => { return x * x; };
            int b = abcd(5);
            Console.WriteLine(b);
        }
    }
}

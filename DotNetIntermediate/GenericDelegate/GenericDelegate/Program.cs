namespace GenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Func Generic Delegate
            Func<int, string> check = a => (a % 2 == 0) ? "even" : "odd";
            Console.WriteLine(check(2)); //returns a value 

            // Action Delegate
            Action<int> checkAndPrint = a => Console.WriteLine((a % 2 == 0) ? "even" : "odd");
            checkAndPrint(2); //doesnt return a value 

            // Predicate Delegeate
            Predicate<int> isEven = a => a % 2 == 0;
            Console.WriteLine(isEven(2)); // gives boolen output.


        }
    }
}

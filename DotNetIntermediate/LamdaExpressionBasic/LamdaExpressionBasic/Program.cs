namespace LamdaExpressionBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Expression Lambda
            Func<int, int> abc = x => x * x; // Lambda function to square a number
            int a = abc(5); // Call the function with input 5
            Console.WriteLine(a);

            // Statement Lambda
            Func<int, int> abcd = x => { return x * x; }; // Lambda function to square a number
            int b = abcd(5); // Call the function with input 5
            Console.WriteLine(b);

            // Odd or Even
            Func<int, int> number = x => { return x * x; }; // Lambda function to square a number
            int check = number(5); // Call the function with input 5
            if (check % 2 == 0) 
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            Console.WriteLine(check); 

          
            //Func<int, string> checkAnother = D => (D % 2 == 0) ? "Even" : "Odd";
            //Another Method
            var v = (int a) => (a % 2 == 0) ? "even" : "odd";
            Console.WriteLine(v(2));
        }
    }
}

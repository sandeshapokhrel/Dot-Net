// Show the use of Lambda expressions in a program. [Show both expression lambda and statement lambda]
namespace LamdaExpressionEg4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Expression lambda
            Func<int, int> square = x=> x * x; // takes one input and return square
            Console.WriteLine("square"+ square(5)); 

            // Statement lambda: Allow multiple statement within the body .
            Action<string> greet = name =>
            {
              Console.WriteLine("Hello"+name);
                Console.WriteLine("welcome to lambda Expression.");
            };
            greet("san");
        }
    }
}

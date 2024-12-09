// Create your own exception and implement in your own defined situation.
namespace OwnExceptionEg4_5
{
        public class AgeException : Exception
        {
            public AgeException(string message) : base(message)
            {
            }
        }

        internal class Program
        {
            public static void ValidateAge(int age)
            {
                // Validate age: it should be greater than 18
                if (age <= 18)
                {
                    throw new AgeException("Age is invalid. You must be older than 18.");
                }
                Console.WriteLine($"Age {age} is valid.");
            }

            static void Main(string[] args)
            {
                try
                {
                    Console.Write("Enter your age: ");
                    int age = int.Parse(Console.ReadLine());

                    // Validate age inside the try block
                    ValidateAge(age);
                }
                catch (AgeException ex)
                {
                    // Catch the custom exception
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Catch any other exceptions
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }
        }
 }

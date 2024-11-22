namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0;
            
            try
            {
                int c = a / b;
                int[] arr = { 1, 2, 3, 4 };
                Console.WriteLine(arr[3]);
            }
            // catch 
            // {
            //   Console.WriteLine("Exception occured");
            // }
            
            catch (DivideByZeroException e) 
                                             
                                             
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e) // catch can also be written without an arunment
                                            // We dont have to write catch cumpolsary 
                                            //we can directly write finally after the try block
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

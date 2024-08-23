using System;

namespace OperatorOverloading
{
    class Price
    {
        
        string symbol;
        int rupee;
        int paisa;

        
        public Price(string symbol, int rupee, int paisa)
        {
            this.symbol = symbol;
            this.rupee = rupee;
            this.paisa = paisa;
        }

        // Method to convert the object into a string representation
        public override string ToString()
        {
            return symbol + " " + rupee + " rupees " + paisa + " paisa";
        }

        // Operator overloading for the '+' operator to add two Price objects
        public static Price operator +(Price p1, Price p2)
        {
            int totalPaisa = p1.paisa + p2.paisa;
            int extraRupee = totalPaisa / 100; // 100 paisa = 1 rupee
            int finalPaisa = totalPaisa % 100;
            int finalRupee = p1.rupee + p2.rupee + extraRupee;

            return new Price(p1.symbol, finalRupee, finalPaisa);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating two Price objects
            Price p1 = new Price("Rs", 10, 50);
            Price p2 = new Price("Rs", 5, 75);

            // Adding the two Price objects using the overloaded '+' operator
            Price p3 = p1 + p2;

            // Printing the result
            Console.WriteLine(p3.ToString()); 
        }
    }
}

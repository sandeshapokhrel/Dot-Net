using System;

namespace StockEventDelegate
{
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

    public class Stock
    {
        private string symbol;
        private decimal price;

        public Stock(string symbol)
        {
            this.symbol = symbol;
        }

        public event PriceChangedHandler PriceChanged;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return; // Exit if nothing has changed

                decimal oldPrice = price;
                price = value;

                // Raise the event
                PriceChanged?.Invoke(oldPrice, price);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("AAPL");
            stock.PriceChanged += Stock_PriceChanged;

            stock.Price = 150.00m; // Set initial price
            stock.Price = 155.50m; // Update price to trigger the event
        }

        private static void Stock_PriceChanged(decimal oldPrice, decimal newPrice)
        {
            Console.WriteLine($"Price changed from {oldPrice:C} to {newPrice:C}");
        }
    }
}

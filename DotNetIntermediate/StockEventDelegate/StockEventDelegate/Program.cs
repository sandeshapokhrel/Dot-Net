using System;

public class PriceChangedEventArgs : EventArgs
{
    public decimal LastPrice { get; }
    public decimal NewPrice { get; }

    public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
    {
        LastPrice = lastPrice;
        NewPrice = newPrice;
    }
}

public class Stock
{
    private string symbol;
    private decimal price;

    public Stock(string symbol)
    {
        this.symbol = symbol;
    }

    public event EventHandler<PriceChangedEventArgs> PriceChanged;

    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (price == value) return;

            decimal oldPrice = price;
            price = value;

            OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
        }
    }
}

class Test
{
    static void Main()
    {
        Stock stock = new Stock("THPW");
        stock.Price = 27.10M;

        // Register with the PriceChanged event
        stock.PriceChanged += Stock_PriceChanged;

        // Trigger the event by changing the price
        stock.Price = 31.59M;
    }

    static void Stock_PriceChanged(object sender, PriceChangedEventArgs e)
    {
        if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
        {
            Console.WriteLine("Alert, 10% stock price increase!");
        }
    }
}

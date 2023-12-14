namespace StockMarketTicker {
  public class StockTicker {
    private Random random = new Random();
    private Dictionary<string, double> _stocks = new Dictionary<string, double> 
    {
            {"AAPL", 150.00},
            {"MSFT", 250.00},
            {"GOOG", 2800.00},
            // Add more stocks as needed
    };

    public Dictionary<string, double> GetUpdatedPrices()
    {
        // Simulate price change
        foreach (var stock in _stocks.Keys)
        {
            double change = (random.NextDouble() - 0.5) * 10; // Random price change
            _stocks[stock] += change;
        }

        return new Dictionary<string, double>(_stocks);
    }
  }
}
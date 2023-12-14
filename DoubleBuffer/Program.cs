namespace StockMarketTicker
{
  class Program
  {
    static void Main(string[] args)
    {
      StockTicker ticker = new StockTicker();
      DoubleBuffer buffer = new DoubleBuffer();
      while (true)
      {
        // Update buffer with new prices
        buffer.UpdateBuffer(ticker.GetUpdatedPrices());

        // Display current prices
        Dictionary<string, double> currentPrices = buffer.GetBufferForDisplay();
        if (currentPrices.Count == 0)
        {
          Console.WriteLine("No stocks available");
        }
        foreach (var stock in currentPrices)
        {
          Console.WriteLine($"{stock.Key}: {stock.Value:F2}");
        }

        // Swap buffers
        buffer.SwapBuffers();

        // Clear console and wait for next update
        Thread.Sleep(1000); // Update every second
        Console.Clear();
      }
    }
  }
}

namespace StockMarketTicker
{
    public class DoubleBuffer
    {
        // create an array of dictionaries to hold the two buffers
        private Dictionary<string, double>[] buffers = new Dictionary<string, double>[2];
        private int currentBuffer = 0;

        public DoubleBuffer()
        {
            buffers[0] = new Dictionary<string, double>();
            buffers[1] = new Dictionary<string, double>();
        }

        public void UpdateBuffer(Dictionary<string, double> newPrices)
        {
            buffers[currentBuffer] = newPrices;
        }

        public Dictionary<string, double> GetBufferForDisplay()
        {
            int displayBufferIndex = (currentBuffer + 1) % 2;
            return buffers[displayBufferIndex];
        }

        public void SwapBuffers()
        {
            currentBuffer = (currentBuffer + 1) % 2;
        }
    }
}

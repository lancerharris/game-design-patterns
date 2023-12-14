namespace WeatherMonitoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensorDataBuffer = new RingBuffer<SensorData>(10); // Buffer for 10 readings
            var random = new Random();

            while (true)
            {
                // Simulate receiving new sensor data
                var data = new SensorData
                {
                    Timestamp = DateTime.Now,
                    Temperature = 20 + random.NextDouble() * 15, // Random temperature
                    Humidity = 30 + random.NextDouble() * 70, // Random humidity
                    WindSpeed = 0 + random.NextDouble() * 100 // Random wind speed
                };

                sensorDataBuffer.Add(data);

                // Display the latest sensor data
                Console.Clear();
                Console.WriteLine("Latest Sensor Readings:");
                foreach (var item in sensorDataBuffer.GetAll())
                {
                    Console.WriteLine(item);
                }

                Thread.Sleep(1000); // Wait for 1 second before the next reading
            }
        }
    }
}

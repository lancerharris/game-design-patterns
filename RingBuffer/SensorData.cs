namespace WeatherMonitoringSystem
{
    public class SensorData
    {
        public DateTime Timestamp { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }

        public override string ToString()
        {
            return $"{Timestamp:G}: Temp={Temperature:F1}°C, Humidity={Humidity:F1}%, Wind={WindSpeed:F1} km/h";
        }
    }
}

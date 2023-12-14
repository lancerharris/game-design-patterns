class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Press Enter to change state. Press 'q' to quit.");
    
    var trafficLight = new TrafficLight(new GreenState());

    while (true)
    {
      var input = Console.ReadLine();
      if (input == "q")
      {
        break;
      }

      trafficLight.Change();
    }
  }
}

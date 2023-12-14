public class DisplayScreen : IObserver
{
  private string _name;
  public DisplayScreen(string name)
  {
    _name = name;
  }

  public void Update(float temperature)
  {
    Console.WriteLine($"{_name} displaying temperature: {temperature}°C");
  }
}
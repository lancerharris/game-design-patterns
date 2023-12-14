public class WeatherStation : ISubject
{
    private float _temperature;
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
      foreach(var observer in _observers) {
        observer.Update(_temperature);
      }
    }

    public void SetTemperature(float temperature) {
      _temperature = temperature;
      Notify();
    }
}
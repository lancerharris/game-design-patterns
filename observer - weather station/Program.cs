using System;
using Microsoft.VisualBasic;


class Program
{ 
  static void Main(string[] args)
  {
    
  WeatherStation weatherStation = new WeatherStation();
  var display1 = new DisplayScreen("Display 1");
  var display2 = new DisplayScreen("Display 2");

  weatherStation.Attach(display1);
  weatherStation.Attach(display2);

  weatherStation.SetTemperature(25.0f); // Both displays will update
  weatherStation.Detach(display1);
  weatherStation.SetTemperature(30.0f);

  Console.ReadKey();
  }
}

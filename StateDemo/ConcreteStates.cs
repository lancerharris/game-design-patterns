public class GreenState : ITrafficLightState {
  public void EnterState(TrafficLight trafficLight) {
    Console.WriteLine("Green light - Go!");
  }
  public void ExitState(TrafficLight trafficLight) {
    trafficLight.SetState(new YellowState());
  }
  public void ReportState() {
    Console.WriteLine("Green");
  }
}

public class YellowState : ITrafficLightState {
  public void EnterState(TrafficLight trafficLight) {
    Console.WriteLine("Yellow light - Slow Down!");
  }
  public void ExitState(TrafficLight trafficLight) {
    trafficLight.SetState(new RedState());
  }
  public void ReportState() {
    Console.WriteLine("Yellow");
  }
}

public class RedState : ITrafficLightState {
  public void EnterState(TrafficLight trafficLight) {
    Console.WriteLine("Red light - Stop!");
  }
  public void ExitState(TrafficLight trafficLight) {
    trafficLight.SetState(new GreenState());
  }
  public void ReportState() {
    Console.WriteLine("Red");
  }
}
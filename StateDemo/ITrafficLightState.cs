public interface ITrafficLightState {
  void EnterState(TrafficLight trafficLight);
  void ExitState(TrafficLight trafficLight);
  void ReportState();
}
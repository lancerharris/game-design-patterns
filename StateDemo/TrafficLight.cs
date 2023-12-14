public class TrafficLight
{
  private ITrafficLightState _state;
  public TrafficLight(ITrafficLightState state)
  {
    _state = state;
    _state.EnterState(this);
  }
  public void SetState(ITrafficLightState state)
  {
    _state = state;
  }
  public void ReportState()
  {
    _state.ReportState();
  }
  public void Change()
  {
    _state.ExitState(this);
    _state.EnterState(this);
  }
}
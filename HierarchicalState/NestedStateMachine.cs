using HierarchicalStateMachine;

public class NestedStateMachine : IState {
  private IState? _currentState;
  private IState _parentState;

  public NestedStateMachine(IState parentState) => _parentState = parentState;

  public void ChangeState(IState newState) {
    _currentState?.Exit();
    _currentState = newState;
    _currentState.Enter();
  }

  public void Enter() => _parentState.Enter();
  public void Exit() => _parentState.Exit();
  public void Update() {
    _parentState.Update();
    _currentState?.Update();
  }
}
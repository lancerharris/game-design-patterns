public class StateStack
{
  private Stack<IState> states = new Stack<IState>();

  public void PushState(IState newState)
  {
    if (states.Any())
    {
      states.Peek().Exit();
    }
    states.Push(newState);
    newState.Enter();
  }

  public void PopState()
  {
    if (states.Any())
    {
      states.Pop().Exit();
      if (states.Any())
      {
        states.Peek().Enter();
      }
    }
  }

  public void HandleInput(string input)
  {
    if (states.Any())
    {
      states.Peek().HandleInput(input);
    }
  }

}

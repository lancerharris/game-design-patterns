public class Game {
  private StateStack stateStack = new StateStack();

  public void Start() {
    stateStack.PushState(new ExploringState());
  }
}
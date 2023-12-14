namespace HierarchicalStateMachine
{
  public interface IState
  {
    void Enter();
    void Update();
    void Exit();
  }

  public class ExploringState : IState
  {
    public void Enter() => Console.WriteLine("Entering Exploring State.");
    public void Update() => Console.WriteLine("Exploring the world...");
    public void Exit() => Console.WriteLine("Exiting Exploring State.");
  }

  public class MenuState : IState
  {
    public void Enter() => Console.WriteLine("Entering Menu State.");
    public void Update() => Console.WriteLine("Opening the menu...");
    public void Exit() => Console.WriteLine("Exiting Menu State.");
  }

  public class CombatState : IState
  {
    public void Enter() => Console.WriteLine("Entering Combat State.");
    public void Update() => Console.WriteLine("Fighting the enemy...");
    public void Exit() => Console.WriteLine("Exiting Combat State.");
  }

  // substate of combat state
  public class AttackingState : IState
  {
    public void Enter() => Console.WriteLine("Entering Attacking State.");
    public void Update() => Console.WriteLine("Attacking the enemy...");
    public void Exit() => Console.WriteLine("Exiting Attacking State.");
  }

  // substate of combat state
  public class DefendingState : IState
  {
    public void Enter() => Console.WriteLine("Entering Defending State.");
    public void Update() => Console.WriteLine("Defending from the enemy...");
    public void Exit() => Console.WriteLine("Exiting Defending State.");
  }

  // substate of combat state
  public class UsingItemState : IState
  {
    public void Enter() => Console.WriteLine("Entering UsingItem State.");
    public void Update() => Console.WriteLine("Using an item...");
    public void Exit() => Console.WriteLine("Exiting UsingItem State.");
  }
}
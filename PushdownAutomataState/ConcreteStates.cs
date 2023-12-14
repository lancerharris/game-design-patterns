public class ExploringState : IState
{
  public void Enter()
  {
    Console.WriteLine("You are exploring the mysterious forest.");
    Console.WriteLine("Choose an action: [talk] [explore] [rest] [solve puzzle] [encounter]");
  }

  public void Exit()
  {
    Console.WriteLine("Leaving Exploring State...");
  }

  public void HandleInput(string input)
  {
    switch (input)
    {
      case "talk":
        Program.stateStack.PushState(new TalkingState());
        break;
      case "explore":
        Console.WriteLine("You continue exploring the forest.");
        break;
      case "rest":
        Program.stateStack.PushState(new RestingState());
        break;
      case "solve puzzle":
        Program.stateStack.PushState(new PuzzleSolvingState());
        break;
      case "encounter":
        Program.stateStack.PushState(new EncounterState());
        break;
      default:
        Console.WriteLine("Invalid action. Choose again.");
        break;
    }
  }
}

public class TalkingState : IState
{
  public void Enter()
  {
    Console.WriteLine("You are talking to a mysterious stranger. Enter any text here. Upon enter you will continue exploring.");
  }

  public void Exit()
  {
    Console.WriteLine("Leaving Talking State...");
  }

  public void HandleInput(string input)
  {
    Console.WriteLine("You finish the conversation.");
    Program.stateStack.PopState();
  }
}

public class RestingState : IState
{
  public void Enter()
  {
    Console.WriteLine("You are resting in a safe place. Enter any text and press enter to continue exploring.");
  }

  public void Exit()
  {
    Console.WriteLine("Leaving Resting State...");
  }

  public void HandleInput(string input)
  {
    Console.WriteLine("You feel refreshed and ready to continue.");
    Program.stateStack.PopState();
  }
}

public class PuzzleSolvingState : IState
{
  public void Enter()
  {
    Console.WriteLine("You are solving a complex puzzle.");
    Console.WriteLine("Choose an action: [solve] [give up] [rest]");
  }

  public void Exit()
  {
    Console.WriteLine("Leaving Puzzle Solving State...");
  }

  public void HandleInput(string input)
  {
    switch (input)
    {
      case "solve":
        Console.WriteLine("You successfully solved the puzzle!");
        Program.stateStack.PopState();
        break;
      case "give up":
        Console.WriteLine("You decide to give up on the puzzle.");
        Program.stateStack.PopState();
        break;
      case "rest":
        Console.WriteLine("You decide to take a break from the puzzle to rest.");
        Program.stateStack.PushState(new RestingState());
        break;
      default:
        Console.WriteLine("Invalid action. Choose again.");
        break;
    }
  }
}

public class EncounterState : IState
{
  public void Enter()
  {
    Console.WriteLine("You encounter a mysterious creature.");
    Console.WriteLine("Choose an action: [talk] [fight] [run]");
  }

  public void Exit()
  {
    Console.WriteLine("Leaving Encounter State...");
  }

  public void HandleInput(string input)
  {
    switch (input)
    {
      case "talk":
        Program.stateStack.PushState(new TalkingState());
        break;
      case "fight":
        Console.WriteLine("You bravely fight the creature.");
        Program.stateStack.PopState();
        break;
      case "run":
        Console.WriteLine("You decide to run away.");
        Program.stateStack.PopState();
        break;
      default:
        Console.WriteLine("Invalid action. Choose again.");
        break;
    }
  }
}

using HierarchicalStateMachine;

class Program
{
  static void Main(string[] args)
  {
    StateMachine stateMachine = new StateMachine();
    NestedStateMachine combatStateMachine = new NestedStateMachine(new CombatState());

    stateMachine.ChangeState(new ExploringState());

    bool userWantstoQuit = false;
    while (!userWantstoQuit)
    {
      Console.WriteLine("\nEnter 'c' to enter combat, 'a' to attack, 'b' to go back to exploring, 'd' to defend from the enemy, 'i' to use and item, 'q' to quit the console application:");
      char input = Console.ReadKey().KeyChar;

      switch (input)
      {
        case 'c':
          // stateMachine can take combatStateMachine since NestedStateMachine implements IState
          stateMachine.ChangeState(combatStateMachine);
          break;
        case 'a':
          combatStateMachine.ChangeState(new AttackingState());
          break;
        case 'd':
          combatStateMachine.ChangeState(new DefendingState());
          break;
        case 'i':
          combatStateMachine.ChangeState(new UsingItemState());
          break;
        case 'b':
          stateMachine.ChangeState(new ExploringState());
          break;
        case 'q':
          userWantstoQuit = true;
          return;
      }

      stateMachine.Update();
    }
  }
}

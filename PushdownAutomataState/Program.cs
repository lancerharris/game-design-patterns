// Main Program
class Program {
    public static StateStack stateStack = new StateStack();

    static void Main(string[] args) {
        stateStack.PushState(new ExploringState());

        while (true) {
            string input = Console.ReadLine();
            stateStack.HandleInput(input);
        }
    }
}
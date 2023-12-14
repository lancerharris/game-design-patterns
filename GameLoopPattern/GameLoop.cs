using System;
using System.Diagnostics;

namespace GameLoopSimulation
{
  public class GameLoop
  {
    private const double TimeStep = 1.0 / 60.0; // 60 updates per second

    private Ecosystem ecosystem;
    private Stopwatch stopwatch;

    public GameLoop()
    {
      ecosystem = new Ecosystem();
      stopwatch = new Stopwatch();
    }

    public void Run()
    {
      double lastTime = 0.0; // Stores the time of the last frame.
      double accumulator = 0.0; // Accumulates time to determine when to update.

      stopwatch.Start(); // Starts the stopwatch to track elapsed time.

      while (true) // The main loop that runs continuously.
      {
        double currentTime = stopwatch.Elapsed.TotalSeconds; // Gets the current time.
        double frameTime = currentTime - lastTime; // Calculates the time elapsed since the last frame.
        lastTime = currentTime; // Updates 'lastTime' for the next loop iteration.

        accumulator += frameTime; // Adds the elapsed time to the accumulator.

        while (accumulator >= TimeStep)
        {
          // As long as the accumulated time is greater than or equal to the fixed time step,
          // we continue to update the game logic.

          Update(); // Calls the update method to update the game logic.
          accumulator -= TimeStep; // Decreases the accumulated time by the time step.
        }

        // After updating, render the current state of the game.
        // This rendering can be skipped if it falls behind the updates.
        Render();
      }
    }


    private void Update()
    {
      ecosystem.Update(TimeStep);
    }

    private void Render()
    {
      ecosystem.Render();
    }
  }
}

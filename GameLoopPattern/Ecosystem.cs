using System;

namespace GameLoopSimulation
{
    public class Ecosystem
    {
        // Example state variables
        private int day = 0;

        public void Update(double timeStep)
        {
            // Logic to update the ecosystem
            day++;
        }

        public void Render()
        {
            Console.WriteLine($"Day {day} in the ecosystem");
        }
    }
}

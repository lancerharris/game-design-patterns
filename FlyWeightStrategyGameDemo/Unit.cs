// Implement the concrete unit class from IUnit flyweight interface

namespace Flyweight
{
    public class Unit : IUnit
    {
        private string _unitType;
        private string _weapon;

       public Unit(string unitType, string weapon)
       {
           _unitType = unitType;
           _weapon = weapon;
       }

        public void Display(int x, int y, int health)
        {
          Console.WriteLine($"Unit Type: {_unitType}, Weapon: {_weapon}, Position: ({x},{y}), Health: {health}");
        } 
    }
}

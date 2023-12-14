
using Flyweight;

public class UnitFactory
{
  private Dictionary<String, IUnit> _units = new Dictionary<String, IUnit>();

  public IUnit GetUnit(string unitType) {
    if (!_units.ContainsKey(unitType)) {
      _units[unitType] =  new Unit(unitType, "Standard Weapon");
    }
    return _units[unitType];
  }
}

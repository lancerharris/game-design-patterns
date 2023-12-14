public class Orc : ICreaturePrototype
{
  public int Health { get; set; }
  public int AttackPower { get; set; }

  public Orc(int health, int attackPower)
  {
    Health = health;
    AttackPower = attackPower;
  }

  public ICreaturePrototype Clone()
  {
    return new Orc(Health, AttackPower);
  }

  public override string ToString()
  {
    return $"Orc: Health = {Health}, AttackPower = {AttackPower}";
  }
}
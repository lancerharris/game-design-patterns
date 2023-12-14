class Program
{
    static void Main(string[] args)
    {
        var factory = new UnitFactory();

        // Simulate creating multiple units on the battlefield
        var soldier1 = factory.GetUnit("Soldier");
        soldier1.Display(10, 20, 100);

        var soldier2 = factory.GetUnit("Soldier");
        soldier2.Display(15, 25, 100);

        var tank = factory.GetUnit("Tank");
        tank.Display(50, 50, 500);
    }
}

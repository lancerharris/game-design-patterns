
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an orc prototype
        Orc orcPrototype = new Orc(100, 300);

        // Clone the orc prototype to create two orcs
        Orc orc1 = (Orc)orcPrototype.Clone();
        Orc orc2 = (Orc)orcPrototype.Clone();

        Console.WriteLine(orc1);
        Console.WriteLine(orc2);
    }
}

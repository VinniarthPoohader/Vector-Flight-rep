using System;
namespace VectorFlight;

public abstract class Flyable : IFlyable

{
    public abstract string Name { get; }

    public abstract int Speed { get; internal set; }

    public abstract float Distance { get; internal set; }

    public abstract Coordinate CurrentCoordinate { get; internal set; }

    public abstract void FlyTo(Coordinate coordinate);

    public abstract float GetFlyTime(Coordinate coordinate);

    public float MakeDistance(Coordinate coordinate)
    {
        int x, y, z, x2, y2, z2;
 
        Console.Title = "Please enter initial coordinates ";
        Console.Write("x1 number is: ");
       x = int.Parse(Console.ReadLine());
        Console.Write("y1 number is: ");
        y = int.Parse(Console.ReadLine());
        Console.Write("z1 number is: ");
        z = int.Parse(Console.ReadLine());

        Console.Title = "Please enter final coordinates ";
        Console.Write("x2 number is: ");
        x2 = int.Parse(Console.ReadLine());
        Console.Write("y2 number is: ");
        y2 = int.Parse(Console.ReadLine());
        Console.Write("z3 number is: ");
        z2 = int.Parse(Console.ReadLine());

        float distance = (float)Math.Sqrt ((x2 - x) * (x2 - x) + (y2 - y) * (y2 - y) + (z2 - z) * (z2 - z));

        return distance;
    }
}

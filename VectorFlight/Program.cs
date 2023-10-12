using System;
using System.Diagnostics;
using System.Text;
using VectorFlight;

namespace VectorFlight;

internal class Program
{
    public static void Main(string[] args)
    {
        var items = new List<IFlyable>()
        {
            new Bird(),
            new Airplane(),
            new Drone()
        };

        foreach (var item in items)
        {
            item.FlyTo(new Coordinate()); //начальная координата

            var time = item.GetFlyTime(new Coordinate()); //конечная координата

            Console.WriteLine($"{item.Name}, Speed: {item.Speed} km/h, Distance: {Math.Round(item.Distance, 2)} km, Time: {time} h");
        }
    }
}

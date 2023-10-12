using System;
namespace VectorFlight;

public class Bird : Flyable

{
    public override string Name => "Bird";
    public override int Speed { get; internal set; } = (new Random()).Next(0, 21);
    public override Coordinate CurrentCoordinate { get; internal set; }
    public override float Distance { get; internal set; }

    //Использовать следующие предположения: птица летит все расстояние с постоянной скоростью
    //в диапазоне 0-20 км/ч(заданной случайно), 

    public override void FlyTo(Coordinate coordinate)
    {
        CurrentCoordinate = coordinate;
    }

    public override float GetFlyTime(Coordinate coordinate)
    {
        if (Speed == 0)
        {
            return 0;
        }


        Distance = MakeDistance(coordinate);

        return (float)Math.Round((Distance / Speed), 2);
    }
}

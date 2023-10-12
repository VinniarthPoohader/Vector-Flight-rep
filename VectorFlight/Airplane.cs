using System;
namespace VectorFlight;

public class Airplane : Flyable
{
    public override string Name => "Airplane";
    public override int Speed { get; internal set; } = 200;
    public override Coordinate CurrentCoordinate { get; internal set; }
    public override float Distance { get; internal set; }

    //самолет увеличивает скорость на 10 км/ч каждые 10 км полета от начальной скорости 200 км/ч

    public override void FlyTo(Coordinate coordinate)
    {
        CurrentCoordinate = coordinate;
    }

    public override float GetFlyTime(Coordinate coordinate)
    {
        Distance = MakeDistance(coordinate);

        if (Distance > 200)
        {
            var distanceLeft = Distance - 200;

            double allTime = 1;

            while (distanceLeft > 0 && (distanceLeft / 10) >= 1)
            {
                var time = (double)10 / Speed;

                distanceLeft -= 10;

                Speed += 10;

                allTime += time;
            }

            if (distanceLeft > 0)
            {
                allTime += distanceLeft / Speed;
            }

            return (float)Math.Round(allTime, 2);
        }
        else
        {
            return (float)Math.Round((Distance / Speed), 2);
        }
    }
}
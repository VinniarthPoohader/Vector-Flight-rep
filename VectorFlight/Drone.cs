using System;
namespace VectorFlight;

public class Drone : Flyable
{
    public override string Name => "Drone";
    public override int Speed { get; internal set; } = 50;
    public override Coordinate CurrentCoordinate { get; internal set; }
    public override float Distance { get; internal set; }

    //дрон зависает в воздухе каждые 10 минут полета на 1 минуту.
    //Исходя из задачи, ввести дополнительные ограничения(например, невозможность полета дрона на дальность более чем на 1000 км). 

    public override void FlyTo(Coordinate coordinate)
    {
        CurrentCoordinate = coordinate;
    }

    public override float GetFlyTime(Coordinate coordinate)
    {
        Distance = MakeDistance(coordinate);

        Distance = Distance > 1000 ? 1000 : Distance; //не может улететь дальше 1000км

        var distanceLeft = Distance;

        double allTime = 0;

        var distPerTenMinutes = (float)((double)10 / 60) * Speed; //10 минут делим на 60 - минут в часе

        while (distanceLeft > 0 && distanceLeft > distPerTenMinutes)
        {
            distanceLeft -= distPerTenMinutes;

            allTime += (double)(10 + 1) / 60; //10 минут плюс 1 минута делим на 60 что бы получить время в часах
        }

        if (distanceLeft > 0)
        {
            allTime += (double)(distanceLeft / Speed);
        }

        return (float)Math.Round(allTime, 2);
    }
}


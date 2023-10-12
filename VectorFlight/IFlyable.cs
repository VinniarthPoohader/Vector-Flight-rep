using System;
namespace VectorFlight;

public interface IFlyable
{ 
    string Name { get; } //имя летательного объекта

    float Distance { get; } // расстояние до точки

    Coordinate CurrentCoordinate { get; } //текущие координаты

    int Speed { get; } //скорость

    void FlyTo(Coordinate coordinate); //координаты точки назначения

    float GetFlyTime(Coordinate coordinate); //время до точки назначения
}

using System;
namespace VectorFlight;

public struct Coordinate

{

    private int _x;
    public int X
    {
        get { return _x; }
        set
        {
            if (value > 0)
            {
                _x = value;
            }
            else
            {
                _x = 0;
            }
        }
    }

    private int _y;
    public int Y
    {
        get { return _y; }
        set
        {
            if (value > 0)
            {
                _y = value;
            }
            else
            {
                _y = 0;
            }
        }
    }

    private int _z;
    public int Z
    {
        get { return _z; }
        set
        {
            if (value > 0)
            {
                _z = value;
            }
            else
            {
                _z = 0;
            }
        }
    }
}

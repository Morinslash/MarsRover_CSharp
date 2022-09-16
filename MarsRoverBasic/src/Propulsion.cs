using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic;

public class Propulsion
{
    public Coordinates Move(Coordinates coordinates, Coordinates moveVector)
    {
        return new Coordinates { X = coordinates.X + moveVector.X, Y = coordinates.Y + moveVector.Y };
    }
}
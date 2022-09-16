using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic;

public class Propulsion
{
    public Coordinates Move(Coordinates coordinates, Coordinates moveVector)
    {
        return new Coordinates { Longitude = coordinates.Longitude + moveVector.Longitude, Latitude = coordinates.Latitude + moveVector.Latitude };
    }
}
namespace MarsRoverBasic;

public class Propulsion
{
    public Coordinates Move(Coordinates coordinates, Coordinates moveVector, Grid grid)
    {
        var newCoordinates = new Coordinates { X = coordinates.X + moveVector.X, Y = coordinates.Y + moveVector.Y };
        return new Coordinates { X = grid.Wrap(newCoordinates.X), Y = grid.Wrap(newCoordinates.Y) };
    }
}
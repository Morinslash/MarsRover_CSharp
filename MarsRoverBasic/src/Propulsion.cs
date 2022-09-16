namespace MarsRoverBasic;

public class Propulsion
{
    public Coordinates Move(Coordinates coordinates, Compass compass, Grid grid) =>
        compass.Direction switch
        {
            "N" => coordinates with { Y = grid.Wrap(coordinates.Y + 1) },
            "S" => coordinates with { Y = grid.Wrap(coordinates.Y - 1) },
            "E" => coordinates with { X = grid.Wrap(coordinates.X + 1) },
            "W" => coordinates with { X = grid.Wrap(coordinates.X - 1) },
            _ => coordinates
        };

    public Coordinates Move(Coordinates coordinates, Coordinates moveVector, Grid grid)
    {
        return new Coordinates { X = coordinates.X + moveVector.X, Y = coordinates.Y + moveVector.Y };
    }
}
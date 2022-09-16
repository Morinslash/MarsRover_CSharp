namespace MarsRoverBasic;

public class Propulsion
{
    public Coordinates Move(Coordinates coordinates, Compass compass, Grid grid) =>
        compass.Direction switch
        {
            "E" => coordinates with { X = grid.Wrap(coordinates.X + 1) },
            "N" => coordinates with { Y = grid.Wrap(coordinates.Y + 1) },
            "S" => coordinates with { Y = grid.Wrap(coordinates.Y - 1) },
            "W" => coordinates with { X = grid.Wrap(coordinates.X - 1) },
            _ => coordinates
        };
}
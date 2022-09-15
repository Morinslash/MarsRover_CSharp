namespace MarsRoverBasic;

public class Propulsion
{
    public Coordinates Move(Coordinates coordinates, Compass compass, Grid grid)
    {
        if (compass.Direction.Equals("E"))
        {
            return coordinates with { X = grid.Wrap(coordinates.X + 1) };
        }

        if (compass.Direction.Equals("N"))
        {
            return coordinates with { Y = grid.Wrap(coordinates.Y + 1) };
        }

        return coordinates;
    }
}
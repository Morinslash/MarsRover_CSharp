namespace MarsRoverBasic;

public class Navigation
{
    private Compass _compass;
    private readonly Grid _grid;
    public Coordinates Coordinates { get; private set; }

    public string NavigationOutput => $"{Coordinates.X}:{Coordinates.Y}:{_compass.Direction}";

    public Navigation(Compass compass, Coordinates coordinates, Grid grid)
    {
        _compass = compass;
        Coordinates = coordinates;
        _grid = grid;
    }

    public void Set(Compass compass)
    {
        _compass = compass;
    }

    public void Set(Coordinates coordinates)
    {
        Coordinates = _grid.Wrap(coordinates);
    }

    public Compass TurnLeft() => _compass.TurnLeft();
    public Compass TurnRight() => _compass.TurnRight();
    public Coordinates GetMoveVector() => _compass.GetMoveVector();
}
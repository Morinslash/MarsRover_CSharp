namespace MarsRoverBasic.NavigationModule;

public class Navigation
{
    private readonly Compass _compass;
    private readonly Grid _grid;
    public Coordinates Coordinates { get; private set; }

    public string NavigationOutput => $"{Coordinates.X}:{Coordinates.Y}:{_compass.Direction}";

    public Navigation(Compass compass, Coordinates coordinates, Grid grid)
    {
        _compass = compass;
        Coordinates = coordinates;
        _grid = grid;
    }
    
    public void Set(Coordinates coordinates)
    {
        Coordinates = _grid.Wrap(coordinates);
    }

    public void TurnLeft() => _compass.TurnLeft();
    public void TurnRight() => _compass.TurnRight();
    public Coordinates GetMoveVector() => _compass.GetMoveVector();
}
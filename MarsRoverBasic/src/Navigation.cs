namespace MarsRoverBasic;

public class Navigation
{
    private Compass _compass;
    public Coordinates Coordinates { get; private set; }

    public string NavigationOutput => $"{Coordinates.X}:{Coordinates.Y}:{_compass.Direction}";

    public Navigation(Compass compass, Coordinates coordinates)
    {
        _compass = compass;
        Coordinates = coordinates;
    }

    public void Set(Compass compass)
    {
        _compass = compass;
    }

    public void Set(Coordinates coordinates)
    {
        Coordinates = coordinates;
    }

    public Compass TurnLeft() => _compass.TurnLeft();

    public Compass TurnRight() => _compass.TurnRight();
    public Coordinates GetMoveVector() => _compass.GetMoveVector();
}
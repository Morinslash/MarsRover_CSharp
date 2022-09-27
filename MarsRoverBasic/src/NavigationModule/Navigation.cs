using MarsRoverBasic.NavigationModule.Directions;

namespace MarsRoverBasic.NavigationModule;

public class Navigation
{
    private readonly Grid _grid;
    private Direction CurrentDirection { get; set; }
    public Coordinates CurrentPosition { get; private set; }

    public string NavigationOutput => $"{CurrentPosition.Longitude}:{CurrentPosition.Latitude}:{CurrentDirection.Symbol}";

    public Navigation(Direction currentDirection, Coordinates currentPosition, Grid grid)
    {
        _grid = grid;
        CurrentDirection = currentDirection;
        CurrentPosition = currentPosition;
    }
    
    public void Set(Coordinates coordinates)
    {
        CurrentPosition = _grid.Wrap(coordinates);
    }

    public void TurnLeft() => CurrentDirection = CurrentDirection.Left;
    public void TurnRight() => CurrentDirection = CurrentDirection.Right;
    public Coordinates GetMoveVector() => CurrentDirection.Vector;
}
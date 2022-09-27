using MarsRoverBasic.NavigationModule.Directions;

namespace MarsRoverBasic.NavigationModule;

public class Navigation
{
    private readonly Grid _grid;
    public Direction CurrentDirection { get; private set; }
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

    public void Set(Direction newDirection)
    {
        CurrentDirection = newDirection;
    }

    public Coordinates GetMoveVector() => CurrentDirection.Vector;
}
using MarsRoverBasic.NavigationModule.Directions;

namespace MarsRoverBasic.NavigationModule;

public class Compass
{
    private Direction _currentDirection;

    public Compass(Direction currentDirection)
    {
        _currentDirection = currentDirection;
    }

    public string Direction => _currentDirection.Symbol;

    public void TurnRight() => _currentDirection = _currentDirection.Right;

    public void TurnLeft() => _currentDirection = _currentDirection.Left;

    public Coordinates GetMoveVector() => _currentDirection.Vector;
}
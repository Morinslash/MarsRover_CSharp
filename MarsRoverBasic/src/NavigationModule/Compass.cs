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

    public void TurnRight() => SetDirection(_currentDirection.Right);

    public void TurnLeft() => SetDirection(_currentDirection.Left);

    public Coordinates GetMoveVector() => _currentDirection.Vector;

    private void SetDirection(Direction value)
    {
        _currentDirection = value;
    }
}
using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic.CommModule;

public class Move : IRoverCommand
{
    private readonly Navigation _navigation;

    public Move(Navigation navigation)
    {
        _navigation = navigation;
    }

    public void CanExecute()
    {
        if (!_navigation.ObstacleDetected)
        {
            Execute();
        }
    }

    public void Execute()
    {
        var newCoordinates = CalculateNewCoordinates();
        _navigation.CheckObstaclesAt(newCoordinates);
        if (!_navigation.ObstacleDetected)
        {
            _navigation.Set(newCoordinates);
        }
    }

    private Coordinates CalculateNewCoordinates()
    {
        var currentCoordinates = _navigation.CurrentPosition;
        var moveVector = _navigation.GetMoveVector();
        Coordinates newCoordinates = new()
        {
            Longitude = currentCoordinates.Longitude + moveVector.Longitude,
            Latitude = currentCoordinates.Latitude + moveVector.Latitude
        };
        return newCoordinates;
    }
}
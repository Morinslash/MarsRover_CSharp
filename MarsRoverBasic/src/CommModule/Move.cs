using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic.CommModule;

public class Move : RoverCommand
{

    public Move(Navigation navigation) : base(navigation)
    {
    }
    
    protected override void Execute()
    {
        var newCoordinates = CalculateNewCoordinates();
        Navigation.CheckObstaclesAt(newCoordinates);
        if (!Navigation.ObstacleDetected)
        {
            Navigation.Set(newCoordinates);
        }
    }

    private Coordinates CalculateNewCoordinates()
    {
        var currentCoordinates = Navigation.CurrentPosition;
        var moveVector = Navigation.GetMoveVector();
        Coordinates newCoordinates = new()
        {
            Longitude = currentCoordinates.Longitude + moveVector.Longitude,
            Latitude = currentCoordinates.Latitude + moveVector.Latitude
        };
        return newCoordinates;
    }
}
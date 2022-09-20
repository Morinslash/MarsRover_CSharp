using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic.CommModule;

public class Move : IRoverCommand
{
    private readonly Navigation _navigation;

    public Move(Navigation navigation)
    {
        _navigation = navigation;
    }

    public void Execute()
    {
        var currentCoordinates = _navigation.Coordinates;
        var moveVector = _navigation.GetMoveVector();
        Coordinates newCoordinates = new()
        {
            Longitude = currentCoordinates.Longitude + moveVector.Longitude, 
            Latitude = currentCoordinates.Latitude + moveVector.Latitude
        };
        _navigation.Set(newCoordinates);
    }
}
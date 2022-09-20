using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic.CommModule;

public class Move : IRoverCommand
{
    private readonly Navigation _navigation;
    private readonly Propulsion _propulsion;

    public Move(Navigation navigation, Propulsion propulsion)
    {
        _navigation = navigation;
        _propulsion = propulsion;
    }

    public void Execute()
    {
        var newCoordinates = _propulsion.Move(_navigation.Coordinates, _navigation.GetMoveVector());
        _navigation.Set(newCoordinates);
    }
}
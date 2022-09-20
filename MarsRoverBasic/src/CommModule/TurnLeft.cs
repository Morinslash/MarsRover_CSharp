using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic.CommModule;

public class TurnLeft : IRoverCommand
{
    private readonly Navigation _navigation;

    public TurnLeft(Navigation navigation)
    {
        _navigation = navigation;
    }

    public void Execute()
    {
        _navigation.TurnLeft();
    }
}
using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic.CommModule;

public class TurnRight : IRoverCommand
{
    private readonly Navigation _navigation;

    public TurnRight(Navigation navigation)
    {
        _navigation = navigation;
    }

    public void Execute()
    {
        _navigation.CurrentDirection.Right(_navigation);
    }

    public void CanExecute()
    {
        if (!_navigation.ObstacleDetected)
        {
            Execute();
        }
    }
}
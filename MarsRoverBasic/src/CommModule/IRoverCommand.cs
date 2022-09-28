using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic.CommModule;

public abstract class RoverCommand
{
    protected readonly Navigation Navigation;

    public RoverCommand(Navigation navigation)
    {
        Navigation = navigation;
    }
    public void CanExecute()
    {
        if (!Navigation.ObstacleDetected)
        {
            Execute();
        }
    }

    protected abstract void Execute();
}
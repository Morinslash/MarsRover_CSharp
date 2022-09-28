using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic.CommModule;

public class TurnRight : RoverCommand
{
    public TurnRight(Navigation navigation) : base(navigation)
    {
    }

    protected override void Execute()
    {
        Navigation.CurrentDirection.Right(Navigation);
    }
}
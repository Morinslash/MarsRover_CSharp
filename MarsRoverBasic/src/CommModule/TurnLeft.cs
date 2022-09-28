using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic.CommModule;

public class TurnLeft : RoverCommand
{
    public TurnLeft(Navigation navigation) : base(navigation)
    {
    }

    protected override void Execute()
    {
        
        Navigation.CurrentDirection.Left(Navigation);
    }
}
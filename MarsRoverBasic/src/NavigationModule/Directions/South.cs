namespace MarsRoverBasic.NavigationModule.Directions;

public record South : Direction
{
    public override string Symbol => "S";
    public override Direction Left => new East();
    public override Direction Right => new West();
    public override Coordinates Vector => new() { Longitude = 0, Latitude = -1 };
}
namespace MarsRoverBasic.NavigationModule.Directions;

public record North : Direction
{
    public override string Symbol => "N";
    public override Direction Left => new West();
    public override Direction Right => new East();
    public override Coordinates Vector => new() { Longitude = 0, Latitude = 1 };
}
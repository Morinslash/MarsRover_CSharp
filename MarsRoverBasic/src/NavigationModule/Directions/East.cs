namespace MarsRoverBasic.NavigationModule.Directions;

public record East : Direction
{
    public override string Symbol => "E";
    public override Direction Left => new North();
    public override Direction Right => new South();
    public override Coordinates Vector => new() { Longitude = 1, Latitude = 0 };
}
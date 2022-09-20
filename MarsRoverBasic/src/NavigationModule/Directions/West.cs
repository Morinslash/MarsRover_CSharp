namespace MarsRoverBasic.NavigationModule.Directions;

public record West : Direction
{
    public override string Symbol => "W";
    public override Direction Left => new South();
    public override Direction Right => new North();
    public override Coordinates Vector => new() { Longitude = -1, Latitude = 0 };
}
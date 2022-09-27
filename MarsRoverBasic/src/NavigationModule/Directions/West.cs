namespace MarsRoverBasic.NavigationModule.Directions;

public record West : Direction
{
    public override string Symbol => "W";
    public override void Left(Navigation navigation) => navigation.Set(new South());
    public override void Right(Navigation navigation) => navigation.Set(new North());
    public override Coordinates Vector => new() { Longitude = -1, Latitude = 0 };
}
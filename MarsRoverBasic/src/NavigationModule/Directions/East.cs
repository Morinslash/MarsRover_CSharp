namespace MarsRoverBasic.NavigationModule.Directions;

public record East : Direction
{
    public override string Symbol => "E";
    public override void Left(Navigation navigation) => navigation.Set(new North());
    public override void Right(Navigation navigation) => navigation.Set(new South());
    public override Coordinates Vector => new() { Longitude = 1, Latitude = 0 };
}
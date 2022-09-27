namespace MarsRoverBasic.NavigationModule.Directions;

public record North : Direction
{
    public override string Symbol => "N";
    public override void Left(Navigation navigation) => navigation.Set(new West());
    public override void Right(Navigation navigation) => navigation.Set(new East());
    public override Coordinates Vector => new() { Longitude = 0, Latitude = 1 };
}
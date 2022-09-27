namespace MarsRoverBasic.NavigationModule.Directions;

public record South : Direction
{
    public override string Symbol => "S";
    public override void Left(Navigation navigation) => navigation.Set(new East());
    public override void Right(Navigation navigation) => navigation.Set(new West());
    public override Coordinates Vector => new() { Longitude = 0, Latitude = -1 };
}
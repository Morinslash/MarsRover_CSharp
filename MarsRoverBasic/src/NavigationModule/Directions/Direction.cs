namespace MarsRoverBasic.NavigationModule.Directions;

public abstract record Direction
{
    public abstract string Symbol { get; }
    public abstract Direction Left { get; }
    public abstract Direction Right { get; }
    public abstract Coordinates Vector { get; }
};

public record North : Direction
{
    public override string Symbol => "N";
    public override Direction Left => new West();
    public override Direction Right => new East();
    public override Coordinates Vector => new Coordinates { Longitude = 0, Latitude = 1 };
}

public record South : Direction
{
    public override string Symbol => "S";
    public override Direction Left => new East();
    public override Direction Right => new West();
    public override Coordinates Vector => new Coordinates { Longitude = 0, Latitude = -1 };
}

public record East : Direction
{
    public override string Symbol => "E";
    public override Direction Left => new North();
    public override Direction Right => new South();
    public override Coordinates Vector => new Coordinates { Longitude = 1, Latitude = 0 };
}

public record West : Direction
{
    public override string Symbol => "W";
    public override Direction Left => new South();
    public override Direction Right => new North();
    public override Coordinates Vector => new Coordinates { Longitude = -1, Latitude = 0 };
}
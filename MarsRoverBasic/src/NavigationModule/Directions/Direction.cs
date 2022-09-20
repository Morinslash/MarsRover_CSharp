namespace MarsRoverBasic.NavigationModule.Directions;

public abstract record Direction
{
    public abstract string Symbol { get; }
    public abstract Direction Left { get; }
    public abstract Direction Right { get; }
    public abstract Coordinates Vector { get; }
};
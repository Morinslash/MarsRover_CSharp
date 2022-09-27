namespace MarsRoverBasic.NavigationModule.Directions;

public abstract record Direction
{
    public abstract string Symbol { get; }
    public abstract void Left(Navigation navigation);
    public abstract void Right(Navigation navigation);
    public abstract Coordinates Vector { get; }
};
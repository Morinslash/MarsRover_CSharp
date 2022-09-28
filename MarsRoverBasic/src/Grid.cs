using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic;

public class Grid
{
    private readonly List<Coordinates>? _obstacles;

    public Grid(int size)
    {
        Size = size;
    }

    public Grid(int size, List<Coordinates>? obstacles) : this(size)
    {
        _obstacles = obstacles;
    }

    private int Size { get; }

    public int Wrap(int value) => value < 0 ? Size - 1 : value % Size;

    public Coordinates Wrap(Coordinates coordinates) => new()
    {
        Longitude = Wrap(coordinates.Longitude),
        Latitude = Wrap(coordinates.Latitude)
    };

    public bool ObstacleExists(Coordinates coordinates) => _obstacles?.Contains(coordinates) ?? false;
}
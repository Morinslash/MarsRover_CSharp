using MarsRoverBasic.NavigationModule;

namespace MarsRoverBasic;

public class Grid
{
    public Grid(int size)
    {
        Size = size;
    }

    private int Size { get; }

    public int Wrap(int value) => value < 0 ? Size - 1 : value % Size;

    public Coordinates Wrap(Coordinates coordinates) => new()
    {
        Longitude = Wrap(coordinates.Longitude),
        Latitude = Wrap(coordinates.Latitude)
    };
}
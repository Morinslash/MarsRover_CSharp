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
        X = Wrap(coordinates.X),
        Y = Wrap(coordinates.Y)
    };
}
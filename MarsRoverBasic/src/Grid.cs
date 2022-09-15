namespace MarsRoverBasic;

public class Grid
{
    public Grid(int size)
    {
        Size = size;
    }
    private int Size { get; }

    public int Wrap(int value) => value % Size;
    }
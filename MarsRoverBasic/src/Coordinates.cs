namespace MarsRoverBasic;

public class Coordinates
{
    public readonly int Y;
    public readonly int X;
    private readonly int _worldGridSize;

    public Coordinates(int y, int x, int worldGridSize)
    {
        Y = y % worldGridSize;
        X = x % worldGridSize;
    }
}
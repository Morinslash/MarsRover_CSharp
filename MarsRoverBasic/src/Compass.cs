namespace MarsRoverBasic;

public class Compass
{
    private readonly Dictionary<string, Coordinates> _vectorMap;
        
    public string Direction { get; }


    public Compass(string direction)
    {
        Direction = direction;
        _vectorMap = new Dictionary<string, Coordinates>()
        {
            { "N", new Coordinates { X = 0, Y = 1 } },
            { "S", new Coordinates { X = 0, Y = -1 } },
            { "E", new Coordinates { X = 1, Y = 0 } },
            { "W", new Coordinates { X = -1, Y = 0 } },
        };
    }


    public Compass TurnRight() => Direction switch
    {
        "N" => new Compass("E"),
        "E" => new Compass("S"),
        "S" => new Compass("W"),
        _ => new Compass("N")
    };

    public Compass TurnLeft() => Direction switch
        {
            "N" => new Compass("W"),
            "W" => new Compass("S"),
            "S" => new Compass("E"),
            _ => new Compass("N")
        };

    public Coordinates GetMoveVector()
    {
        return _vectorMap.GetValueOrDefault(Direction) ?? throw new InvalidOperationException();
    }

}
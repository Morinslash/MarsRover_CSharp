namespace MarsRoverBasic;

public class Compass
{
    public Compass(string direction)
    {
        Direction = direction;
    }

    public string Direction { get; }

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
    }
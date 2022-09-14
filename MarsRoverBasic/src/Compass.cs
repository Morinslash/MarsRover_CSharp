namespace MarsRoverBasic;

public class Compass
{
    public Compass(string direction)
    {
        Direction = direction;
    }

    public string Direction { get; private set; }

    public void TurnRight()
    {
        Direction = Direction switch
        {
            "N" => "E",
            "E" => "S",
            "S" => "W",
            _ => "N"
        };
    }

    public void TurnLeft()
    {
        Direction = Direction switch
        {
            "N" => "W",
            "W" => "S",
            "S" => "E",
            _ => "N"
        };
    }
}
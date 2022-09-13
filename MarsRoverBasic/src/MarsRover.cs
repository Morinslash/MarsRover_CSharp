using System.Linq;
using System.Runtime.CompilerServices;

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

public class MarsRover
{
    private readonly Compass _compass;

    public MarsRover()
    {
        _compass = new Compass("N");
    }

    public string Execute(string command)
    {
        foreach (var symbol in command)
        {
            if (symbol.Equals('L'))
            {
                _compass.TurnLeft();
            }

            if (symbol.Equals('R'))
            {
                _compass.TurnRight();
            }
        }

        return $"0:0:{_compass.Direction}";
    }
}
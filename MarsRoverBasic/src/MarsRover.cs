using System.Linq;

namespace MarsRoverBasic;

public class MarsRover
{
    public MarsRover()
    {
        Direction = "N";
    }

    public string Direction { get; private set; }

    public string Execute(string command)
    {
        foreach (var symbol in command)
        {
            if (symbol.Equals('R'))
            {
                TurnRight();
            }

            if (symbol.Equals('L'))
            {
                TurnLeft();
            }
        }

        return $"0:0:{Direction}";
    }

    private void TurnRight()
    {
        Direction = Direction switch
        {
            "N" => "E",
            "E" => "S",
            "S" => "W",
            _ => "N"
        };
    }

    private void TurnLeft()
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
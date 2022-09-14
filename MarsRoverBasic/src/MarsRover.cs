namespace MarsRoverBasic;

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
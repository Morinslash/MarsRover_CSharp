namespace MarsRoverBasic;

public class MarsRover
{
    private Compass _compass;

    public MarsRover()
    {
        _compass = new Compass("N");
    }

    public string Execute(string commands)
    {
        foreach (var command in commands)
        {
            Process(command);
        }

        return $"0:0:{_compass.Direction}";
    }

    private void Process(char command)
    {
        if (command.Equals('L'))
        {
            _compass = _compass.TurnLeft();
        }

        if (command.Equals('R'))
        {
            _compass = _compass.TurnRight();
        }
    }
}
namespace MarsRoverBasic;

public class MarsRover
{
    private Compass _compass;
    private Coordinates _coordinates;
    private Grid WorldGrid { get; init; }
    private string NavigationOutput => $"{_coordinates.X}:{_coordinates.Y}:{_compass.Direction}";

    public MarsRover(Grid worldGrid)
    {
        WorldGrid = worldGrid;
        _compass = new Compass("N");
        _coordinates = new Coordinates { Y = 0, X = 0};
    }

    public string Execute(string commands)
    {
        foreach (var command in commands)
        {
            Process(command);
        }

        return NavigationOutput;
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

        if (command.Equals('M'))
        {
            if (_compass.Direction.Equals("E"))
            {
                _coordinates = _coordinates with { X = WorldGrid.Wrap(_coordinates.X + 1) };
            }
            else
            {
                _coordinates = _coordinates with { Y = WorldGrid.Wrap(_coordinates.Y + 1) };
            }
        }
    }
}
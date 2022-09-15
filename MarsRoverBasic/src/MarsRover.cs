namespace MarsRoverBasic;

public class MarsRover
{
    private Compass _compass;
    private Coordinates _coordinates;
    private Grid WorldGrid { get; init; }
    public string NavigationOutput => $"{_coordinates.X}:{_coordinates.Y}:{_compass.Direction}";

    public MarsRover(Grid worldGrid)
    {
        this.WorldGrid = worldGrid;
        _compass = new Compass("N");
        _coordinates = new Coordinates(0, 0, worldGrid.Size);
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
                _coordinates = new(_coordinates.Y, _coordinates.X + 1, WorldGrid.Size);
            }
            else
            {
                _coordinates = new(_coordinates.Y + 1, _coordinates.X, WorldGrid.Size);
            }
        }
    }
}
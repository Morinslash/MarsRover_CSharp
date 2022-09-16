namespace MarsRoverBasic;

public class MarsRover
{
    private readonly Grid _grid;
    private readonly Propulsion _propulsion;
    private Compass _compass;
    private Coordinates _coordinates;
    private string NavigationOutput => $"{_coordinates.X}:{_coordinates.Y}:{_compass.Direction}";

    public MarsRover(Grid grid)
    {
        _grid = grid;
        _compass = new Compass("N");
        _coordinates = new Coordinates { Y = 0, X = 0 };
        _propulsion = new Propulsion();
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
        switch (command)
        {
            case 'L':
                _compass = _compass.TurnLeft();
                break;
            case 'R':
                _compass = _compass.TurnRight();
                break;
            case 'M':
                _coordinates = _propulsion.Move(_coordinates, _compass.GetMoveVector(), _grid);
                break;
        }
    }
}
namespace MarsRoverBasic;

public class MarsRover
{
    private readonly Grid _grid;
    private readonly Propulsion _propulsion;
    private readonly Navigation _navigation;

    public MarsRover(Grid grid)
    {
        _grid = grid;
        _navigation = new Navigation(new Compass("N"), new Coordinates { Y = 0, X = 0 });
        _propulsion = new Propulsion();
    }

    public string Execute(string commands)
    {
        foreach (var command in commands)
        {
            Process(command);
        }

        return _navigation.NavigationOutput;
    }


    private void Process(char command)
    {
        switch (command)
        {
            case 'L':
                _navigation.Set(_navigation.TurnLeft());
                break;
            case 'R':
                _navigation.Set(_navigation.TurnRight());
                break;
            case 'M':
                _navigation.Set(_propulsion.Move(_navigation.Coordinates, _navigation.GetMoveVector(), _grid));
                break;
        }
    }
}
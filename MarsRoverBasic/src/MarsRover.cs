using MarsRoverBasic.NavigationModule;
using MarsRoverBasic.NavigationModule.Directions;

namespace MarsRoverBasic;

public class MarsRover
{
    private readonly Propulsion _propulsion;
    private readonly Navigation _navigation;

    public MarsRover(Grid grid)
    {
        var initialCompass = new Compass(new North());
        var initialCoordinates = new Coordinates { Y = 0, X = 0 };
        _navigation = new Navigation(initialCompass, initialCoordinates, grid);
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
                _navigation.TurnLeft();
                break;
            case 'R':
               _navigation.TurnRight();
                break;
            case 'M':
                _navigation.Set(_propulsion.Move(_navigation.Coordinates, _navigation.GetMoveVector()));
                break;
            default:
                throw new InvalidOperationException();
        }
    }
}
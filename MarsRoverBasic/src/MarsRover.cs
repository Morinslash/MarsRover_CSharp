namespace MarsRoverBasic;

public class MarsRover
{
    private Compass _compass;
    private int _y;
    private Grid WorldGrid { get; init; }

    public MarsRover(Grid worldGrid)
    {
        this.WorldGrid = worldGrid;
        _compass = new Compass("N");
        _y = 0;
    }

    public string Execute(string commands)
    {
        foreach (var command in commands)
        {
            Process(command);
            if (command.Equals('M'))
            {
                
                _y = (_y +1 ) % WorldGrid.Size;
            }
        }

        return $"0:{_y}:{_compass.Direction}";
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
using MarsRoverBasic.CommModule;
using MarsRoverBasic.NavigationModule;
using MarsRoverBasic.NavigationModule.Directions;

namespace MarsRoverBasic;

public class MarsRover
{
    private readonly Navigation _navigation;
    private readonly CommunicationModule _commModule;
    public Navigation Navigation => _navigation;

    public MarsRover(Grid grid)
    {
        Coordinates initialCoordinates = new(latitude: 0, longitude: 0);
        Compass initialCompass = new(new North());
        _navigation = new(initialCompass, initialCoordinates, grid);
        _commModule = new(this);
    }

    public string Execute(string instructions)
    {
        if (!string.IsNullOrEmpty(instructions))
        {
            _commModule.Translate(instructions).ForEach(com => com.Execute());
        }

        return _navigation.NavigationOutput;
    }
}
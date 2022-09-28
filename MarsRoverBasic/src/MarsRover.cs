using MarsRoverBasic.CommModule;
using MarsRoverBasic.NavigationModule;
using MarsRoverBasic.NavigationModule.Directions;

namespace MarsRoverBasic;

public class MarsRover
{
    private readonly CommunicationModule _commModule;
    public Navigation Navigation { get; }

    public MarsRover(Grid grid)
    {
        Coordinates initialCoordinates = new(latitude: 0, longitude: 0);
        Navigation = new Navigation(new North(), initialCoordinates, grid);
        _commModule = new CommunicationModule(this);
    }

    public string Execute(string instructions)
    {
        if (!string.IsNullOrEmpty(instructions))
        {
            _commModule.Translate(instructions)
                .ForEach(command => command.CanExecute());
        }

        return Navigation.NavigationOutput;
    }
}
namespace MarsRoverBasic.CommModule;

public class CommunicationModule
{
    private readonly Dictionary<char, Func<RoverCommand>> _commandsMap;

    public CommunicationModule(MarsRover marsRover)
    {
        _commandsMap = new Dictionary<char, Func<RoverCommand>>()
        {
            { 'L',  () => new TurnLeft(marsRover.NavigationSystem) },
            { 'R', () => new TurnRight(marsRover.NavigationSystem)},
            { 'M',  () => new Move(marsRover.NavigationSystem)}
        };
    }

    public List<RoverCommand> Translate(string instructions)
    {
        return instructions
            .Select(c => _commandsMap.GetValueOrDefault(c))
            .Select(f => f?.Invoke())
            .ToList()!;
    }
}
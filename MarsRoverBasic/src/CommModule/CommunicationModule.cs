namespace MarsRoverBasic.CommModule;

public class CommunicationModule
{
    private readonly Dictionary<char, Func<RoverCommand>> _commandsMap;

    public CommunicationModule(MarsRover marsRover)
    {
        _commandsMap = new Dictionary<char, Func<RoverCommand>>()
        {
            { 'L',  () =>  new TurnLeft(marsRover.Navigation)},
            { 'R', () => new TurnRight(marsRover.Navigation)},
            { 'M',  () => new Move(marsRover.Navigation)}
        };
    }

    public List<RoverCommand> Translate(string instructions)
        => instructions
            .Select(c => _commandsMap.GetValueOrDefault(c))
            .Select(f => f?.Invoke())
            .ToList()!;
}
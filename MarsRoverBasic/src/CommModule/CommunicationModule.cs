namespace MarsRoverBasic.CommModule;

public class CommunicationModule
{
    private readonly Dictionary<char, Func<IRoverCommand>> _commandsMap;

    public CommunicationModule(MarsRover marsRover)
    {
        _commandsMap = new Dictionary<char, Func<IRoverCommand>>()
        {
            { 'L',  () =>  new TurnLeft(marsRover.Navigation)},
            { 'R', () => new TurnRight(marsRover.Navigation)},
            { 'M',  () => new Move(marsRover.Navigation)}
        };
    }

    public List<IRoverCommand> Translate(string instructions)
        => (string.IsNullOrEmpty(instructions) ? throw new InvalidOperationException() : 
            instructions
                .Select(c => _commandsMap.GetValueOrDefault(c))
                .Select(f => f?.Invoke())
                .ToList())!;
}
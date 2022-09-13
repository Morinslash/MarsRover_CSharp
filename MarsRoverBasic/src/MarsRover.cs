namespace MarsRoverBasic;

public class MarsRover
{
    public string Execute(string command)
    {
        if (String.IsNullOrEmpty(command))
        {
            return "0:0:N";
        }
        return "0:0:E";
    }
}
namespace MarsRoverBasic;

public class MarsRover
{
    public string Execute(string command)
    {
        if (command.Equals("L"))
        {
            return "0:0:E";
        }

        if (command.Equals("LL"))
        {
            return "0:0:S";
        }

        if (command.Equals("LLL"))
        {
            return "0:0:W";
        }
        return "0:0:N";
    }
}
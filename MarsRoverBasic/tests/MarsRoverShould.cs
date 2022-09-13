using Xunit;

namespace MarsRoverBasic.tests;

public class MarsRoverShould
{
    private readonly MarsRover _marsRover;

    public MarsRoverShould()
    {
        _marsRover = new MarsRover();
    }

    [Fact]
    public void Return_Initial_Orientation_When_Command_Is_Empty_String()
    {
        var expectedOutput = "0:0:N";
        Assert.Equal(expectedOutput, _marsRover.Execute(string.Empty));
    }

    [Theory]
    [InlineData("L", "0:0:W")]
    [InlineData("LL", "0:0:S")]
    [InlineData("LLL", "0:0:E")]
    public void Return_Navigation_Data_Matching_Expected_Left_Turns(string command, string output)
    {
        Assert.Equal(output, _marsRover.Execute(command));
    }
    
    [Theory]
    [InlineData("R", "0:0:E")]
    [InlineData("RR", "0:0:S")]
    [InlineData("RRR", "0:0:W")]
    public void Return_Navigation_Data_Matching_Expected_Right_Turns(string command, string output)
    {   
        Assert.Equal(output, _marsRover.Execute(command));
    }
}
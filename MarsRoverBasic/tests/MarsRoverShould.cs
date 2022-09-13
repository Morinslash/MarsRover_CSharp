using Xunit;

namespace MarsRoverBasic.tests;

public class MarsRoverShould
{
    [Fact]
    public void Return_Initial_Orientation_When_Command_Is_Empty_String()
    {
        var expectedOutput = "0:0:N";
        var sut = new MarsRover();
        Assert.Equal(expectedOutput, sut.Execute(string.Empty));
    }

    [Theory]
    [InlineData("L", "0:0:W")]
    [InlineData("LL", "0:0:S")]
    [InlineData("LLL", "0:0:E")]
    public void Return_Navigation_Data_Matching_Expected_Left_Turns(string command, string output)
    {
        var marsRover = new MarsRover();
        Assert.Equal(output, marsRover.Execute(command));
    }
    
    
}
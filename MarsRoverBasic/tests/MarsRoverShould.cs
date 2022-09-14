using Xunit;

namespace MarsRoverBasic.tests;

public class MarsRoverShould
{
    private readonly MarsRover _marsRover;

    public MarsRoverShould()
    {
        var grid = new Grid(10);
        _marsRover = new MarsRover(grid);
    }

    [Fact]
    public void Return_Initial_Orientation_When_Command_Is_Empty_String()
    {
        const string expectedOutput = "0:0:N";
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
    
    [Theory]
    [InlineData("0:1:N", "M")]
    [InlineData("0:2:N", "MM")]
    public void move_Correctly_In_The_North_Direction(string expectedOutput, string command)
    {
        Assert.Equal(expectedOutput, _marsRover.Execute(command));
    }

    [Fact]
    public void Return_to_0_Position_When_Moved_Outside_Of_Grid_Size()
    {
        const string expectedOutput = "0:0:N";
        const string commands = "MMMMMMMMMM";
        Assert.Equal(expectedOutput, _marsRover.Execute(commands));
    }

}
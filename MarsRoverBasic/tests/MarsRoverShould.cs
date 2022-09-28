using MarsRoverBasic.NavigationModule;
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
    [InlineData("0:3:N", "MMM")]
    public void Move_Correctly_In_The_North_Direction(string expectedOutput, string command)
    {
        Assert.Equal(expectedOutput, _marsRover.Execute(command));
    }

    [Fact]
    public void Return_to_0_0_Position_When_Moved_Outside_Of_Grid_Size_In_NorthDirection()
    {
        const string expectedOutput = "0:0:N";
        const string commands = "MMMMMMMMMM";
        Assert.Equal(expectedOutput, _marsRover.Execute(commands));
    }

    [Theory]
    [InlineData("1:0:E", "RM")]
    [InlineData("2:0:E", "RMM")]
    [InlineData("3:0:E", "RMMM")]
    public void Move_Correctly_In_The_East_Direction(string expectedOutput, string command)
    {   
        Assert.Equal(expectedOutput, _marsRover.Execute(command));
    }
    
    [Fact]
    public void Return_to_0_0_Position_When_Moved_Outside_Of_Grid_Size_In_EastDirection()
    {
        const string expectedOutput = "0:0:E";
        const string commands = "RMMMMMMMMMM";
        Assert.Equal(expectedOutput, _marsRover.Execute(commands));
    }
    
    [Theory]
    [InlineData("0:9:S", "RRM")]
    [InlineData("0:8:S", "RRMM")]
    [InlineData("0:7:S", "RRMMM")]
    public void Move_Correctly_In_The_South_Direction(string expectedOutput, string command)
    {   
        Assert.Equal(expectedOutput, _marsRover.Execute(command));
    }
    
    [Fact]
    public void Return_to_0_0_Position_When_Moved_Outside_Of_Grid_Size_In_South_Direction()
    {
        const string expectedOutput = "0:0:S";
        const string commands = "RRMMMMMMMMMM";
        Assert.Equal(expectedOutput, _marsRover.Execute(commands));
    }
    
    [Theory]
    [InlineData("9:0:W", "LM")]
    [InlineData("8:0:W", "LMM")]
    [InlineData("7:0:W", "LMMM")]
    public void Move_Correctly_In_The_West_Direction(string expectedOutput, string command)
    {   
        Assert.Equal(expectedOutput, _marsRover.Execute(command));
    }
    
    [Fact]
    public void Return_to_0_0_Position_When_Moved_Outside_Of_Grid_Size_In_West_Direction()
    {
        const string expectedOutput = "0:0:W";
        const string commands = "LMMMMMMMMMM";
        Assert.Equal(expectedOutput, _marsRover.Execute(commands));
    }

    [Theory]
    [InlineData("o:0:0:N", 1, 0, "M")]
    [InlineData("o:0:1:N", 2, 0, "MM")]
    [InlineData("o:0:1:N", 2, 0, "MMM")]
    [InlineData("1:1:E", 2, 0, "MRM")]
    [InlineData("9:1:W", 2, 0, "MLM")]
    public void Return_Obstacle_On_From_The_Last_Correct_Position(string expected, int latitude, int longitude, string command)
    {
        var obstaclesList = new List<Coordinates> { new(){ Latitude = latitude, Longitude = longitude }};
        var grid = new Grid(10, obstaclesList);
        var marsRover = new MarsRover(grid);

        Assert.Equal(expected, marsRover.Execute(command));
    }
}
using Xunit;

namespace MarsRoverBasic.tests;

public class MarsRoverShould
{
    private readonly MarsRover _marsRover;
    private readonly Grid _grid;

    public MarsRoverShould()
    {
        _grid = new Grid(10);
        _marsRover = new MarsRover(_grid);
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

    [Fact]
    public void Move_One_Field_Up_When_Only_One_M_Command()
    {
        var expectedOutput = "0:1:N";
        Assert.Equal(expectedOutput, _marsRover.Execute("M"));
    }

    [Fact]
    public void Move_Two_Fields_Up_When_Mm_Command()
    {
        var expectedOutput = "0:2:N";
        Assert.Equal(expectedOutput, _marsRover.Execute("MM"));
    }

    [Fact]
    public void Return_to_0_Position_When_Moved_Outside_Of_Grid_Size()
    {
        var expectedOutput = "0:0:N";
        var commands = "MMMMMMMMMM";
        Assert.Equal(expectedOutput, _marsRover.Execute(commands));
    }

}
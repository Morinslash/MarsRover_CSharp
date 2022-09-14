using Xunit;

namespace MarsRoverBasic.tests;

public class CompassShould
{
    [Theory]
    [InlineData("N", "W")]
    [InlineData("W", "S")]
    [InlineData("S", "E")]
    [InlineData("E", "N")]
    public void Change_To_Proper_Left_When_Turning(string startDirection, string newDirection)
    {
        var compass = new Compass(startDirection);
        Assert.Equal(newDirection, compass.TurnLeft().Direction);
    }
    
    [Theory]
    [InlineData("N", "E")]
    [InlineData("E", "S")]
    [InlineData("S", "W")]
    [InlineData("W", "N")]
    public void Change_To_Proper_Right_When_Turning(string startDierection, string newDirection)
    {
        var compass = new Compass(startDierection);
        Assert.Equal(newDirection, compass.TurnRight().Direction);
    }
}
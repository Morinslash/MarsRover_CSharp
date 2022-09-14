using Xunit;

namespace MarsRoverBasic.tests;

public class CompassShould
{
    [Fact]
    public void Change_To_East_On_Turn_Right_When_Facing_North()
    {
        var compass = new Compass("N");
        compass.TurnLeft();
        Assert.Equal("W", compass.Direction);
    }
}
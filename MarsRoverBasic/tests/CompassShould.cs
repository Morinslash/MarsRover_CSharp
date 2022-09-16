using MarsRoverBasic.NavigationModule;
using MarsRoverBasic.NavigationModule.Directions;
using Xunit;

namespace MarsRoverBasic.tests;

public class CompassShould
{
    [Theory]
    [MemberData(nameof(LeftTurn))]
    public void Change_To_Proper_Left_When_Turning(Direction startDirection, string newDirection)
    {
        var compass = new Compass(startDirection);
        compass.TurnLeft();
        Assert.Equal(newDirection, compass.Direction);
    }

    public static IEnumerable<object[]> LeftTurn =>
        new List<object[]>
        {
            new object[] { new North(), "W" },
            new object[] { new West(), "S" },
            new object[] { new South(), "E" },
            new object[] { new East(), "N" },
        };

    [Theory]
    [MemberData(nameof(RightTurn))]
    public void Change_To_Proper_Right_When_Turning(Direction startDierection, string newDirection)
    {
        var compass = new Compass(startDierection);
        compass.TurnRight();
        Assert.Equal(newDirection, compass.Direction);
    }

    public static IEnumerable<object[]> RightTurn =>
        new List<object[]>
        {
            new object[] { new North(), "E" },
            new object[] { new West(), "N" },
            new object[] { new South(), "W" },
            new object[] { new East(), "S" },
        };


    [Theory]
    [MemberData(nameof(Vector))]
    public void Return_Up_Vector_If_Heading_North(Direction direction, Coordinates vector)
    {
        var compass = new Compass(direction);
        Assert.Equal(vector, compass.GetMoveVector());
    }

    public static IEnumerable<object[]> Vector =>
        new List<object[]>
        {
            new object[] { new North(), new Coordinates { Longitude = 0, Latitude = 1 } },
            new object[] { new West(), new Coordinates { Longitude = -1, Latitude = 0 } },
            new object[] { new South(), new Coordinates { Longitude = 0, Latitude = -1 } },
            new object[] { new East(), new Coordinates { Longitude = 1, Latitude = 0 } },
        };
}
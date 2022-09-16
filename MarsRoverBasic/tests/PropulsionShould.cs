using MarsRoverBasic.NavigationModule;
using Xunit;

namespace MarsRoverBasic.tests;

public class PropulsionShould
{
    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Up()
    {
        var expected = new Coordinates { X = 5, Y = 6 };
        var origin = new Coordinates { X = 5, Y = 5 };
        var moveVector = new Coordinates { X = 0, Y = 1 };
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newCoordinates = propulsion.Move(origin, moveVector);

        Assert.Equal(expected, newCoordinates);
    }

    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Down()
    {
        var expected = new Coordinates { X = 5, Y = 4 };
        var origin = new Coordinates { X = 5, Y = 5 };
        var moveVector = new Coordinates { X = 0, Y = -1 };
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newCoordinates = propulsion.Move(origin, moveVector);

        Assert.Equal(expected, newCoordinates);
    }

    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Right()
    {
        var expected = new Coordinates { X = 6, Y = 5 };
        var origin = new Coordinates { X = 5, Y = 5 };
        var moveVector = new Coordinates { X = 1, Y = 0 };
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newCoordinates = propulsion.Move(origin, moveVector);

        Assert.Equal(expected, newCoordinates);
    }

    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Left()
    {
        var expected = new Coordinates { X = 4, Y = 5 };
        var origin = new Coordinates { X = 5, Y = 5 };
        var moveVector = new Coordinates { X = -1, Y = 0 };
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newCoordinates = propulsion.Move(origin, moveVector);

        Assert.Equal(expected, newCoordinates);
    }
}
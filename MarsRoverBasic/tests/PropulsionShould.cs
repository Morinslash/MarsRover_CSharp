using MarsRoverBasic.NavigationModule;
using Xunit;

namespace MarsRoverBasic.tests;

public class PropulsionShould
{
    private readonly Propulsion _propulsion;

    public PropulsionShould()
    {
        _propulsion = new Propulsion();
    }

    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Up()
    {
        var expected = new Coordinates { Longitude = 5, Latitude = 6 };
        var origin = new Coordinates { Longitude = 5, Latitude = 5 };
        var moveVector = new Coordinates { Longitude = 0, Latitude = 1 };
        
        Assert.Equal(expected, _propulsion.Move(origin, moveVector));
    }

    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Down()
    {
        var expected = new Coordinates { Longitude = 5, Latitude = 4 };
        var origin = new Coordinates { Longitude = 5, Latitude = 5 };
        var moveVector = new Coordinates { Longitude = 0, Latitude = -1 };

        Assert.Equal(expected, _propulsion.Move(origin, moveVector));
    }

    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Right()
    {
        var expected = new Coordinates { Longitude = 6, Latitude = 5 };
        var origin = new Coordinates { Longitude = 5, Latitude = 5 };
        var moveVector = new Coordinates { Longitude = 1, Latitude = 0 };
        
        Assert.Equal(expected, _propulsion.Move(origin, moveVector));
    }

    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Left()
    {
        var expected = new Coordinates { Longitude = 4, Latitude = 5 };
        var origin = new Coordinates { Longitude = 5, Latitude = 5 };
        var moveVector = new Coordinates { Longitude = -1, Latitude = 0 };

        Assert.Equal(expected, _propulsion.Move(origin, moveVector));
    }
}
using Xunit;

namespace MarsRoverBasic.tests;

public class PropulsionShould
{
    [Fact]
    public void Return_Coordinates_With_Increased_X_Position_When_Moving_East()
    {
        var expectedPosition = new Coordinates{ X = 1, Y = 0 };
        var originPosition = new Coordinates { X = 0, Y = 0 };
        var compass = new Compass("E");
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newPosition = propulsion.Move(originPosition, compass, grid);
        
        Assert.Equal(expectedPosition, newPosition);
    }

    [Fact]
    public void Return_Coordinates_With_Increased_Y_Position_When_Moving_North()
    {
        var expectedPosition = new Coordinates{ X = 0, Y = 1 };
        var originPosition = new Coordinates { X = 0, Y = 0 };
        var compass = new Compass("N");
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newPosition = propulsion.Move(originPosition, compass, grid);
        
        Assert.Equal(expectedPosition, newPosition);
    }

    [Fact]
    public void Return_Coordinates_With_Decreased_Y_Position_When_Moving_South()
    {
        var expectedPosition = new Coordinates{ X = 0, Y = 0 };
        var originPosition = new Coordinates { X = 0, Y = 1 };
        var compass = new Compass("S");
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newPosition = propulsion.Move(originPosition, compass, grid);
        
        Assert.Equal(expectedPosition, newPosition);
    }
    
    [Fact]
    public void Return_Coordinates_With_Decreased_X_Position_When_Moving_West()
    {
        var expectedPosition = new Coordinates{ X = 0, Y = 0 };
        var originPosition = new Coordinates { X = 1, Y = 0 };
        var compass = new Compass("W");
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newPosition = propulsion.Move(originPosition, compass, grid);
        
        Assert.Equal(expectedPosition, newPosition);
    }
}
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

    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Up()
    {
        var expected = new Coordinates { X = 5, Y = 6 };
        var origin = new Coordinates{X = 5, Y = 5};
        var moveVector = new Coordinates{X = 0, Y = 1};
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newCoordinates = propulsion.Move(origin,moveVector,grid);
        
        Assert.Equal(expected, newCoordinates);
    }
    
    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Down()
    {
        var expected = new Coordinates { X = 5, Y = 4 };
        var origin = new Coordinates{X = 5, Y = 5};
        var moveVector = new Coordinates{X = 0, Y = -1};
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newCoordinates = propulsion.Move(origin,moveVector,grid);
        
        Assert.Equal(expected, newCoordinates);
    }
    
    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Right()
    {
        var expected = new Coordinates { X = 6, Y = 5 };
        var origin = new Coordinates{X = 5, Y = 5};
        var moveVector = new Coordinates{X = 1, Y = 0};
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newCoordinates = propulsion.Move(origin,moveVector,grid);
        
        Assert.Equal(expected, newCoordinates);
    }
    [Fact]
    public void Return_New_Coordinates_That_Results_From_Adding_Move_Vector_Left()
    {
        var expected = new Coordinates { X = 4, Y = 5 };
        var origin = new Coordinates{X = 5, Y = 5};
        var moveVector = new Coordinates{X = -1, Y = 0};
        var grid = new Grid(10);

        var propulsion = new Propulsion();

        var newCoordinates = propulsion.Move(origin,moveVector,grid);
        
        Assert.Equal(expected, newCoordinates);
    }
}
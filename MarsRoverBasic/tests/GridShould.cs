using Xunit;

namespace MarsRoverBasic.tests;

public class GridShould
{
    [Fact]
    public void Return_The_Same_Coordinate_Value_If_Not_Above_World_Size()
    {
        var grid = new Grid(10);
        Assert.Equal(5, grid.Wrap(5));
    }

    [Fact]
    public void Return_Wrapped_Coordinate_Value_If_Higher_Then_World_Size()
    {
        var grid = new Grid(10);
        Assert.Equal(1, grid.Wrap(11));
    }
}
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Xunit;

namespace MarsRoverBasic.tests;

public class MarsRoverShould
{
    [Fact]
    public void Return_Initial_Orientation_When_Command_Is_Empty_String()
    {
        var expectedOutput = "0:0:N";
        var sut = new MarsRover();
        Assert.Equal(expectedOutput, sut.Execute(string.Empty));
    }

    [Fact]
    public void Return_0_0_E_When_Command_Is_L()
    {
        var expectedOutput = "0:0:E";
        var marsRover = new MarsRover();
        Assert.Equal(expectedOutput, marsRover.Execute("L"));
    }
}
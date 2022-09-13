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
}
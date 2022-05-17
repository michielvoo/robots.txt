using Xunit;

namespace RobotsTxt.Tests;

public class ConvertToRobotsTxtCmdletTests
{
    [Fact]
    public void Test()
    {
        // Arrange
        var cmdlet = new ConvertToRobotsTxtCmdlet
        {
            InputObject = string.Empty
        };

        // Act
        var result = cmdlet.Invoke<RobotsTxt>().SingleOrDefault();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(3, result!.Groups.Length);
    }
}
using _75InterviewQuestion.ContainerWithMostWater;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class ContainerWithMostWaterTests
{
    [Fact]
    public void MaxArea_ValidInput_ReturnsCorrectMaxArea()
    {
        // Arrange
        var solution = new _11_ContainerWithMostWater();
        int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        var expected = 49;

        // Act
        var result = solution.MaxArea(heights);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxArea_SingleElement_ReturnsZero()
    {
        // Arrange
        var solution = new _11_ContainerWithMostWater();
        int[] heights = { 1 };
        var expected = 0;

        // Act
        var result = solution.MaxArea(heights);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxArea_TwoElements_ReturnsMinHeightTimesDistance()
    {
        // Arrange
        var solution = new _11_ContainerWithMostWater();
        int[] heights = { 1, 2 };
        var expected = 1;

        // Act
        var result = solution.MaxArea(heights);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxArea_AllElementsSameHeight_ReturnsCorrectMaxArea()
    {
        // Arrange
        var solution = new _11_ContainerWithMostWater();
        int[] heights = { 3, 3, 3, 3, 3 };
        var expected = 12;

        // Act
        var result = solution.MaxArea(heights);

        // Assert
        Assert.Equal(expected, result);
    }
}
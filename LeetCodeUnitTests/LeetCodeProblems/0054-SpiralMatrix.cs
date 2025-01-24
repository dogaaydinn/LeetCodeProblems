using LeetCodeProblems.SpiralMatrix;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class SpiralMatrixTests
{
    [Fact]
    public void TestSpiralOrder_Example1()
    {
        // Arrange
        var matrix = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        var expected = new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
        var spiralMatrix = new SpiralMatrix();

        // Act
        var result = spiralMatrix.SpiralOrder(matrix);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestSpiralOrder_Example2()
    {
        // Arrange
        var matrix = new int[][]
        {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6, 7, 8 },
            new int[] { 9, 10, 11, 12 }
        };
        var expected = new List<int> { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
        var spiralMatrix = new SpiralMatrix();

        // Act
        var result = spiralMatrix.SpiralOrder(matrix);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestSpiralOrder_EmptyMatrix()
    {
        // Arrange
        var matrix = new int[][] { };
        var expected = new List<int> { };
        var spiralMatrix = new SpiralMatrix();

        // Act
        var result = spiralMatrix.SpiralOrder(matrix);

        // Assert
        Assert.Equal(expected, result);
    }
}
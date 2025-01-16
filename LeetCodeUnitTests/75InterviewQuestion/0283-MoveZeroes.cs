using _75InterviewQuestion.MoveZeroes;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class MoveZeroesTests
{
    [Fact]
    public void MoveZeroes_ValidInput_MovesZeroesToEnd()
    {
        // Arrange
        var solution = new _283_MoveZeroes();
        int[] nums = { 0, 1, 0, 3, 12 };
        int[] expected = { 1, 3, 12, 0, 0 };

        // Act
        solution.MoveZeroes(nums);

        // Assert
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void MoveZeroes_AllZeroes_MovesZeroesToEnd()
    {
        // Arrange
        var solution = new _283_MoveZeroes();
        int[] nums = { 0, 0, 0, 0 };
        int[] expected = { 0, 0, 0, 0 };

        // Act
        solution.MoveZeroes(nums);

        // Assert
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void MoveZeroes_NoZeroes_DoesNotChangeArray()
    {
        // Arrange
        var solution = new _283_MoveZeroes();
        int[] nums = { 1, 2, 3, 4 };
        int[] expected = { 1, 2, 3, 4 };

        // Act
        solution.MoveZeroes(nums);

        // Assert
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void MoveZeroes_EmptyArray_DoesNotChangeArray()
    {
        // Arrange
        var solution = new _283_MoveZeroes();
        int[] nums = { };
        int[] expected = { };

        // Act
        solution.MoveZeroes(nums);

        // Assert
        Assert.Equal(expected, nums);
    }
}
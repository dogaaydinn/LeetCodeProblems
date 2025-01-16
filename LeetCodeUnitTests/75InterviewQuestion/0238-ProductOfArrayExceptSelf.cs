using _75InterviewQuestion.ProductOfArrayExceptSelf;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class ProductOfArrayExceptSelfTests
{
    [Fact]
    public void ProductExceptSelf_ValidInput_ReturnsExpectedOutput()
    {
        // Arrange
        var solution = new _238_ProductOfArrayExceptSelf();
        int[] nums = { 1, 2, 3, 4 };
        int[] expected = { 24, 12, 8, 6 };

        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ProductExceptSelf_InputWithZero_ReturnsExpectedOutput()
    {
        // Arrange
        var solution = new _238_ProductOfArrayExceptSelf();
        int[] nums = { 1, 2, 0, 4 };
        int[] expected = { 0, 0, 8, 0 };

        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ProductExceptSelf_AllZeros_ReturnsAllZeros()
    {
        // Arrange
        var solution = new _238_ProductOfArrayExceptSelf();
        int[] nums = { 0, 0, 0, 0 };
        int[] expected = { 0, 0, 0, 0 };

        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ProductExceptSelf_SingleElement_ReturnsOne()
    {
        // Arrange
        var solution = new _238_ProductOfArrayExceptSelf();
        int[] nums = { 5 };
        int[] expected = { 1 };

        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ProductExceptSelf_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        var solution = new _238_ProductOfArrayExceptSelf();
        int[] nums = { };
        int[] expected = { };

        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
using LeetCodeProblems.PalindromeNumber;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class _009_PalindromeNumberTests
{
    private readonly _009_PalindromeNumber palindromeNumber = new();

    [Fact]
    public void IsPalindrome_PositivePalindromeNumber_ReturnsTrue()
    {
        // Arrange
        var input = 121;

        // Act
        var result = _009_PalindromeNumber.IsPalindrome(input);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_NegativeNumber_ReturnsFalse()
    {
        // Arrange
        var input = -121;

        // Act
        var result = _009_PalindromeNumber.IsPalindrome(input);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_PositiveNonPalindromeNumber_ReturnsFalse()
    {
        // Arrange
        var input = 10;

        // Act
        var result = _009_PalindromeNumber.IsPalindrome(input);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_SingleDigitNumber_ReturnsTrue()
    {
        // Arrange
        var input = 7;

        // Act
        var result = _009_PalindromeNumber.IsPalindrome(input);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_Zero_ReturnsTrue()
    {
        // Arrange
        var input = 0;

        // Act
        var result = _009_PalindromeNumber.IsPalindrome(input);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_MinValue_ReturnsFalse()
    {
        // Arrange
        var input = int.MinValue;

        // Act
        var result = _009_PalindromeNumber.IsPalindrome(input);

        // Assert
        Assert.False(result);
    }
}
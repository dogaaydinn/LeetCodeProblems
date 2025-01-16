using LeetCodeProblems.PalindromeNumber;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class PalindromeNumberTests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    [InlineData(12321, true)]
    [InlineData(0, true)]
    public void IsPalindrome_ValidInputs_ReturnsExpectedResult(int x, bool expected)
    {
        // Act
        var result = _009_PalindromeNumber.IsPalindrome(x);

        // Assert
        Assert.Equal(expected, result);
    }
}
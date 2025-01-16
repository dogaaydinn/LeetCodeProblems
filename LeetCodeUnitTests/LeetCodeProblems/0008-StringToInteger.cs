using LeetCodeProblems.StringToInteger;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class StringToIntegerTests
{
    [Theory]
    [InlineData("42", 42)]
    [InlineData("   -42", -42)]
    [InlineData("4193 with words", 4193)]
    [InlineData("words and 987", 0)]
    [InlineData("-91283472332", int.MinValue)] // Overflow case
    public void MyAtoi_ValidInputs_ReturnsExpectedResult(string input, int expected)
    {
        // Act
        var result = _008_StringToInteger.MyAtoi(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
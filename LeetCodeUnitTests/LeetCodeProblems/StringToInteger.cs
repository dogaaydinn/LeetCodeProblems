using LeetCodeProblems.StringToInteger;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class StringToInteger
{
    [Fact]
    public void MyAtoi_ReturnsCorrectInteger()
    {
        const string input = "42";

        var result = _008_StringToInteger.MyAtoi(input);

        Assert.Equal(42, result);
    }

    [Fact]
    public void MyAtoi_ReturnsZeroForInvalidInput()
    {
        const string input = "abc";

        var result = _008_StringToInteger.MyAtoi(input);

        Assert.Equal(0, result);
    }
}
using LeetCodeProblems.CountAndSay;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class CountAndSayTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "11")]
    [InlineData(3, "21")]
    [InlineData(4, "1211")]
    [InlineData(5, "111221")]
    public void CountAndSay_ValidInputs_ReturnsExpectedResult(int n, string expected)
    {
        // Arrange
        var solution = new _38_CountAndSay();

        // Act
        var result = solution.CountAndSay(n);

        // Assert
        Assert.Equal(expected, result);
    }
}
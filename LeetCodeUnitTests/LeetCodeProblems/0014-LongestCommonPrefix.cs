using LeetCodeProblems.LongestCommonPrefix;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class LongestCommonPrefixTests
{
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    [InlineData(new[] { "interspecies", "interstellar", "interstate" }, "inters")]
    [InlineData(new[] { "throne", "throne" }, "throne")]
    [InlineData(new[] { "throne", "dungeon" }, "")]
    [InlineData(new[] { "throne", "" }, "")]
    public void LongestCommonPrefix_ValidInputs_ReturnsExpectedResult(string[] strs, string expected)
    {
        // Arrange
        var solution = new _14_LongestCommonPrefix();

        // Act
        var result = solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal(expected, result);
    }
}
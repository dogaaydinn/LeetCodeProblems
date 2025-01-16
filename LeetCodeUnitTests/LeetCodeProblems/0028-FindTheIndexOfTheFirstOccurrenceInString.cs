using LeetCodeProblems.FindTheIndexOfTheFirstOccurrenceInString;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class FindTheIndexOfTheFirstOccurrenceInStringTests
{
    [Theory]
    [InlineData("hello", "ll", 2)]
    [InlineData("aaaaa", "bba", -1)]
    [InlineData("", "", 0)]
    [InlineData("a", "", 0)]
    [InlineData("a", "a", 0)]
    [InlineData("mississippi", "issip", 4)]
    public void StrStr_ValidInputs_ReturnsExpectedResult(string haystack, string needle, int expected)
    {
        // Arrange
        var solution = new _28_FindTheIndexOfTheFirstOccurrenceInString();

        // Act
        var result = solution.StrStr(haystack, needle);

        // Assert
        Assert.Equal(expected, result);
    }
}
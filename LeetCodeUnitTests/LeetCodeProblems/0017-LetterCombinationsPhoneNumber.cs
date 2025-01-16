using LeetCodeProblems.LetterCombinationsPhoneNumber;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class LetterCombinationsPhoneNumberTests
{
    [Theory]
    [InlineData("23", new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
    [InlineData("", new string[] { })]
    [InlineData("2", new[] { "a", "b", "c" })]
    [InlineData("7", new[] { "p", "q", "r", "s" })]
    [InlineData("9", new[] { "w", "x", "y", "z" })]
    public void LetterCombinations_ValidInputs_ReturnsExpectedResult(string digits, string[] expected)
    {
        // Arrange
        var solution = new _17_LetterCombinationsPhoneNumber();

        // Act
        var result = solution.LetterCombinations(digits);

        // Assert
        Assert.Equal(expected, result);
    }
}
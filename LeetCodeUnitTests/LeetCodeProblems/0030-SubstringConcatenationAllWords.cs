using LeetCodeProblems.SubstringConcatenationAllWords;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class SubstringConcatenationAllWordsTests
{
    [Theory]
    [InlineData("barfoothefoobarman", new[] { "foo", "bar" }, new[] { 0, 9 })]
    [InlineData("wordgoodgoodgoodbestword", new[] { "word", "good", "best", "word" }, new int[] { })]
    [InlineData("barfoofoobarthefoobarman", new[] { "bar", "foo", "the" }, new[] { 6, 9, 12 })]
    [InlineData("", new[] { "foo", "bar" }, new int[] { })]
    [InlineData("wordgoodgoodgoodbestword", new string[] { }, new int[] { })]
    public void FindSubstring_ValidInputs_ReturnsExpectedResult(string s, string[] words, int[] expected)
    {
        // Arrange
        var solution = new _30_SubstringConcatenationAllWords();

        // Act
        var result = solution.FindSubstring(s, words);

        // Assert
        Assert.Equal(expected, result);
    }
}
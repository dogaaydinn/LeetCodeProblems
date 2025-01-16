using _75InterviewQuestion.ReverseWordsInAString;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class ReverseWordsInAStringTests
{
    [Fact]
    public void ReverseWords_ValidInput_ReversesWords()
    {
        // Arrange
        var solution = new _151_ReverseWordsInAString();
        var input = "the sky is blue";
        var expected = "blue is sky the";

        // Act
        var result = solution.ReverseWords(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseWords_InputWithExtraSpaces_ReversesWords()
    {
        // Arrange
        var solution = new _151_ReverseWordsInAString();
        var input = "  hello world  ";
        var expected = "world hello";

        // Act
        var result = solution.ReverseWords(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseWords_SingleWord_ReturnsSameWord()
    {
        // Arrange
        var solution = new _151_ReverseWordsInAString();
        var input = "hello";
        var expected = "hello";

        // Act
        var result = solution.ReverseWords(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseWords_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        var solution = new _151_ReverseWordsInAString();
        var input = "";
        var expected = "";

        // Act
        var result = solution.ReverseWords(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
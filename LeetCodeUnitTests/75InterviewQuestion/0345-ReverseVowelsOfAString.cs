using _75InterviewQuestion.ReverseVowelsOfAString;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class ReverseVowelsOfAStringTests
{
    [Fact]
    public void ReverseVowels_ValidInput_ReversesVowels()
    {
        // Arrange
        var solution = new _345_ReverseVowelsOfAString();
        var input = "hello";
        var expected = "holle";

        // Act
        var result = solution.ReverseVowels(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseVowels_InputWithNoVowels_ReturnsSameString()
    {
        // Arrange
        var solution = new _345_ReverseVowelsOfAString();
        var input = "bcdfg";
        var expected = "bcdfg";

        // Act
        var result = solution.ReverseVowels(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseVowels_InputWithAllVowels_ReversesString()
    {
        // Arrange
        var solution = new _345_ReverseVowelsOfAString();
        var input = "aeiou";
        var expected = "uoiea";

        // Act
        var result = solution.ReverseVowels(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseVowels_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        var solution = new _345_ReverseVowelsOfAString();
        var input = "";
        var expected = "";

        // Act
        var result = solution.ReverseVowels(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseVowels_SingleCharacter_ReturnsSameCharacter()
    {
        // Arrange
        var solution = new _345_ReverseVowelsOfAString();
        var input = "a";
        var expected = "a";

        // Act
        var result = solution.ReverseVowels(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
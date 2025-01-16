using _75InterviewQuestion.IsSubsequence;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class IsSubsequenceTests
{
    [Fact]
    public void IsSubsequence_ValidSubsequence_ReturnsTrue()
    {
        // Arrange
        var solution = new _392_IsSubsequence();
        var s = "abc";
        var t = "ahbgdc";

        // Act
        var result = solution.IsSubsequence(s, t);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsSubsequence_InvalidSubsequence_ReturnsFalse()
    {
        // Arrange
        var solution = new _392_IsSubsequence();
        var s = "axc";
        var t = "ahbgdc";

        // Act
        var result = solution.IsSubsequence(s, t);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsSubsequence_EmptySubsequence_ReturnsTrue()
    {
        // Arrange
        var solution = new _392_IsSubsequence();
        var s = "";
        var t = "ahbgdc";

        // Act
        var result = solution.IsSubsequence(s, t);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsSubsequence_EmptyMainString_ReturnsFalse()
    {
        // Arrange
        var solution = new _392_IsSubsequence();
        var s = "abc";
        var t = "";

        // Act
        var result = solution.IsSubsequence(s, t);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsSubsequence_SameStrings_ReturnsTrue()
    {
        // Arrange
        var solution = new _392_IsSubsequence();
        var s = "abc";
        var t = "abc";

        // Act
        var result = solution.IsSubsequence(s, t);

        // Assert
        Assert.True(result);
    }
}
using _75InterviewQuestion.StringCompression;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class StringCompressionTests
{
    [Fact]
    public void Compress_ValidInput_CompressesString()
    {
        // Arrange
        var solution = new _443_StringCompression();
        char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
        char[] expected = { 'a', '2', 'b', '2', 'c', '3' };
        var expectedLength = 6;

        // Act
        var length = solution.Compress(chars);

        // Assert
        Assert.Equal(expectedLength, length);
        Assert.Equal(expected, chars[..length]);
    }

    [Fact]
    public void Compress_SingleCharacterArray_ReturnsSameArray()
    {
        // Arrange
        var solution = new _443_StringCompression();
        char[] chars = { 'a' };
        char[] expected = { 'a' };
        var expectedLength = 1;

        // Act
        var length = solution.Compress(chars);

        // Assert
        Assert.Equal(expectedLength, length);
        Assert.Equal(expected, chars[..length]);
    }

    [Fact]
    public void Compress_NoRepetitions_ReturnsSameArray()
    {
        // Arrange
        var solution = new _443_StringCompression();
        char[] chars = { 'a', 'b', 'c' };
        char[] expected = { 'a', 'b', 'c' };
        var expectedLength = 3;

        // Act
        var length = solution.Compress(chars);

        // Assert
        Assert.Equal(expectedLength, length);
        Assert.Equal(expected, chars[..length]);
    }

    [Fact]
    public void Compress_EmptyArray_ReturnsZero()
    {
        // Arrange
        var solution = new _443_StringCompression();
        char[] chars = { };
        char[] expected = { };
        var expectedLength = 0;

        // Act
        var length = solution.Compress(chars);

        // Assert
        Assert.Equal(expectedLength, length);
        Assert.Equal(expected, chars[..length]);
    }
}
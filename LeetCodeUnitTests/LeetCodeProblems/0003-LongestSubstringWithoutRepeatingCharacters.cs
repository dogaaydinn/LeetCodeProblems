using LeetCodeProblems.LongestSubstringWithoutRepeatingCharacters;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class LongestSubstringWithoutRepeatingCharactersTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]         // "abc"
    [InlineData("bbbbb", 1)]              // "b"
    [InlineData("pwwkew", 3)]             // "wke"
    [InlineData("", 0)]                   // Boş string
    [InlineData(" ", 1)]                  // Tek boşluk karakteri
    [InlineData("au", 2)]                 // "au"
    [InlineData("dvdf", 3)]               // "vdf"
    [InlineData("abba", 2)]               // "ab" veya "ba"
    public void LengthOfLongestSubstring_ValidInputs_ReturnsExpectedResult(string s, int expected)
    {
        // Arrange
        var solver = new _0003_LongestSubstringWithoutRepeatingCharacters();

        // Act
        int result = solver.LengthOfLongestSubstring(s);

        // Assert
        Assert.Equal(expected, result);
    }

    // İsteğe bağlı: Daha fazla senaryoyu test etmek için ek testler
    [Theory]
    [InlineData("aabaab!b", 3)]          // Standart tanıma göre: "ab!" veya "b!a" şeklinde 3 karakterli alt dizi bulunur.
    [InlineData("aabaab!b!", 3)]          // "ab!" en uzun alt dizi
    [InlineData("aabaab!b!a", 3)]
    public void LengthOfLongestSubstring_FurtherTests_ReturnsExpectedResult(string s, int expected)
    {
        // Arrange
        var solver = new _0003_LongestSubstringWithoutRepeatingCharacters();

        // Act
        int result = solver.LengthOfLongestSubstring(s);

        // Assert
        Assert.Equal(expected, result);
    }
}
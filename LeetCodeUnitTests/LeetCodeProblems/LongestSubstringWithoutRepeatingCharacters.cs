using LeetCodeProblems.LongestSubstringWithoutRepeatingCharacters;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class LongestSubstringWithoutRepeatingCharactersTests
{
    [Fact]
    public void LengthOfLongestSubstring_ReturnsCorrectLength_ForUniqueCharacters()
    {
        const string input = "abcabcbb";
        
        var result = _003_LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input);
        
        Assert.Equal(3, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_ReturnsCorrectLength_ForAllSameCharacters()
    {
        const string input = "bbbbb";
        
        var result = _003_LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input);
        
        Assert.Equal(1, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_ReturnsCorrectLength_ForMixedCharacters()
    {
        const string input = "pwwkew";
        
        var result = _003_LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input);
        
        Assert.Equal(3, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_ReturnsZero_ForEmptyString()
    {
        const string input = "";
        
        var result = _003_LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input);
        
        Assert.Equal(0, result);
    }
}
using _75InterviewQuestion.GreatestCommonDivisorOfStrings;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class GreatestCommonDivisorOfStringsTests
{
    [Fact]
    public void GcdOfStrings_ReturnsCorrectGCD()
    {
        const string str1 = "ABCABC";
        const string str2 = "ABC";
        
        var result = _1071_GreatestCommonDivisorOfStrings.GcdOfStrings(str1, str2);
        
        Assert.Equal("ABC", result);
    }

    [Fact]
    public void GcdOfStrings_ReturnsEmptyString_WhenNoGCD()
    {
        const string str1 = "ABABAB";
        const string str2 = "ABAB";
        
        var result = _1071_GreatestCommonDivisorOfStrings.GcdOfStrings(str1, str2);
        
        Assert.Equal("AB", result);
    }
}
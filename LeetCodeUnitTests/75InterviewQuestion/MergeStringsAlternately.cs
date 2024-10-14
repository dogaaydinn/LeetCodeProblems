using _75InterviewQuestion.MergeStringsAlternately;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class MergeStringsAlternatelyTests
{
    [Fact]
    public void MergeAlternately_ReturnsCorrectMergedString()
    {
        const string word1 = "abc";
        const string word2 = "pqr";
        
        var result = _1798_MergeStringsAlternately.MergeAlternately(word1, word2);
        
        Assert.Equal("apbqcr", result);
    }

    [Fact]
    public void MergeAlternately_ReturnsCorrectMergedString_WhenDifferentLengths()
    {
        const string word1 = "ab";
        const string word2 = "pqrs";
        
        var result = _1798_MergeStringsAlternately.MergeAlternately(word1, word2);

        Assert.Equal("apbqrs", result);
    }
}
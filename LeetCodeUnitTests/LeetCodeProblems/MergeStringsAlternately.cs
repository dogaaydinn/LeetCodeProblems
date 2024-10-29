using _75InterviewQuestion.MergeStringsAlternately;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

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
}
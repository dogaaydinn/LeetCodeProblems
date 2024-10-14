using _75InterviewQuestion.KidsWithTheGreatestNumberOfCandies;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class KidsWithTheGreatestNumberOfCandiesTests
{
    [Fact]
    public void KidsWithCandies_ReturnsCorrectResult()
    {
        int[] candies = { 2, 3, 5, 1, 3 };
        const int extraCandies = 3;
        
        var result = _1431_KidsWithTheGreatestNumberOfCandies.KidsWithCandies(candies, extraCandies);
        
        Assert.Equal(new[] { true, true, true, false, true }, result);
    }

    [Fact]
    public void KidsWithCandies_ReturnsCorrectResult_WhenAllKidsHaveSameCandies()
    {
        int[] candies = { 4, 4, 4, 4 };
        const int extraCandies = 1;

        var result = _1431_KidsWithTheGreatestNumberOfCandies.KidsWithCandies(candies, extraCandies);

        Assert.Equal(new[] { true, true, true, true }, result);
    }
}
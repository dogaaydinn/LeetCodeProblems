using LeetCodeProblems.ReverseInteger;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class ReverseInteger
{
    [Fact]
    public void Reverse_ReturnsCorrectReversedInteger()
    {
        const int input = 123;
        
        var result = _007_ReverseInteger.Reverse(input);
        
        Assert.Equal(321, result);
    }

    [Fact]
    public void Reverse_ReturnsZeroForOverflow()
    {
        const int input = 1534236469;
        
        var result = _007_ReverseInteger.Reverse(input);
        
        Assert.Equal(0, result);
    }
}
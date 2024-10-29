using LeetCodeProblems.TwoSum;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class TwoSum
{
    [Fact]
    public void TwoSumSolution_ReturnsCorrectIndices()
    {
        int[] nums = { 2, 7, 11, 15 };
        const int target = 9;

        var result = _001_TwoSum.TwoSumSolution(nums, target);

        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSumSolution_ThrowsArgumentException_WhenNoSolution()
    {
        int[] nums = { 1, 2, 3 };
        const int target = 6;

        Assert.Throws<ArgumentException>(() => _001_TwoSum.TwoSumSolution(nums, target));
    }
}
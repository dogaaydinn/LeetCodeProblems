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
    
    [Fact]
    public void TwoSumSolution_ThrowsArgumentException_WhenInputArrayIsEmpty()
    {
        int[] nums = { };
        const int target = 6;

        Assert.Throws<ArgumentException>(() => _001_TwoSum.TwoSumSolution(nums, target));
    }
    
    [Fact]
    public void TwoSumSolution_ThrowsArgumentException_WhenInputArrayIsNull()
    {
        int[] nums = null;
        const int target = 6;

        Assert.Throws<ArgumentException>(() => _001_TwoSum.TwoSumSolution(nums, target));
    }
    
    [Fact]
    public void TwoSumSolution_ThrowsArgumentException_WhenInputArrayHasOneElement()
    {
        int[] nums = { 1 };
        const int target = 6;

        Assert.Throws<ArgumentException>(() => _001_TwoSum.TwoSumSolution(nums, target));
    }
    
    [Fact]
    public void TwoSumSolution_ThrowsArgumentException_WhenInputArrayHasTwoElements()
    {
        int[] nums = { 1, 2 };
        const int target = 6;

        Assert.Throws<ArgumentException>(() => _001_TwoSum.TwoSumSolution(nums, target));
    }
    
    [Fact]
    public void TwoSumSolution_ThrowsArgumentException_WhenInputArrayHasThreeElements()
    {
        int[] nums = { 1, 2, 3 };
        const int target = 6;

        Assert.Throws<ArgumentException>(() => _001_TwoSum.TwoSumSolution(nums, target));
    }
    
    [Fact]
    public void TwoSumSolution_ThrowsArgumentException_WhenInputArrayHasFourElements()
    {
        int[] nums = { 1, 2, 3, 4 };
        const int target = 6;

        Assert.Throws<ArgumentException>(() => _001_TwoSum.TwoSumSolution(nums, target));
    }
    
    [Fact]
    public void TwoSumSolution_ThrowsArgumentException_WhenInputArrayHasFiveElements()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        const int target = 6;

        Assert.Throws<ArgumentException>(() => _001_TwoSum.TwoSumSolution(nums, target));
    }
    
    [Fact]
    public void TwoSumSolution_ThrowsArgumentException_WhenInputArrayHasSixElements()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6 };
        const int target = 6;

        Assert.Throws<ArgumentException>(() => _001_TwoSum.TwoSumSolution(nums, target));
    }
    
    
}
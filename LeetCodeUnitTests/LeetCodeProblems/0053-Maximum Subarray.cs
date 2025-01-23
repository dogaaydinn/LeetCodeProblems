using Xunit;
using LeetCodeProblems.MaximumSubarray;

namespace LeetCodeTests.LeetCodeProblems;

public class MaximumSubarrayTests
{
    [Fact]
    public void ExampleTest1()
    {
        // Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        // Output: 6
        var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        const int expected = 6;
        var actual = new MaximumSubarray().MaxSubArray(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExampleTest2()
    {
        // Input: nums = [1]
        // Output: 1
        var nums = new int[] { 1 };
        const int expected = 1;
        var actual = new MaximumSubarray().MaxSubArray(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExampleTest3()
    {
        // Input: nums = [5,4,-1,7,8]
        // Output: 23
        var nums = new int[] { 5, 4, -1, 7, 8 };
        const int expected = 23;
        var actual = new MaximumSubarray().MaxSubArray(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExampleTest4()
    {
        // Input: nums = [-1]
        // Output: -1
        var nums = new int[] { -1 };
        const int expected = -1;
        var actual = new MaximumSubarray().MaxSubArray(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExampleTest5()
    {
        // Input: nums = [-2147483647]
        // Output: -2147483647
        var nums = new int[] { -2147483647 };
        const int expected = -2147483647;
        var actual = new MaximumSubarray().MaxSubArray(nums);
        Assert.Equal(expected, actual);
    }
}
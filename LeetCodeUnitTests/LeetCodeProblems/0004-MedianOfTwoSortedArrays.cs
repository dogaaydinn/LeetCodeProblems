using LeetCodeProblems.MedianOfTwoSortedArrays;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class MedianOfTwoSortedArraysTests
{
    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.0)]
    [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    [InlineData(new[] { 0, 0 }, new[] { 0, 0 }, 0.0)]
    [InlineData(new int[] { }, new[] { 1 }, 1.0)]
    [InlineData(new[] { 2 }, new int[] { }, 2.0)]
    public void FindMedianSortedArrays_ValidInputs_ReturnsExpectedResult(int[] nums1, int[] nums2, double expected)
    {
        // Act
        var result = _004_MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);

        // Assert
        Assert.Equal(expected, result);
    }
}
using LeetCodeProblems.MedianOfTwoSortedArrays;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class MedianOfTwoSortedArrays
{
    [Fact]
    public void FindMedianSortedArrays_ReturnsCorrectMedian()
    {
        int[] nums1 = { 1, 3 };
        int[] nums2 = { 2 };

        var result = _004_MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);

        Assert.Equal(2.0, result);
    }
}
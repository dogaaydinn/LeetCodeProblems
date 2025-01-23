namespace LeetCodeProblems.MaximumSubarray;

public class MaximumSubarray
{
    /*
     Intution:
        - We can solve this problem using Kadane's algorithm.
        - We will keep track of two variables maxSoFar and maxEndingHere.
        - maxSoFar will keep track of the maximum sum of subarray so far.
        - maxEndingHere will keep track of the maximum sum of subarray ending at the current index.
        - We will iterate through the array and update the maxEndingHere and maxSoFar.
        - Finally, we will return maxSoFar.
        
        APPROACH:
        - Initialize maxSoFar and maxEndingHere with the first element of the array.
        - Iterate through the array starting from the second element.
        - Update maxEndingHere with the maximum of the current element and the sum of the current element and maxEndingHere.
        - Update maxSoFar with the maximum of maxSoFar and maxEndingHere.
        - Return maxSoFar.
        
        TIME COMPLEXITY:
        - O(n) where n is the length of the input array.
        
        SPACE COMPLEXITY:
        - O(1)
     */
    public int MaxSubArray(int[] nums)
    {
        var maxSoFar = nums[0];
        var maxEndingHere = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
}
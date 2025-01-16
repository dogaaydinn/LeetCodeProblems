namespace _75InterviewQuestion.IncreasingTripletSubsequence;

public class _334_IncreasingTripletSubsequence
{
    /*
     * 334. Increasing Triplet Subsequence
        * Given an integer array nums, return true if there exists a triple of indices (i, j, k) such that i < j < k and nums[i] < nums[j] < nums[k].
     * If no such indices exists, return false.
     Approach:
        * 1. Initialize two variables first and second to int.MaxValue.
     * 2. Iterate over the nums array.
     * 3. If the current number is less than or equal to the first, update the first to the current number.
     * 4. If the current number is less than or equal to the second, update the second to the current number.
     * 5. If the current number is greater than the second, return true.
     * 6. If no increasing triplet is found, return false.
     *
     * Time complexity: O(n), where n is the length of the nums array.
     * Space complexity: O(1).
     */
    public bool IncreasingTriplet(int[] nums)
    {
        var first = int.MaxValue;
        var second = int.MaxValue;

        foreach (var num in nums)
            if (num <= first)
                first = num;
            else if (num <= second)
                second = num;
            else
                return true;

        return false;
    }
}
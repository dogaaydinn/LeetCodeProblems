namespace LeetCodeProblems._3SumClosest;

public class _16_3SumClosest
{
    /*
    Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.
    Return the sum of the three integers.
    You may assume that each input would have exactly one solution.

    Approach:
    1. Sort the nums array.
    2. Initialize closestSum as nums[0] + nums[1] + nums[2].
    3. Iterate through the nums array.
    4. Initialize left as i + 1 and right as nums.Length - 1.
    5. Iterate while left is less than right.
    6. Calculate the sum of nums[i], nums[left], and nums[right].
    7. If the absolute difference between sum and target is less than the absolute difference between closestSum and target, update closestSum.
    8. If the sum is less than target, increment left.
    9. If the sum is greater than target, decrement right.
    10. Return closestSum.

    Complexity Analysis:
    Time Complexity: O(n^2), where n is the length of nums.
    Space Complexity: O(1).
     */
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        var closestSum = nums[0] + nums[1] + nums[2];

        for (var i = 0; i < nums.Length - 2; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (Math.Abs(sum - target) < Math.Abs(closestSum - target)) closestSum = sum;

                if (sum < target)
                    left++;
                else
                    right--;
            }
        }

        return closestSum;
    }
}
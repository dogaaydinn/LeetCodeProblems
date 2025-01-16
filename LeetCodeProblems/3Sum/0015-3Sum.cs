namespace LeetCodeProblems._3Sum;

public class _15_3Sum
{
    /*
    Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
    Notice that the solution set must not contain duplicate triplets.
    Approach:
    1. Sort the nums array.
    2. Iterate through the nums array.
    3. If the current number is the same as the previous number, skip it.
    4. Initialize left as i + 1 and right as nums.Length - 1.
    5. Iterate while left is less than right.
    6. Calculate the sum of nums[i], nums[left], and nums[right].
    7. If the sum is equal to 0, add the triplet to the result.
    8. Skip the duplicates.
    9. Increment left and decrement right.
    10. If the sum is less than 0, increment left.
    11. If the sum is greater than 0, decrement right.
    12. Return the result.

    Complexity Analysis:
    Time Complexity: O(n^2), where n is the length of nums.
    Space Complexity: O(1).
     */
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                switch (sum)
                {
                    case 0:
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) left++;

                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                        break;
                    }
                    case < 0:
                        left++;
                        break;
                    default:
                        right--;
                        break;
                }
            }
        }

        return result;
    }
}
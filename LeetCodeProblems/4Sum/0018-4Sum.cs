namespace LeetCodeProblems._4Sum;

public class _18_4Sum
{
    /*
    Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
    0 <= a, b, c, d < n
    a, b, c, and d are distinct.
    nums[a] + nums[b] + nums[c] + nums[d] == target
    You may return the answer in any order.

    Approach:
    1. Sort the nums array.
    2. Iterate through the nums array.
    3. If the current number is the same as the previous number, skip it.
    4. Initialize left as j + 1 and right as nums.Length - 1.
    5. Iterate while left is less than right.
    6. Calculate the sum of nums[i], nums[j], nums[left], and nums[right].
    7. If the sum is equal to target, add the quadruplet to the result.
    8. Skip the duplicates.
    9. Increment left and decrement right.

    Complexity Analysis:
    Time Complexity: O(n^3), where n is the length of nums.
    Space Complexity: O(1).
     */
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        var n = nums.Length;

        for (var i = 0; i < n - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            for (var j = i + 1; j < n - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                int left = j + 1, right = n - 1;

                while (left < right)
                {
                    var sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        left++;
                        right--;

                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}
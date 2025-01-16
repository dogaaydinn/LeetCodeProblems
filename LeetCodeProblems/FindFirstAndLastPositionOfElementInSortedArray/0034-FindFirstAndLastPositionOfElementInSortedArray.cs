namespace LeetCodeProblems.FindFirstAndLastPositionOfElementInSortedArray;

public class _34_FindFirstAndLastPositionOfElementInSortedArray
{
    /*
     # Intuition
       <!-- Describe your first thoughts on how to solve this problem. -->
         - We can use binary search to solve this problem.
            - We will find the first occurrence of the target.
            - We will find the last occurrence of the target.
            - Finally we will return the first and last occurrence of the target.

            # Approach
       <!-- Describe your approach to solving the problem. -->
            - We will find the first occurrence of the target.
            - We will find the last occurrence of the target.
            - Finally we will return the first and last occurrence of the target.

        # Time Complexity
            - O(logN), where N is the length of the array.
        # Space Complexity
            - O(1).
     */

    public int[] SearchRange(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        var first = -1;
        var last = -1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                first = mid;
                right = mid - 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        left = 0;
        right = nums.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                last = mid;
                left = mid + 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return new[] { first, last };
    }
}
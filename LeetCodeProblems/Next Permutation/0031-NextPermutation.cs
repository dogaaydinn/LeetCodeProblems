namespace LeetCodeProblems.Next_Permutation;

public class _31_Next_Permutation
{
    /*
     Problem: 31. Next Permutation

        Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
        If such an arrangement is not possible, it must rearrange it as the lowest possible order (i.e., sorted in ascending order).
        The replacement must be in place and use only constant extra memory.

        Approach:
            1. Find the first decreasing element from the end of the array.
            2. If there is no decreasing element, reverse the array.
            3. Find the first element greater than the decreasing element.
            4. Swap the decreasing element with the greater element.
            5. Reverse the array from the next element of the decreasing element to the end of the array.

            Time complexity: O(n)
            Space complexity: O(1)
     */
    public void NextPermutation(int[] nums)
    {
        if (nums is not { Length: > 1 })
            return;

        var i = nums.Length - 2;

        while (i >= 0 && nums[i] >= nums[i + 1]) i--;

        if (i >= 0)
        {
            var j = nums.Length - 1;

            while (j >= 0 && nums[j] <= nums[i]) j--;

            Swap(nums, i, j);
        }

        Reverse(nums, i + 1, nums.Length - 1);
    }

    private void Swap(int[] nums, int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }

    private void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            Swap(nums, start, end);
            start++;
            end--;
        }
    }
}
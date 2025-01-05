namespace LeetCodeProblems.Next_Permutation;

public class _31_Next_Permutation
{
    private void NextPermutation(int[] nums)
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
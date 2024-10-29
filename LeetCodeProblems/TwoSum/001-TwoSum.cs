namespace LeetCodeProblems.TwoSum;

public static class _001_TwoSum
{
    public static int[] TwoSumSolution(int[] nums, int target)
    {
        var returnedIndices = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var other = target - nums[i];

            if (returnedIndices.TryGetValue(other, out var index)) return new[] { index, i };

            returnedIndices[nums[i]] = i;
        }

        throw new ArgumentException("No two sum solution");
    }
}
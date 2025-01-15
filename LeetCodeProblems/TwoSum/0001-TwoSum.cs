namespace LeetCodeProblems.TwoSum;

public static class _001_TwoSum
{
    /*
     Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        Approach:
            1. Create a dictionary to store the indices of the elements.
            2. Iterate through the nums array.
            3. Calculate the other number required to make the sum equal to target.
            4. If the other number is present in the dictionary, return the indices of the two numbers.
            5. Otherwise, add the current number to the dictionary.
            6. If no solution is found, throw an ArgumentException.

            Time complexity: O(n), where n is the length of the array.
            Space complexity: O(n).
     */
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
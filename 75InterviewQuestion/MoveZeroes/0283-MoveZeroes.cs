namespace _75InterviewQuestion.MoveZeroes;

public class _283_MoveZeroes
{
    /*
     Problem: 283. Move Zeroes

        Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        Note that you must do this in-place without making a copy of the array.

        Approach:
        1. Initialize an index variable to 0.
        2. Iterate over the nums array.
        3. If the current number is not equal to 0, move the number to the index position and increment the index.
        4. Fill the remaining positions with 0.

        Time complexity: O(n), where n is the length of the nums array.
        Space complexity: O(1).
     */
    public void MoveZeroes(int[] nums)
    {
        var index = 0;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] != 0)
                nums[index++] = nums[i];

        for (var i = index; i < nums.Length; i++) nums[i] = 0;
    }
}
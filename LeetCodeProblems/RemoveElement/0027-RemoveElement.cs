namespace LeetCodeProblems.RemoveElement;

public class _27_RemoveElement
{
    /*
    Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.
    Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
    Return k after placing the final result in the first k slots of nums.
    Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.

    Approach:
    1. Initialize k as 0.
    2. Iterate through the nums array.
    3. If the current element is not equal to val, set nums[k] to the current element and increment k.
    4. Return k.

    Time complexity: O(n), where n is the length of nums.
    Space complexity: O(1)
     */
    public int RemoveElement(int[] nums, int val)
    {
        var k = 0;
        for (var index = 0; index < nums.Length; index++)
        {
            if (nums[index] == val) continue;
            nums[k] = nums[index];
            k++;
        }

        return k;
    }
}
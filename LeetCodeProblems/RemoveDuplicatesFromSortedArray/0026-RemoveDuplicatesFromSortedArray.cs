namespace LeetCodeProblems.RemoveDuplicatesFromSortedArray;

public class _26_RemoveDuplicatesFromSortedArray
{
    /*
    Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
    The relative order of the elements should be kept the same.
    Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums.
    More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result.
    It does not matter what you leave beyond the first k elements.
    Return k after placing the final result in the first k slots of nums.
    Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.

    Approach:
    1. If the length of the array is 0, return 0.
    2. Initialize writeIndex as 0.
    3. Iterate through the array starting from the second element.
    4. If the current element is equal to the element at writeIndex, continue.
    5. Increment writeIndex and update the element at writeIndex with the current element.
    6. Return writeIndex + 1.

    Complexity Analysis:
    Time Complexity: O(n), where n is the length of nums.
    Space Complexity: O(1).
     */
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var writeIndex = 0;

        for (var readIndex = 1; readIndex < nums.Length; readIndex++)
        {
            if (nums[readIndex] == nums[writeIndex]) continue;
            writeIndex++;
            nums[writeIndex] = nums[readIndex];
        }

        return writeIndex + 1;
    }
}
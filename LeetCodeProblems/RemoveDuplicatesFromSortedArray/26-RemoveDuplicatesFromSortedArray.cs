namespace LeetCodeProblems.RemoveDuplicatesFromSortedArray;

public class _26_RemoveDuplicatesFromSortedArray {
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int writeIndex = 0; 

        for (int readIndex = 1; readIndex < nums.Length; readIndex++)
        {
            if (nums[readIndex] == nums[writeIndex]) continue;
            writeIndex++; 
            nums[writeIndex] = nums[readIndex];
        }

        return writeIndex + 1;
    }

}
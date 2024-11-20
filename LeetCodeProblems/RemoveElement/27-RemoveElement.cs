namespace LeetCodeProblems.RemoveElement;

public class _27_RemoveElement {
    public int RemoveElement(int[] nums, int val) {
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
namespace LeetCodeProblems.FirstMissingPositive;

public class _41_FirstMissingPositive {
    /*
        Approach:
            1. Iterate through the array and swap the elements to their correct positions.
            2. The correct position for the element nums[i] is nums[i] - 1.
            3. If the element is not in the correct position, swap it with the element at the correct position.
            4. After swapping, check if the element at the correct position is in the correct position.
            5. If not, swap it with the element at the correct position.
            6. Iterate through the array again and find the first element that is not in the correct position.
            7. The first element that is not in the correct position is the first missing positive integer.
            
            Time complexity: O(n)
            Space complexity: O(1)
     */
    public int FirstMissingPositive(int[] nums) {
        var n = nums.Length;

        for (var i = 0; i < n; i++) {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) {
                Swap(nums, i, nums[i] - 1);
            }
        }

        for (var i = 0; i < n; i++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }

        return n + 1;
    }

    private void Swap(int[] nums, int i, int j) {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }
}
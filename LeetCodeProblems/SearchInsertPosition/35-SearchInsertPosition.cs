namespace LeetCodeProblems.SearchInsertPosition;

public class _35_SearchInsertPosition {
    
    /*
     Approach:
    1. We will use binary search to find the target element.
    2. If we find the target element, we will return the index.
    3. If we don't find the target element, we will return the left index.
    4. The left index will be the index where the target element should be inserted.
    5. If the target element is greater than the last element, the left index will be the length of the array.
    6. If the target element is smaller than the first element, the left index will be 0.
    7. If the target element is between the first and last element, the left index will be the index where the target element should be inserted.
    8. Time complexity is O(log n) and space complexity is O(1).
    
     */
    
    public int SearchInsert(int[] nums, int target) {
        
        var left = 0;
        var right = nums.Length - 1;
        
        while (left <= right) {
            var mid = left + (right - left) / 2;
            
            if (nums[mid] == target) {
                return mid;
            }
            
            if (nums[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        
        return left;
    }
}
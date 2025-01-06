namespace LeetCodeProblems.SearchInRotatedSortedArray;

public class _33_SearchInRotatedSortedArray {

    
    /*
     # Intuition
        - We can use binary search to solve this problem.
        - We will find the mid element.
        - If mid element is equal to target then we will return the mid index.
        - If left element is less than or equal to mid element then it means left part is sorted.
        - If target is in left part then we will update right = mid - 1.
        - Otherwise we will update left = mid + 1.
        - If left element is greater than mid element then it means right part is sorted.
        - If target is in right part then we will update left = mid + 1.
        - Otherwise we will update right = mid - 1.
        - Finally we will return -1.
        
        # Time Complexity
            - O(logN), where N is the length of the array.
        # Space Complexity
            - O(1).
            
     */
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                
                if (nums[mid] == target)
                    return mid;
                
                if (nums[left] <= nums[mid])
                {
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid - 1; 
                    }
                    else
                    {
                        left = mid + 1; 
                    }
                }
                else 
                {
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1; 
                    }
                }
            }
            
            return -1;
        }
    }
    
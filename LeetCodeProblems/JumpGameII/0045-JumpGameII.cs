namespace LeetCodeProblems.JumpGameII;

public class _45_JumpGameII
{
    /*
     Problem: Jump Game II
     Intuition: We can solve this problem using a greedy approach. We can keep track of the farthest index we can reach from the current index. 
        We can keep track of the current end of the jump and the farthest index we can reach from the current index.
        If the current index is equal to the current end of the jump, we can increment the number of jumps and update the current end of the jump to the farthest index we can reach from the current index.
        
        Approach:
        - Initialize jumps = 0, currentEnd = 0, farthest = 0
        - Iterate through the array from 0 to nums.Length - 1
            - Update the farthest index we can reach from the current index
            - If the current index is equal to the current end of the jump
                - Increment the number of jumps
                - Update the current end of the jump to the farthest index we can reach from the current index
        - Return the number of jumps
        
        Time Complexity: O(N)
        Space Complexity: O(1)
        
     */
    public int Jump(int[] nums)
    {
        int jumps = 0, currentEnd = 0, farthest = 0;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]);
            if (i != currentEnd) continue;
            jumps++;
            currentEnd = farthest;
        }
        return jumps;
    }
}
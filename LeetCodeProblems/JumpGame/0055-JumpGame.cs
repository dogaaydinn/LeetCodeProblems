namespace LeetCodeProblems.JumpGame;

public class JumpGame
{
    public bool CanJump(int[] nums)
    {
        int maxReach = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > maxReach) return false;
            maxReach = Math.Max(maxReach, i + nums[i]);
        }
        return maxReach >= nums.Length - 1;
    }
}
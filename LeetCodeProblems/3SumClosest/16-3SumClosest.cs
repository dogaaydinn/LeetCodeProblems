namespace LeetCodeProblems._3SumClosest;

public class _16_3SumClosest
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        var closestSum = nums[0] + nums[1] + nums[2];

        for (var i = 0; i < nums.Length - 2; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (Math.Abs(sum - target) < Math.Abs(closestSum - target)) closestSum = sum;

                if (sum < target)
                    left++;
                else
                    right--;
            }
        }

        return closestSum;
    }
}
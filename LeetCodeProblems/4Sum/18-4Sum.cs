namespace LeetCodeProblems._4Sum;

public class _18_4Sum
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        var n = nums.Length;

        for (var i = 0; i < n - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            for (var j = i + 1; j < n - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                int left = j + 1, right = n - 1;

                while (left < right)
                {
                    var sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        left++;
                        right--;

                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}
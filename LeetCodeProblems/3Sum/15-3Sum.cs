namespace LeetCodeProblems._3Sum;

public class _15_3Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                switch (sum)
                {
                    case 0:
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) left++;

                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                        break;
                    }
                    case < 0:
                        left++;
                        break;
                    default:
                        right--;
                        break;
                }
            }
        }

        return result;
    }
}
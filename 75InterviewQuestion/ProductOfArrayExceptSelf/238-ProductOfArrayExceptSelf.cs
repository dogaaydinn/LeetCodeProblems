namespace _75InterviewQuestion.ProductOfArrayExceptSelf;

public class _238_ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var n = nums.Length;
        var output = new int[n];
        output[0] = 1;
        for (var i = 1; i < n; i++) output[i] = output[i - 1] * nums[i - 1];

        var right = 1;
        for (var i = n - 1; i >= 0; i--)
        {
            output[i] *= right;
            right *= nums[i];
        }

        return output;
    }
}
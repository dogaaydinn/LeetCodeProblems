namespace _75InterviewQuestion.ProductOfArrayExceptSelf;

public class _238_ProductOfArrayExceptSelf
{
    /*
     Problem: 238. Product of Array Except Self

        Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

        The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

        Approach:
        1. Initialize an output array with the same length as the nums array.
        2. Set the first element of the output array to 1.
        3. Iterate over the nums array and calculate the product of all elements to the left of the current element.
        4. Iterate over the nums array in reverse and calculate the product of all elements to the right of the current element.
        5. Multiply the left and right products to get the final result.

        Time complexity: O(n), where n is the length of the nums array.
        Space complexity: O(1).
     */
    public int[] ProductExceptSelf(int[] nums)
    {
        if (nums.Length == 0)
        {
            return Array.Empty<int>();
        }

        int n = nums.Length;
        int[] result = new int[n];
        int[] leftProducts = new int[n];
        int[] rightProducts = new int[n];

        leftProducts[0] = 1;
        for (var i = 1; i < n; i++)
        {
            leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
        }

        rightProducts[n - 1] = 1;
        for (var i = n - 2; i >= 0; i--)
        {
            rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
        }

        for (var i = 0; i < n; i++)
        {
            result[i] = leftProducts[i] * rightProducts[i];
        }

        return result;
    }
}
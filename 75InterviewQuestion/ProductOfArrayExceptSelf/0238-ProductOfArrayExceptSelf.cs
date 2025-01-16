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
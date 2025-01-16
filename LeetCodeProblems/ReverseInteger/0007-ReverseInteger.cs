namespace LeetCodeProblems.ReverseInteger;

public static class _007_ReverseInteger
{
    /*
     Problem:
        Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

        Approach:
            1. Initialize a variable to store the reversed number.
            2. Iterate while the number is not zero.
            3. Get the last digit of the number.
            4. Remove the last digit from the number.
            5. Check if the reversed number is within the 32-bit integer range.
            6. Return the reversed number.

            Time complexity: O(log(x))
            Space complexity: O(1)
     */
    public static int Reverse(int x)
    {
        var reversed = 0;

        while (x != 0)
        {
            var pop = x % 10;
            x /= 10;

            switch (reversed)
            {
                case > int.MaxValue / 10:
                case int.MaxValue / 10 when pop > 7:
                case < int.MinValue / 10:
                case int.MinValue / 10 when pop < -8:
                    return 0;
                default:
                    reversed = reversed * 10 + pop;
                    break;
            }
        }

        return reversed;
    }
}
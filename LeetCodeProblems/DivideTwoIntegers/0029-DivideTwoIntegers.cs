namespace LeetCodeProblems.DivideTwoIntegers;

public class _29_DivideTwoIntegers
{
    /*
     Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
        Return the quotient after dividing dividend by divisor.
        The integer division should truncate toward zero, which means losing its fractional part.
        For example, truncating -7 / 3 = -2.

        Approach:
        1. Check if the divisor is 0 or if the dividend is int.MinValue and the divisor is -1.
        2. Check if the result is negative.
        3. Get the absolute values of the dividend and divisor.
        4. Initialize the result as 0.
        5. Iterate while the dividend is greater than or equal to the divisor.
        6. Initialize temp as the divisor and multiple as 1.
        7. Iterate while the dividend is greater than or equal to temp << 1.
        8. Multiply temp and multiple by 2.
        9. Subtract temp from the dividend.
        10. Add multiple to the result.
        11. Return the result.

        Time complexity: O(log n)
        Space complexity: O(1)
     */
    public int Divide(int dividend, int divisor)
    {
        if (divisor == 0) throw new DivideByZeroException();
        if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

        var isNegative = (dividend < 0) ^ (divisor < 0);

        var absDividend = Math.Abs((long)dividend);
        var absDivisor = Math.Abs((long)divisor);

        var result = 0;

        while (absDividend >= absDivisor)
        {
            long temp = absDivisor, multiple = 1;
            while (absDividend >= temp << 1)
            {
                temp <<= 1;
                multiple <<= 1;
            }

            absDividend -= temp;
            result += (int)multiple;
        }

        return isNegative ? -result : result;
    }
}
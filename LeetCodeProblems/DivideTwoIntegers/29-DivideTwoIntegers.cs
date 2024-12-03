namespace LeetCodeProblems.DivideTwoIntegers;

public class _29_DivideTwoIntegers
{
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
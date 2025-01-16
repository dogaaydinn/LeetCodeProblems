using System.Text;

namespace LeetCodeProblems.MultiplyStrings;

public class _43_MultiplyStrings
{
    /*
    Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.
    Approach:
    1. Create an array of size m + n to store the result.
    2. Iterate through the num1 and num2 from right to left.
    3. Multiply the digits at i and j and add it to the result[i + j + 1].
    4. Update the result[i + j + 1] and result[i + j] with the sum.
    5. Convert the result array to a string and return it.

    Complexity Analysis:
    Time Complexity: O(m * n), where m and n are the lengths of num1 and num2.
    Space Complexity: O(m + n), where m and n are the lengths of num1 and num2.

     */
    public string Multiply(string num1, string num2)
    {
        int m = num1.Length, n = num2.Length;
        var result = new int[m + n];

        for (var i = m - 1; i >= 0; i--)
        for (var j = n - 1; j >= 0; j--)
        {
            var mul = (num1[i] - '0') * (num2[j] - '0');
            var sum = mul + result[i + j + 1];

            result[i + j + 1] = sum % 10;
            result[i + j] += sum / 10;
        }

        var sb = new StringBuilder();
        foreach (var num in result)
            if (!(sb.Length == 0 && num == 0))
                sb.Append(num);

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
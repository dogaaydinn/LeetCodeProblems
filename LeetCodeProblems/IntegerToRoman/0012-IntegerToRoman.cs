using System.Text;

namespace LeetCodeProblems.IntegerToRoman;

public class _12_IntegerToRoman
{
    /*
    Given an integer, convert it to a roman numeral.
    Approach:
    1. We will create two arrays.
    2. One array will have the symbols of the roman numerals.
    3. The other array will have the values of the roman numerals.
    4. We will iterate through the values array.
    5. While the number is greater than or equal to the current value, we will append the symbol to the result.
    6. We will subtract the value from the number.
    7. We will return the result.

    Time complexity: O(1)
    Space complexity: O(1)
     */
    public string IntToRoman(int num)
    {
        string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        var result = new StringBuilder();

        for (var i = 0; i < values.Length; i++)
            while (num >= values[i])
            {
                num -= values[i];
                result.Append(symbols[i]);
            }

        return result.ToString();
    }
}
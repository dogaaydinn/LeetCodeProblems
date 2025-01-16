namespace LeetCodeProblems.RomanToInteger;

public class _13_RomanToInteger
{
    /*
     Problem: 13. Roman to Integer
        URL: https://leetcode.com/problems/roman-to-integer/
        Difficulty: Easy
        Description:
            Roman numerals are represented by seven different symbols: I, V, X, L, C, D, and M.
            Symbol       Value
            I            1
            V            5
            X            10
            L            50
            C            100
            D            500
            M            1000
            For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is
            simply X + II. The number 27 is written as XXVII, which is XX + V + II.
            Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII.
            Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same
            principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
                - I can be placed before V (5) and X (10) to make 4 and 9.
                - X can be placed before L (50) and C (100) to make 40 and 90.
                - C can be placed before D (500) and M (1000) to make 400 and 900.
            Given a roman numeral, convert it to an integer.

        Approach:
        1. Create a dictionary with the roman numerals and their values.
        2. Initialize result as 0 and previousValue as 0.
        3. Iterate from the end of the string.
        4. Get the value of the current roman numeral.
        5. If the value is less than the previous value, subtract the value from the result.
        6. Otherwise, add the value to the result.
        7. Set the previous value to the current value.
        8. Return the result.

        Time complexity: O(n), where n is the length of the string.
        Space complexity: O(1).
     */
    public int RomanToInt(string s)
    {
        var roman = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        var result = 0;
        var previousValue = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            var value = roman[s[i]];

            if (value < previousValue)
                result -= value;
            else
                result += value;

            previousValue = value;
        }

        return result;
    }
}
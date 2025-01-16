namespace LeetCodeProblems.StringToInteger;

public static class _008_StringToInteger
{
    /*
        * Problem: 8. String to Integer (atoi)
     * URL: https://leetcode.com/problems/string-to-integer-atoi/
     * Difficulty: Medium
     * Description:
        Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).
        The algorithm for myAtoi(string s) is as follows:
        1. Read in and ignore any leading whitespace.
        2. Check if the next character (if not already at the end of the string) is '-' or '+'. Read this character in if it is either.
        This determines if the final result is negative or positive respectively. Assume the result is positive if neither is present.
        3. Read in next the characters until the next non-digit charcter or the end of the input is reached. The rest of the string is ignored.
        4. Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). If no digits were read, then the integer is 0.
        Change the sign as necessary (from step 2).
        5. If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then clamp the integer so that it remains in the range.
        Specifically, integers less than -231 should be clamped to -231, and integers greater than 231 - 1 should be clamped to 231 - 1.
        6. Return the integer as the final result.
        Note:
        * Only the space character ' ' is considered a whitespace character.
        * Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.
        Example 1:
        Input: s = "42"
        Output: 42
        Explanation: The underlined characters are what is read in, the caret is the current reader position.
        Step 1: "42" (no characters read because there is no leading whitespace)
        Step 2: "42" (no characters read because there is neither a '-' nor '+')
        Step 3: "42" ("42" is read in)
        The parsed integer is 42.
        Since 42 is in the range [-231, 231 - 1], the final result is 42.
        Example 2:
        Input: s = "   -42"
        Output: -42
        Explanation:
        Step 1: "   -42" (leading whitespace is read and ignored)

        Approach:
        1. Initialize i as 0, sign as 1, and result as 0.
        2. Get the length of the string.
        3. Iterate while i is less than n and the character at index i is a space.
        4. If i is less than n and the character at index i is '+' or '-', update the sign accordingly and increment i.
        5. Iterate while i is less than n and the character at index i is a digit.
        6. Get the digit.
        7. If the result is greater than (int.MaxValue - digit) / 10, return int.MaxValue if the sign is positive and int.MinValue if the sign is negative.
        8. Update the result.
        9. Increment i.
        10. Return the result multiplied by the sign.

        Time complexity: O(n), where n is the length of the string.
        Space complexity: O(1).
     */
    public static int MyAtoi(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        int i = 0, sign = 1, result = 0;
        var n = s.Length;

        while (i < n && s[i] == ' ') i++;

        if (i < n && (s[i] == '+' || s[i] == '-'))
        {
            sign = s[i] == '-' ? -1 : 1;
            i++;
        }

        while (i < n && s[i] >= '0' && s[i] <= '9')
        {
            var digit = s[i] - '0';

            if (result > (int.MaxValue - digit) / 10) return sign == 1 ? int.MaxValue : int.MinValue;

            result = result * 10 + digit;
            i++;
        }

        return result * sign;
    }
}
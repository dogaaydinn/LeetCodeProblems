# Problem: 8. String to Integer (atoi)

## Description:
Implement the `myAtoi(string s)` function, which converts a string to a 32-bit signed integer (similar to C/C++'s `atoi` function). The algorithm processes the input string `s` as follows:

1. Read in and ignore any leading whitespace.
2. Check if the next character is `'-'` or `'+'` to determine the sign of the result.
3. Read in all subsequent numeric characters until a non-digit character or the end of the string is reached.
4. Convert the numeric characters to an integer.
5. Clamp the integer to the range `[-2^31, 2^31 - 1]` if it exceeds the limits.
6. Return the resulting integer.

### Notes:
- Only the space character `' '` is considered whitespace.
- Ignore all characters after the numeric portion of the input.



## Approach:
### Steps:
1. **Initialization:**
   - `i = 0`: Index pointer for the string.
   - `sign = 1`: Sign of the result.
   - `result = 0`: Stores the final integer.
   - `n = s.Length`: Length of the string.

2. **Ignore Leading Whitespace:**
   - Increment `i` while `s[i]` is a space.

3. **Check Sign:**
   - If `s[i]` is `'-'`, set `sign = -1`.
   - If `s[i]` is `'+'`, set `sign = 1`.
   - Increment `i`.

4. **Process Digits:**
   - Iterate through the numeric portion of `s`.
   - If `result > (int.MaxValue - digit) / 10`, return `int.MaxValue` or `int.MinValue` based on the `sign`.
   - Update `result = result * 10 + digit`.
   - Increment `i`.

5. **Return Final Result:**
   - Multiply `result` by `sign` and return.

### Complexity Analysis:
- **Time Complexity:** O(n), where `n` is the length of the input string.
- **Space Complexity:** O(1), as no additional space is used.

## Code Implementation:
```csharp
namespace LeetCodeProblems.StringToInteger;

public static class _008_StringToInteger
{
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
```

## Edge Cases:
1. **Empty Input:**
   - Input: `""`
   - Output: `0`

2. **No Numeric Portion:**
   - Input: `"words only"`
   - Output: `0`

3. **Out of Bounds:**
   - Input: `"2147483648"`
   - Output: `2147483647` (Clamped).

4. **Mixed Input:**
   - Input: `"   +004500abc"`
   - Output: `4500`.



# Problem: 13. Roman to Integer

## Description:
Given a Roman numeral, convert it to an integer. Roman numerals are represented by seven different symbols:

| Symbol | Value |
|--------|-------|
| I      | 1     |
| V      | 5     |
| X      | 10    |
| L      | 50    |
| C      | 100   |
| D      | 500   |
| M      | 1000  |

### Special Cases:
- Roman numerals are generally written largest to smallest from left to right.
- Subtraction is used in the following cases:
  - `I` before `V` (4) or `X` (9).
  - `X` before `L` (40) or `C` (90).
  - `C` before `D` (400) or `M` (900).

### Example:
- `II` = 2.
- `XII` = 12 (`X` + `II`).
- `XXVII` = 27 (`XX` + `V` + `II`).
- `IV` = 4 (`V` - `I`).
- `IX` = 9 (`X` - `I`).

## Approach:
To solve the problem:
1. Create a dictionary mapping Roman numeral symbols to their respective integer values.
2. Initialize two variables:
   - `result` to store the final integer.
   - `previousValue` to track the last numeral's value while iterating through the string.
3. Iterate through the string from the end to the beginning:
   - Get the integer value of the current Roman numeral symbol.
   - If the current value is less than `previousValue`, subtract it from `result` (subtraction case).
   - Otherwise, add it to `result`.
   - Update `previousValue` to the current value.
4. Return `result`.

## Complexity Analysis:
- **Time Complexity:** O(n)
  - We iterate through the input string of length `n` once.
- **Space Complexity:** O(1)
  - We use a fixed dictionary and a few integer variables, regardless of input size.

## Code Implementation:

```csharp
namespace LeetCodeProblems.RomanToInteger;

public class _13_RomanToInteger
{
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
```

## Edge Cases:
1. Empty string input (`s = ""`): Return 0 or handle as invalid.
2. Single character input (`s = "I"`): Should return 1.
3. Large numbers (`s = "MMMCMXCIX"`): Should return 3999, the largest valid Roman numeral.

## Notes:
This approach is efficient for valid Roman numeral inputs as per the problem constraints. Additional validation may be added for invalid Roman numeral strings.



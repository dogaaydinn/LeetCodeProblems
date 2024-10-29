# LeetCode Problem 9: Palindrome Number

## Problem Description

Given an integer `x`, return `true` if `x` is a palindrome, and `false` otherwise. A number is considered a palindrome
if it reads the same backward as forward.

### Examples

- **Input:** `x = 121`  
  **Output:** `true`  
  **Explanation:** `121` reads the same forward and backward.

- **Input:** `x = -121`  
  **Output:** `false`  
  **Explanation:** Reading `-121` backward results in `121-`, which is not the same as the original number.

- **Input:** `x = 10`  
  **Output:** `false`  
  **Explanation:** Reading `10` backward results in `01`, which is different from the original.

### Constraints

- The input `x` is in the range `[-2^31, 2^31 - 1]`.

## Approach

### Algorithm

This solution determines whether a number is a palindrome without converting it to a string.

1. **Negative Numbers**: Negative numbers cannot be palindromes because of the negative sign. If `x` is negative, return
   `false`.

2. **Reversing the Number**:
    - We reverse the integer by extracting the last digit using the modulus operator (`% 10`) and building a new number
      by multiplying the current reversed value by 10 and adding the extracted digit.
    - We compare the reversed number with the original number. If they are equal, the number is a palindrome.

### Solution Breakdown

- If `x == int.MinValue`, return `false` because reversing this value exceeds the integer limit.
- Use `Math.Abs()` to work with the absolute value of `x`.
- Reverse the digits by repeatedly extracting the last digit and adding it to the reversed number.
- After reversing, compare it to the original value.

### Code

```csharp
namespace LeetCodeProblems.PalindromeNumber;

public class _009_PalindromeNumber {
    public bool IsPalindrome(int x)
    {
        if (x == int.MinValue) return false;

        var value = x;
        x = Math.Abs(value);

        var reversed = 0;
        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        return reversed == value;
    }
}
```

### Time Complexity

- **Time Complexity:** O(d), where `d` is the number of digits in `x`. We process each digit once.
- **Space Complexity:** O(1), because we only use a few additional variables.

### Edge Cases

- **Negative Numbers**: Palindromes must be positive. Negative numbers return `false`.
- **Single-Digit Numbers**: Any single-digit number is trivially a palindrome (e.g., `x = 7`).
- **Zero**: `x = 0` is a palindrome since it reads the same both ways. 



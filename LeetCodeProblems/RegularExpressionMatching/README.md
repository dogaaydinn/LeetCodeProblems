# Problem: 10. Regular Expression Matching

## Description:
Given an input string `s` and a pattern `p`, implement regular expression matching with support for:
- `.`: Matches any single character.
- `*`: Matches zero or more of the preceding element.

The matching should cover the **entire input string**, not just part of it.

## Approach:
This problem is solved using recursion. The following steps outline the logic:

1. **Base Case:**
   - If the pattern `p` is empty, return `true` if the string `s` is also empty, otherwise `false`.

2. **First Character Match:**
   - Check if the first character of `s` matches the first character of `p` or if `p[0]` is `.` (wildcard).

3. **Handle `*` in the Pattern:**
   - If the second character of the pattern `p` is `*`, there are two scenarios to consider:
     - **Skip the `*` and its preceding element:** Recursively check `IsMatch(s, p.Substring(2))`.
     - **Use the `*` to match the current character in `s`:** Recursively check `IsMatch(s.Substring(1), p)` if there is a match.

4. **No `*` in the Pattern:**
   - Recursively check if the first character matches and the rest of the string matches the rest of the pattern.

5. **Return Result:**
   - Return `true` if the base case or one of the recursive calls evaluates to `true`.

## Complexity Analysis:
- **Time Complexity:** O(2^n), where `n` is the length of the string or pattern.
  - Due to overlapping subproblems, this approach is exponential.
- **Space Complexity:** O(1) for input storage, but the recursion stack depth may go up to O(n).

## Code Implementation

```csharp
namespace LeetCodeProblems.RegularExpressionMatching;

public class _10_RegularExpressionMatching
{
    public bool IsMatch(string s, string p)
    {
        if (string.IsNullOrEmpty(p)) return string.IsNullOrEmpty(s);

        var firstMatch = !string.IsNullOrEmpty(s) &&
                         (p[0] == s[0] || p[0] == '.');

        if (p.Length >= 2 && p[1] == '*')
            return IsMatch(s, p.Substring(2)) ||
                   (firstMatch && IsMatch(s.Substring(1), p));
        return firstMatch && IsMatch(s.Substring(1), p.Substring(1));
    }
}
```


**Explanation:**
- The pattern `.*` matches any sequence of characters.

## Edge Cases:
1. **Empty String:**
   - Input: `s = "", p = "*"`
   - Output: `false`

2. **No Wildcards:**
   - Input: `s = "abc", p = "abc"`
   - Output: `true`

3. **Mismatched Lengths:**
   - Input: `s = "abc", p = "abcd"`
   - Output: `false`

## Notes:
This implementation can be further optimized using **dynamic programming** to store intermediate results and avoid redundant recursive calls.



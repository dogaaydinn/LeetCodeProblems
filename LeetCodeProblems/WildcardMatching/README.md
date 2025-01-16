# Problem: 44. Wildcard Matching

The problem involves implementing wildcard pattern matching for an input string `s` and a pattern `p` where:

- `?` matches any single character.
- `*` matches any sequence of characters (including an empty sequence).

The goal is to determine if the entire input string matches the pattern.

## Approach: Dynamic Programming

### Steps:

1. **Initialize a 2D DP Array:**
    - Create a 2D array `dp` of size `(m + 1) x (n + 1)`, where `m` is the length of `s` and `n` is the length of `p`.
    - `dp[i][j]` indicates whether the first `i` characters of `s` match the first `j` characters of `p`.

2. **Base Case:**
    - `dp[0][0] = true`: An empty string matches an empty pattern.
    - For `j = 1 to n`, set `dp[0][j] = dp[0][j - 1]` if `p[j - 1]` is `*` (an empty string can match a pattern of only
      `*`).

3. **Fill the DP Table:**
    - For `i = 1 to m` and `j = 1 to n`:
        - If `p[j - 1]` is `*`:
            - `dp[i][j] = dp[i - 1][j]` (treat `*` as matching one character) OR `dp[i][j - 1]` (treat `*` as matching
              zero characters).
        - If `p[j - 1]` is `?` or `s[i - 1] == p[j - 1]`:
            - `dp[i][j] = dp[i - 1][j - 1]`.

4. **Return the Result:**
    - The value at `dp[m][n]` indicates whether the entire string matches the pattern.

### Complexity Analysis:

- **Time Complexity:** O(m * n)
    - Each cell in the `dp` array is computed once.
- **Space Complexity:** O(m * n)
    - The size of the `dp` array is proportional to the lengths of `s` and `p`.

## Code Implementation

```csharp
namespace LeetCodeProblems.WildcardMatching;

public class _44_WildcardMatching {
    public bool IsMatch(string s, string p) {
        int m = s.Length, n = p.Length;
        bool[,] dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;

        for (var j = 1; j <= n; j++) {
            if (p[j - 1] == '*') {
                dp[0, j] = dp[0, j - 1];
            }
        }

        for (var i = 1; i <= m; i++) {
            for (var j = 1; j <= n; j++) {
                if (p[j - 1] == '*') {
                    dp[i, j] = dp[i - 1, j] || dp[i, j - 1];
                } else if (p[j - 1] == '?' || s[i - 1] == p[j - 1]) {
                    dp[i, j] = dp[i - 1, j - 1];
                }
            }
        }

        return dp[m, n];
    }
}
```

### Explanation:

- `*` matches the sequence "ad".
- `a` matches `a`.
- `*` matches the sequence "ce".
- `b` matches `b`.

## References:

- [LeetCode Problem #44](https://leetcode.com/problems/wildcard-matching/)



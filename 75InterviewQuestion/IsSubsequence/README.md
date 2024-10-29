# 392. Is Subsequence

This repository contains solutions to the **"Is Subsequence"** problem from LeetCode. The problem is to determine
whether a given string `s` is a subsequence of string `t`.

## Problem Description

Given two strings `s` and `t`, return `true` if `s` is a subsequence of `t`, or `false` otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the
characters without disturbing the relative positions of the remaining characters. For example, `"ace"` is a subsequence
of `"abcde"`, while `"aec"` is not.

### Example 1:

- **Input**: `s = "abc"`, `t = "ahbgdc"`
- **Output**: `true`

### Example 2:

- **Input**: `s = "axc"`, `t = "ahbgdc"`
- **Output**: `false`

### Constraints:

- `0 <= s.length <= 100`
- `0 <= t.length <= 10^4`
- `s` and `t` consist only of lowercase English letters.

## Solutions

### First Solution

The first solution iterates over both strings but uses the `Substring` method to progressively reduce the `mainString` (
i.e., `t`). This approach works but is inefficient due to the continuous creation of new substrings, leading to higher
memory usage and slower execution.

#### Time Complexity:

O(n), where `n` is the length of `t`, but the use of `Substring` can degrade performance.

#### Code:

```csharp
public bool IsSubsequence(string s, string t)
{
    string substring = s;
    string mainString = t;

    if (t.Length < s.Length)
    {
        return false;
    }

    int i = 0;
    while (i < substring.Length && mainString.Length > 0)
    {
        if (mainString[0] == substring[i])
        {
            i++;
        }
        mainString = mainString.Substring(1);
    }
    
    return i == substring.Length;
}

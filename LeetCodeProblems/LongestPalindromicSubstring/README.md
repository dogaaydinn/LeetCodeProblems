# 🔍 Longest Palindromic Substring

This repository provides a solution to the "Longest Palindromic Substring" problem. The implementation finds the longest
palindromic substring within a given string.

## Problem Description

You are given a string `s`. Your task is to find the longest substring that is a palindrome.

### Problem Statement

**Difficulty:** Medium  
**Topics:** String Manipulation, Dynamic Programming  
**Companies:** Google, Amazon

### Example

**Input:**

```csharp
s = "babad"
Output:

arduino
Kodu kopyala
"bab" or "aba"
Explanation: Both "bab" and "aba" are valid answers. The longest palindromic substring can be either "bab" or "aba".

Input:

csharp
Kodu kopyala
s = "cbbd"
Output:

arduino
Kodu kopyala
"bb"
Explanation: The longest palindromic substring is "bb".

## Constraints
**1 <= s.length <= 1000**__
s consists of only printable ASCII characters.
## Approach

**Initialization:** Start with variables to keep track of the start and end indices of the longest palindromic substring.
  
**Expand Around Center:** For each character in the string, treat it as the center of a potential palindrome and expand outward. Consider both odd-length and even-length palindromes.
  
**Update Longest Palindrome:** Update the start and end indices if a longer palindrome is found.
  
**Construct Result:** Use the start and end indices to extract the longest palindromic substring from the original string.
  
## Complexity Analysis

**Time Complexity:** O(n^2), where n is the length of the string. Each expansion operation takes O(n) time, and we perform this operation for each character.
  
**Space Complexity:** O(1). The space complexity is constant as no extra space proportional to input size is used.
  
## Performance

**Runtime:** Efficient for the input size within the constraints.
  
**Memory Usage:** Minimal additional space is used, making the solution space-efficient.
  
## Why This Approach?
Expanding around the center allows the solution to efficiently find palindromes by leveraging the property that palindromes mirror around their center. This approach avoids the need for dynamic programming and provides a clear, understandable method for solving the problem.

## Key Points
**Center Expansion:** The solution efficiently finds palindromes by expanding around possible centers.
  
**Edge Cases:** Handles various edge cases, including very short strings and strings with no palindromes longer than one character.
  
**Efficiency:**Provides a balance between time and space efficiency suitable for the problem constraints.

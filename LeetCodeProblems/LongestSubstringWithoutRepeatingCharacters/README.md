# 🧩 Longest Substring Without Repeating Characters - Sliding Window Approach

This repository presents an efficient solution to the "Longest Substring Without Repeating Characters" problem using a
sliding window technique. The solution achieves an optimal time complexity of `O(n)`.

## Problem Description

The task is to find the length of the longest substring without repeating characters in a given string `s`. This problem
can be solved efficiently using a sliding window approach with a `HashSet`.

### Longest Substring Without Repeating Characters

**Difficulty**: Medium

**Problem Statement**: Given a string `s`, determine the length of the longest substring that contains no repeating
characters.

## Approach

### Initial Thoughts

To efficiently find the longest substring without repeating characters, use a sliding window approach where the window
dynamically adjusts to maintain uniqueness of characters.

### Explanation

1. **Sliding Window Technique**: Maintain a window defined by two pointers, `start` and `currentChar`, and use a
   `HashSet` to track characters within the window.
2. **Character Tracking**: As you iterate through the string, if a character is not in the `HashSet`, add it and update
   the maximum length of the substring. If a character is already present, adjust the window by removing characters from
   the start until the duplicate is removed.

### Edge Cases

- An empty string.
- Strings where all characters are the same.
- Strings with all unique characters.

## Complexity Analysis

- **Time Complexity**: `O(n)`  
  Each character is processed at most twice (once when added and once when removed), making the time complexity linear
  with respect to the length of the string.

- **Space Complexity**: `O(min(n, m))`  
  The space complexity depends on the size of the `HashSet`, which is bounded by the smaller of the string length and
  the character set size.

## Why Sliding Window?

The sliding window approach allows us to efficiently maintain a substring with unique characters by dynamically
adjusting the window size and position. This is preferable to a brute force method which would have higher time
complexity.

## Key Points

- **Maintaining Uniqueness**: Use a `HashSet` to ensure all characters in the current substring are unique.
- **Dynamic Window Adjustment**: Adjust the window size as necessary when duplicates are encountered.

### Example

Given the string:

```plaintext
"abcabcbb"


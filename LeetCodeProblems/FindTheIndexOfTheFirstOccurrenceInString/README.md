### Find the Index of the First Occurrence in a String

This project contains a solution to the problem of finding the first occurrence of a substring (`needle`) within a
string (`haystack`). If the substring is found, the function returns the starting index of the first occurrence;
otherwise, it returns `-1`.

* * * * *

### Problem Description

Given two strings, `needle` and `haystack`:

- Return the index of the first occurrence of `needle` in `haystack`.
- If `needle` is not part of `haystack`, return `-1`.

#### Constraints:

- `1 <= haystack.length, needle.length <= 10⁴`
- Both strings consist of only lowercase English letters.

* * * * *

### Examples

#### Example 1:

text

`Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: The substring "sad" occurs at indices 0 and 6. The first occurrence is at index 0.`

#### Example 2:

`Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: The substring "leeto" does not occur in "leetcode".`

* * * * *

### Approach

The solution uses a **Sliding Window** technique to check substrings of `haystack` with a length equal to `needle`. At
each step, it compares the substring to `needle`:

- If a match is found, the starting index of the substring is returned.
- If no match is found after iterating through the entire `haystack`, the function returns `-1`.

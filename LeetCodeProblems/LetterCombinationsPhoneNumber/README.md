# 🚀 Efficient Solution for 17. Letter Combinations of a Phone Number

This solution tackles the problem of generating all possible letter combinations from a string of digits on a phone
keypad. Each digit from `2` to `9` corresponds to a set of letters, and our goal is to return every valid letter
combination that these digits could represent.

## Problem Statement

Given a string containing digits from `2`-`9`, return all possible letter combinations. The mapping of digits to letters
is based on a standard telephone keypad.

Input: digits = "2"
Output: ["a", "b", "c"]

### Solution Intuition

To solve this problem, we need to generate all possible letter combinations represented by the digits on a phone keypad.
Each digit has a set of corresponding letters, and we can use a depth-first traversal approach to explore all possible
combinations. By using a stack to simulate backtracking, we build letter combinations iteratively, avoiding deep
recursive calls and stack overflows.

### Approach

Mapping Letters to Digits: We create a mapping of each digit (from '2' to '9') to its corresponding letters using a
dictionary for constant-time access.
Iterative Backtracking with Stack:
Initialize a stack with an empty string and index 0.
For each digit, retrieve its letters and add each new combination to the stack by appending letters iteratively.
If the current index matches the length of digits, a complete combination is formed and added to the result.

### Edge Cases:

If digits is empty, immediately return an empty list.
Non-existent digit mappings are handled by skipping them.


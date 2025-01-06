Longest Valid Parentheses
=========================

Problem Description
-------------------

Given a string containing just the characters `'('` and `')'`, return the length of the longest valid (well-formed) parentheses substring.

### Examples

#### Example 1

**Input**: `s = "(()"`\
**Output**: `2`\
**Explanation**: The longest valid parentheses substring is `"()"`.

#### Example 2

**Input**: `s = ")()())"`\
**Output**: `4`\
**Explanation**: The longest valid parentheses substring is `"()()"`.

#### Example 3

**Input**: `s = ""`\
**Output**: `0`

### Constraints

-   0≤s.length≤3×1040 \leq s.length \leq 3 \times 10^40≤s.length≤3×104
-   s[i]s[i]s[i] is `'('` or `')'`.

* * * * *

Solutions
---------

### Approach 1: Stack-Based Solution

This approach uses a stack to keep track of indices of unmatched parentheses. The length of valid parentheses is calculated whenever a match is found.

#### Complexity

-   **Time Complexity**: O(n)O(n)O(n)
-   **Space Complexity**: O(n)O(n)O(n)

Key Insights
------------

1.  **Stack Approach**:

    -   Useful for tracking indices of unmatched parentheses.
    -   Can handle all edge cases effectively.
2.  **Two Counters Approach**:

    -   Space-efficient as it avoids the use of additional data structures.
    -   Traverses the string twice for comprehensive validation.
    
How to Run
----------

1.  Copy the solution code into your C# project.
2.  Call the function `LongestValidParentheses` with the desired input string.
3.  Print or return the output to verify the result.
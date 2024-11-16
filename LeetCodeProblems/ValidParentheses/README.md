# Valid Parentheses

## Problem Description

Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`, determine if the input
string is valid.

An input string is valid if:

1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.
3. Every close bracket has a corresponding open bracket of the same type.

### Examples

#### Example 1

- **Input:** `s = "()"`
- **Output:** `true`

#### Example 2

- **Input:** `s = "()[]{}"`
- **Output:** `true`

#### Example 3

- **Input:** `s = "(]"`
- **Output:** `false`

#### Example 4

- **Input:** `s = "([])"`
- **Output:** `true`

### Constraints

- `1 <= s.length <= 10^4`
- `s` consists of parentheses only `'()[]{}'`.

## Solution

To solve the problem of determining if a string containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and
`']'` is valid, we can use a stack data structure. The stack will help us ensure that each opening bracket has a
corresponding closing bracket in the correct order.

### Approach

1. Use a `Stack<char>` to keep track of the opening brackets.
2. Iterate through each character in the string `s`.
3. If the character is an opening bracket (`'('`, `'{'`, `'['`), push it onto the stack.
4. If the character is a closing bracket (`')'`, `'}'`, `']'`):
    - Check if the stack is empty. If it is, it means there is no corresponding opening bracket, so return `false`.
    - Pop the top element from the stack and check if it matches the corresponding opening bracket. If it doesn't match,
      return `false`.
5. After processing all characters, check if the stack is empty. If it is, it means all opening brackets had matching
   closing brackets in the correct order, so return `true`. If not, return `false`.

### Complexity

- **Time complexity:** \(O(n)\), where \(n\) is the length of the string. We process each character exactly once.
- **Space complexity:** \(O(n)\), where \(n\) is the length of the string. In the worst case, the stack will contain all
  opening brackets.

### Implementation

```csharp
namespace LeetCodeProblems.ValidParentheses;

public class _20_ValidParentheses {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (c is '(' or '{' or '[') {
                stack.Push(c);
            } else {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '[')) {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
```

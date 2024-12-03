## Approach

To solve this problem, we use a Backtracking approach. The idea is to build the parentheses string step by step, adding
one parenthesis at a time while maintaining the rules for well-formed parentheses:

### Base Case: When the current string's length reaches 2 * n, add it to the result.

Recursive Case:
If the number of open parentheses is less than n, add an open parenthesis (.
If the number of close parentheses is less than the number of open parentheses, add a close parenthesis ).
This ensures that we generate all combinations of well-formed parentheses.

- Time Complexity:
  The time complexity is
  𝑂(4𝑛/𝑛), which is related to the number of valid parentheses combinations (Catalan number).


Combination Sum - LeetCode Problem 39
=====================================

Problem Description
-------------------

The **Combination Sum** problem involves finding all unique combinations of candidates where the chosen numbers sum up to a given target. Each number in the candidates array may be used multiple times.

### Rules:

1.  All numbers (including the target) are positive integers.
2.  The solution set must not contain duplicate combinations.
3.  Numbers can be used repeatedly, but the order of elements in the result does not matter.

* * * * *

Solution Explanation
--------------------

### Approach:

The solution uses **Backtracking** to explore all possible combinations of numbers:

1.  **Iterate through candidates**:
    -   For each candidate, check if it is less than or equal to the target.
2.  **Recursive calls**:
    -   Add the candidate to the current combination and reduce the target by the candidate value.
    -   Make a recursive call to explore further possibilities with the updated target.
3.  **Backtracking**:
    -   Remove the last candidate from the current combination to explore other possibilities.
4.  **Base case**:
    -   If the target becomes `0`, add the current combination to the result list.

* * * * *

Code:
-----

```
namespace LeetCodeProblems.CombinationSum;

public class _39_CombinationSum {

    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Backtrack(candidates, target, 0, new List<int>(), result);
        return result;
    }

    private void Backtrack(int[] candidates, int target, int start, List<int> current, IList<IList<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = start; i < candidates.Length; i++) {
            if (candidates[i] <= target) {
                current.Add(candidates[i]);
                Backtrack(candidates, target - candidates[i], i, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}

```

* * * * *

Complexity Analysis
-------------------

**Time Complexity**:

-   **O(2^n)**:
    -   For each candidate, the function explores two possibilities: including or excluding the candidate.
    -   The recursion depth depends on the size of the target and the candidates.

**Space Complexity**:

-   **O(n)**:
    -   The recursion stack uses space proportional to the size of the target (`n`).

* * * * *

Example Usage
-------------

### Input:

```
candidates = [2, 3, 6, 7]
target = 7

```

### Output:

```
[
    [2, 2, 3],
    [7]
]

```

### Explanation:

-   The combinations `[2, 2, 3]` and `[7]` both sum up to `7`.

* * * * *

Steps for Execution
-------------------

1.  Start with the initial target and an empty list (`current`).
2.  For each candidate, either:
    -   Include it in the current combination and reduce the target.
    -   Skip to the next candidate.
3.  If the target reaches `0`, add the current combination to the result list.

* * * * *

Notes:
------

-   The `start` index ensures that each combination is unique by preventing duplicate combinations.
-   The use of backtracking provides an efficient way to explore all valid combinations while pruning unnecessary branches.
-   Handles cases where candidates include repeated values or the target cannot be achieved.

* * * * *

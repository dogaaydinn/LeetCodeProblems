# Combination Sum II - LeetCode Problem #40

## Problem Description

Given a collection of candidate numbers (`candidates`) and a target number (`target`), find all unique combinations in
`candidates` where the candidate numbers sum to `target`.

Each number in `candidates` may only be used once in the combination.

### Constraints:

- All numbers (including `target`) will be positive integers.
- The solution set must not contain duplicate combinations.

## Approach

The solution utilizes backtracking with the following steps:

1. **Sort the Candidates Array:**
    - Sorting helps in efficiently skipping duplicate elements and terminating recursion early when the current element
      exceeds the target.

2. **Backtracking Logic:**
    - Start iterating through the sorted array from a given index.
    - Skip duplicates by ensuring that the current element is not the same as the previous element.
    - Break the loop if the current element exceeds the target.
    - Add the current element to the combination and recursively call the function with the updated target and start
      index.
    - Remove the last element from the combination after the recursive call to explore other possibilities.

3. **Base Case:**
    - If the target becomes zero, add the current combination to the result list.

### Time Complexity

- **O(2^n):** In the worst case, every subset of the array is considered.

### Space Complexity

- **O(n):** For the recursion stack and storing combinations.

## Code

```csharp
namespace LeetCodeProblems.CombinationSumII;

public class _40_CombinationSumII
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        List<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();
        Backtrack(candidates, target, 0, current, result);
        return result;
    }

    private static void Backtrack(int[] candidates, int target, int start, List<int> current, List<IList<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (var i = start; i < candidates.Length; i++)
        {
            if (i > start && candidates[i] == candidates[i - 1]) continue; // Skip duplicates
            if (candidates[i] > target) break;

            current.Add(candidates[i]);
            Backtrack(candidates, target - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
```

## Example

### Input:

```plaintext
candidates = [10,1,2,7,6,1,5]
target = 8
```

### Output:

```plaintext
[
  [1,1,6],
  [1,2,5],
  [1,7],
  [2,6]
]
```

### Explanation:

The unique combinations that sum up to 8 are returned in the result set.

### Input:

```plaintext
candidates = [2,5,2,1,2]
target = 5
```

### Output:

```plaintext
[
  [1,2,2],
  [5]
]
```

### Explanation:

The result excludes duplicate combinations, ensuring uniqueness.

## Key Notes

- **Sorting:** Sorting is crucial for efficiently handling duplicates and pruning the search space.
- **Duplicate Skipping:** Avoid adding duplicate combinations by checking if the current element is the same as the
  previous one when iterating.
- **Recursive Backtracking:** The solution explores all possibilities by recursively including and excluding elements.

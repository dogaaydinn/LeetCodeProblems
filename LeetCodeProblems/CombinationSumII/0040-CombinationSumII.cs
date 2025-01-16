namespace LeetCodeProblems.CombinationSumII;

public class _40_CombinationSumII
{
    /*
     Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.
     Each number in candidates may only be used once in the combination.
     Note: The solution set must not contain duplicate combinations.

     Approach:
        1. Sort the candidates array.
        2. Use backtracking to find all the combinations.
        3. Skip duplicates by checking if the current element is the same as the previous element.
        4. If the current element is greater than the target, break the loop.
        5. Add the current element to the list and call the backtrack function recursively with the updated target and start index.
        6. Remove the last element from the list after the recursive call.
        7. Return the result.

        Time complexity: O(2^n)
        Space complexity: O(n)

     */
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        List<IList<int>> result = new();
        var current = new List<int>();
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
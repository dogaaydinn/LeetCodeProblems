namespace LeetCodeProblems.CombinationSum;

public class _39_CombinationSum {
    
    /*
     Approach:
    1. We will use backtracking to find the combination sum.
    2. We will iterate through the candidates.
    3. If the candidate is less than or equal to the target, we will add the candidate to the current list.
    4. We will recursively call the backtrack function with the target - candidate.
    5. We will remove the candidate from the current list.
    6. We will continue the loop.
    7. If the target is 0, we will add the current list to the result.
    8. Time complexity is O(2^n) and space complexity is O(n).
    
     */
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
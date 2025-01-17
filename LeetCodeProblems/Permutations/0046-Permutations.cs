namespace LeetCodeProblems.Permutations;

public class _0046_Permutations {

    /*
     Intuition:
        - We can solve this problem using backtracking.
        - We will create a recursive function that will take the current list of numbers and the current permutation.
        - If the current permutation is equal to the length of the input array, we will add the current permutation to the result.
        - Otherwise, we will iterate over the input array and add the current number to the current permutation if it is not already in the current permutation.
        - We will then call the recursive function with the updated current permutation.
        - After the recursive call, we will remove the last element from the current permutation to backtrack.
        
        Approach:
        - Create a list to store the result.
        - Call the recursive function with the input array, an empty list, and the result.
        - Return the result.
        
        Complexity Analysis:
        - The time complexity for this approach is O(n! * n) where n is the length of the input array.
        - The space complexity is O(n) where n is the length of the input array.
     */
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        Backtrack(nums, new List<int>(), result);
        return result;
    }
    private void Backtrack(int[] nums, List<int> current, List<IList<int>> result)
    {
        if (current.Count == nums.Length) {
            result.Add(new List<int>(current));
            return;
        }

        foreach (var t in nums)
        {
            if (current.Contains(t)) continue;
            current.Add(t);
            Backtrack(nums, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
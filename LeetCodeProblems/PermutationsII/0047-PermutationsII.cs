namespace LeetCodeProblems.PermutationsII;

public class PermutationsII
{
    /*
        * Problem: 47. Permutations II,
     Intuition:
        - We can use the same approach as in the Permutations problem, but we need to handle duplicates.
        - To handle duplicates, we need to sort the input array and skip the current element if it is equal to the previous element and the previous element is not used.
        - We can use a boolean array to keep track of the used elements.
    
    Approach:
        - Sort the input array.
        - Create a boolean array to keep track of the used elements.
        - Call the Backtrack method with the input array, the boolean array, an empty list to store the current permutation, and an empty list to store the results.
        - In the Backtrack method:
            - If the current permutation has the same length as the input array, add it to the results list.
            - Iterate over the input array:
                - If the current element is used or the previous element is equal to the current element and the previous element is not used, skip the current element.
                - Mark the current element as used.
                - Add the current element to the current permutation.
                - Call the Backtrack method recursively.
                - Mark the current element as not used.
                - Remove the current element from the current permutation.
        - Return the results list.
        
    Complexity Analysis:
        - Time Complexity: O(N * N!), where N is the length of the input array.
        - Space Complexity: O(N * N!).
     */
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        var results = new List<IList<int>>();
        Array.Sort(nums);
        Backtrack(nums, new bool[nums.Length], new List<int>(), results);
        return results;
    }

    private void Backtrack(int[] nums, bool[] used, List<int> current, List<IList<int>> results)
    {
        if (current.Count == nums.Length)
        {
            results.Add(new List<int>(current));
            return;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (used[i] || (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]))
            {
                continue;
            }

            used[i] = true;
            current.Add(nums[i]);
            Backtrack(nums, used, current, results);
            used[i] = false;
            current.RemoveAt(current.Count - 1);
        }
    }
}
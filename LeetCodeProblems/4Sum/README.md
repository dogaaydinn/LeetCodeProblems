# LeetCode Problem 18: 4Sum

## Problem Description

Given an integer array `nums` and an integer `target`, find all unique quadruplets
`[nums[a], nums[b], nums[c], nums[d]]` such that:

- \(0 \leq a, b, c, d < n\)
- `a`, `b`, `c`, and `d` are distinct indices
- \( \text{nums[a]} + \text{nums[b]} + \text{nums[c]} + \text{nums[d]} = \text{target} \)

The solution should return the quadruplets in any order, and each quadruplet must be unique.

### Example 1

- **Input**: `nums = [1, 0, -1, 0, -2, 2]`, `target = 0`
- **Output**: `[[-2, -1, 1, 2], [-2, 0, 0, 2], [-1, 0, 0, 1]]`

### Example 2

- **Input**: `nums = [2, 2, 2, 2, 2]`, `target = 8`
- **Output**: `[[2, 2, 2, 2]]`

### Constraints

- \( 1 \leq \text{nums.length} \leq 200 \)
- \( -10^9 \leq \text{nums[i]} \leq 10^9 \)
- \( -10^9 \leq \text{target} \leq 10^9 \)

## Solution Approach

To find all unique quadruplets that sum to the target, we use the following approach:

1. **Sorting**: Sort the array `nums` to simplify the search for unique quadruplets.

2. **Two Loops with Two-Pointer Technique**:
    - Use two nested loops to select the first two elements of each quadruplet. These loops set `i` and `j` as the first
      and second elements, respectively.
    - Initialize two pointers, `left` and `right`, to select the remaining two elements.
    - Adjust the pointers to check all possible combinations:
        - If the sum of `nums[i] + nums[j] + nums[left] + nums[right]` equals the target, add this quadruplet to the
          result list.
        - If the sum is less than the target, increment `left` to increase the sum.
        - If the sum is greater than the target, decrement `right` to decrease the sum.

3. **Avoiding Duplicates**:
    - Skip duplicate elements by checking if the current element equals the previous one, to ensure unique quadruplets.

## Complexity

- **Time Complexity**: \(O(n^3)\), due to the two loops and two-pointer technique.
- **Space Complexity**: \(O(k)\), where \(k\) is the number of unique quadruplets added to the result list.

## Solution Code

```csharp
public IList<IList<int>> FourSum(int[] nums, int target) {
    Array.Sort(nums);
    var result = new List<IList<int>>();
    int n = nums.Length;

    for (int i = 0; i < n - 3; i++) {
        if (i > 0 && nums[i] == nums[i - 1]) continue;
        for (int j = i + 1; j < n - 2; j++) {
            if (j > i + 1 && nums[j] == nums[j - 1]) continue;
            int left = j + 1, right = n - 1;

            while (left < right) {
                long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                if (sum == target) {
                    result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1]) left++;
                    while (left < right && nums[right] == nums[right + 1]) right--;
                } else if (sum < target) {
                    left++;
                } else {
                    right--;
                }
            }
        }
    }

    return result;
}

# First Missing Positive - LeetCode Problem #41

## Problem Description

Given an unsorted integer array `nums`, return the smallest missing positive integer.

You must implement an algorithm that runs in **O(n)** time and uses constant extra space.

### Constraints:

- `1 <= nums.length <= 5 * 10^5`
- `-2^31 <= nums[i] <= 2^31 - 1`

## Approach

The solution utilizes the **Cyclic Sort** algorithm to place each number in its correct position. The main idea is to
rearrange the array such that each positive integer `x` is placed at index `x - 1`. This approach ensures constant space
usage while achieving linear time complexity.

### Steps:

1. **Rearrange Elements:**
    - Iterate through the array and place each number in its correct position (`nums[i] - 1`) if:
        - The number is positive.
        - The number is less than or equal to the array length.
        - The target position does not already contain the number.
    - Use a helper function `Swap` to swap elements between the current and target positions.

2. **Identify Missing Positive:**
    - After rearranging, iterate through the array again.
    - The first index `i` where `nums[i] != i + 1` indicates that the missing positive integer is `i + 1`.

3. **Edge Case:**
    - If all elements are in their correct positions, the missing positive integer is `n + 1`.

### Time Complexity

- **O(n):** Each element is moved to its correct position at most once.

### Space Complexity

- **O(1):** The rearrangement is done in-place without using additional space.

## Code

```csharp
namespace LeetCodeProblems.FirstMissingPositive;

public class _41_FirstMissingPositive {
    public int FirstMissingPositive(int[] nums) {
        var n = nums.Length;

        for (var i = 0; i < n; i++) {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) {
                Swap(nums, i, nums[i] - 1);
            }
        }

        for (var i = 0; i < n; i++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }

        return n + 1;
    }

    private void Swap(int[] nums, int i, int j) {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }
}
```

## Example

### Input:

```plaintext
nums = [3, 4, -1, 1]
```

### Output:

```plaintext
2
```

### Explanation:

After rearranging the array, the elements are positioned as `[1, -1, 3, 4]`. The first missing positive is `2`.

### Input:

```plaintext
nums = [1, 2, 0]
```

### Output:

```plaintext
3
```

### Explanation:

After rearranging the array, the elements are positioned as `[1, 2, 0]`. The first missing positive is `3`.

## Key Notes

- **Cyclic Sort:** Ensures that elements are placed in their correct indices.
- **Edge Cases:**
    - Input contains only negative numbers.
    - Input contains consecutive positive integers starting from 1.
    - Input is empty.

This approach is efficient and meets the problem's constraints of **O(n)** time complexity and constant space usage.


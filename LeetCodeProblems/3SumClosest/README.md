# 3Sum Closest Solution

## Problem Description

Given an integer array `nums` and an integer `target`, find three integers in `nums` such that the sum is closest to
`target`. Return the sum of these three integers. Each input will have exactly one solution.

- **Example 1**:
    - **Input**: `nums = [-1, 2, 1, -4]`, `target = 1`
    - **Output**: `2`
    - **Explanation**: The sum that is closest to the target is `2` (`-1 + 2 + 1 = 2`).

- **Example 2**:
    - **Input**: `nums = [0, 0, 0]`, `target = 1`
    - **Output**: `0`
    - **Explanation**: The sum that is closest to the target is `0` (`0 + 0 + 0 = 0`).

## Approach

1. **Sort the Array**: Begin by sorting `nums` in ascending order. This helps with a structured approach using two
   pointers to find the closest sum.

2. **Initialize Closest Sum**: Set an initial `closestSum` as the sum of the first three elements, serving as a baseline
   to update if a closer sum is found.

3. **Two-Pointer Technique**:
    - Iterate through each element in `nums` with index `i`.
    - Set two pointers: `left` (starting from `i + 1`) and `right` (starting from the end of the array).
    - Calculate the sum of `nums[i]`, `nums[left]`, and `nums[right]`.
    - Update `closestSum` if this current sum is closer to the target.
    - Adjust pointers:
        - Increment `left` if the current sum is less than the target.
        - Decrement `right` if the current sum is greater than the target.
    - If the current sum matches the target exactly, return it immediately.

4. **Return**: After evaluating all possibilities, return `closestSum` as the closest achievable sum to the target.

## Code Implementation

```csharp
public int ThreeSumClosest(int[] nums, int target) {
    Array.Sort(nums);
    int closestSum = nums[0] + nums[1] + nums[2];
    
    for (int i = 0; i < nums.Length - 2; i++) {
        int left = i + 1;
        int right = nums.Length - 1;
        
        while (left < right) {
            int sum = nums[i] + nums[left] + nums[right];
            
            if (Math.Abs(sum - target) < Math.Abs(closestSum - target)) {
                closestSum = sum;
            }
            
            if (sum < target) {
                left++;
            } else {
                right--;
            }
        }
    }
    
    return closestSum;
}

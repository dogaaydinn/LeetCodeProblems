# 🎯 Two Sum - Optimal Solution

This repository provides an optimal solution for the "Two Sum" problem, where the goal is to find indices of two numbers
in an array that add up to a given target. The solution leverages a hash-based approach to achieve efficient
performance.

## Problem Description

Given an array of integers `nums` and an integer `target`, the task is to return the indices of the two numbers such
that they add up to `target`. You may assume that each input would have exactly one solution, and you may not use the
same element twice.

### Examples

**Example 1**:

- **Input**: `nums = [2,7,11,15]`, `target = 9`
- **Output**: `[0, 1]`
- **Explanation**: Because `nums[0] + nums[1] == 9`, we return `[0, 1]`.

**Example 2**:

- **Input**: `nums = [3,2,4]`, `target = 6`
- **Output**: `[1, 2]`

**Example 3**:

- **Input**: `nums = [3,3]`, `target = 6`
- **Output**: `[0, 1]`

### Constraints

- `2 <= nums.length <= 10^4`
- `-10^9 <= nums[i] <= 10^9`
- `-10^9 <= target <= 10^9`
- Only one valid answer exists.

## Approach

1. **Initialize Data Structures**: Use a dictionary to map each number to its index as you iterate through the array.

2. **Iterate and Check**: For each number in the array, compute the complement needed to reach the target. Check if this
   complement exists in the dictionary:
    - If it does, return the indices of the current number and the complement.
    - If it does not, add the current number and its index to the dictionary.

3. **Handle No Solution**: If no valid pair is found during the iteration, throw an exception. However, the problem
   guarantees that there will be exactly one solution.

## Complexity

- **Time Complexity**: `O(n)`  
  Each element is processed once, and dictionary operations (insert and lookup) are average `O(1)`.

- **Space Complexity**: `O(n)`  
  The space complexity is proportional to the number of elements in the dictionary, which can be up to the size of the
  input array.

## Performance

- **Runtime**: 117 ms (Beats 72.87% of submissions)
- **Memory Usage**: 47.87 MB (Beats 40.95% of submissions)


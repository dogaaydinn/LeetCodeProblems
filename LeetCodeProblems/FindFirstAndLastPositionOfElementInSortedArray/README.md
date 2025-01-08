# Find First and Last Position of Element in Sorted Array

## Problem Description

Given an array of integers `nums` sorted in non-decreasing order, find the starting and ending position of a given `target` value.

If the `target` is not found in the array, return `[-1, -1]`.

The algorithm must run in **O(log N)** runtime complexity.

---

## Approach

To efficiently solve the problem, we use **Binary Search** to find:

1\. **First Occurrence** of the `target`.

2\. **Last Occurrence** of the `target`.

### Steps:

1\. Perform a binary search to locate the first occurrence of the `target`.

   - If `nums[mid] == target`, update `first` and search in the left half to check for earlier occurrences.

   - Adjust the search range (`left` and `right`) based on comparisons.

2\. Perform another binary search to locate the last occurrence of the `target`.

   - If `nums[mid] == target`, update `last` and search in the right half to check for later occurrences.

   - Adjust the search range (`left` and `right`) based on comparisons.

3\. Return the indices `[first, last]`.

### Complexity:

- **Time Complexity:** `O(log N)` because binary search halves the search range at each step.

- **Space Complexity:** `O(1)` as no additional space is used.

---

## Code Implementation

```csharp

namespace LeetCodeProblems.FindFirstAndLastPositionOfElementInSortedArray;

public class _34_FindFirstAndLastPositionOfElementInSortedArray {

    /*

     # Intuition

       - We can use binary search to solve this problem.

         - Find the first occurrence of the target.

         - Find the last occurrence of the target.

         - Return the indices of the first and last occurrences.

        # Time Complexity

            - O(logN), where N is the length of the array.

        # Space Complexity

            - O(1).

     */

    public int[] SearchRange(int[] nums, int target) {

        var left = 0;

        var right = nums.Length - 1;

        var first = -1;

        var last = -1;

        while (left <= right) {

            var mid = left + (right - left) / 2;

            if (nums[mid] == target) {

                first = mid;

                right = mid - 1; // Narrow search to left for earlier occurrences

            } else if (nums[mid] < target) {

                left = mid + 1;

            } else {

                right = mid - 1;

            }

        }

        left = 0;

        right = nums.Length - 1;

        while (left <= right) {

            var mid = left + (right - left) / 2;

            if (nums[mid] == target) {

                last = mid;

                left = mid + 1; // Narrow search to right for later occurrences

            } else if (nums[mid] < target) {

                left = mid + 1;

            } else {

                right = mid - 1;

            }

        }

        return new int[] {first, last};

    }

}

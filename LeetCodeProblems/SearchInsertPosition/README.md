# Search Insert Position

## Problem Description

Given a sorted array of distinct integers `nums` and a target value `target`, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

The algorithm must run in **O(log N)** runtime complexity.

---

## Approach

The solution uses **Binary Search** to efficiently find the position where the target value should exist in the array.

### Steps:

1\. Initialize two pointers, `left` and `right`, to the start and end of the array, respectively.

2\. Perform a binary search:

   - Calculate the middle index (`mid`) of the current search range.

   - If `nums[mid] == target`, return `mid`.

   - If `nums[mid] < target`, move the `left` pointer to `mid + 1` (search in the right half).

   - If `nums[mid] > target`, move the `right` pointer to `mid - 1` (search in the left half).

3\. If the target is not found, return the `left` pointer, which represents the index where the target should be inserted.

### Complexity:

- **Time Complexity:** `O(log N)` due to the binary search.

- **Space Complexity:** `O(1)` as no additional space is used.

---

## Code Implementation

```csharp

namespace LeetCodeProblems.SearchInsertPosition;

public class _35_SearchInsertPosition {

    /*

     Approach:

     1. Use binary search to find the target element.

     2. If the target is found, return the index.

     3. If not found, return the index where the target should be inserted.

     4. Time complexity: O(log N), Space complexity: O(1).

     */

    public int SearchInsert(int[] nums, int target) {

        var left = 0;

        var right = nums.Length - 1;

        while (left <= right) {

            var mid = left + (right - left) / 2;

            if (nums[mid] == target) {

                return mid; // Target found

            }

            if (nums[mid] < target) {

                left = mid + 1; // Search in the right half

            } else {

                right = mid - 1; // Search in the left half

            }

        }

        return left; // Target not found, return insert position

    }

}
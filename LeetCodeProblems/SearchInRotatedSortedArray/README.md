Solution Description
--------------------

This solution uses a modified **Binary Search** algorithm to achieve the required `O(log n)` time complexity. Since the array is rotated, we determine which half of the array is sorted at each step and narrow the search space accordingly.

### Algorithm Steps:

1.  Initialize two pointers: `left` (start of the array) and `right` (end of the array).
2.  Calculate the middle index (`mid`) of the current search range.
3.  Check if the `target` is at `nums[mid]`. If yes, return `mid`.
4.  Determine which half of the array is sorted:
    -   If `nums[left] <= nums[mid]`, then the left half is sorted.
    -   Otherwise, the right half is sorted.
5.  Narrow the search space:
    -   If the `target` is within the sorted half, continue searching there.
    -   Otherwise, move to the other half.
6.  Repeat until the `target` is found or the search space is empty.

Complexity Analysis
-------------------

-   **Time Complexity:** `O(log n)`
    -   Each iteration halves the search space.
-   **Space Complexity:** `O(1)`
    -   No additional data structures are used.

* * * * *

How to Run
----------

1.  Copy the code into a C# development environment (e.g., Visual Studio, JetBrains Rider, or .NET CLI).
2.  Define the input array `nums` and the `target` value.
3.  Call the `Search` method and print the result.

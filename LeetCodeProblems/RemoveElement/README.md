To solve the "Remove Element" problem, we aim to modify the given array `nums` in place to exclude all occurrences of the specified value `val`. We'll return the count kkk, representing the number of elements remaining after the removal. Let's break this problem into logical steps and implement a simple algorithm:

* * * * *

### Approach:

1.  **Two Pointers**:
    -   Use one pointer (`index`) to iterate through the array.
    -   Use another pointer (`k`) to track the position where the next "non-val" element should be placed.
2.  **Process**:
    -   Traverse the array.
    -   If the current element is not equal to `val`, place it at `nums[k]` and increment `k`.
    -   Skip elements equal to `val`.
3.  **Result**:
    -   After the loop, `k` will represent the number of elements that are not equal to `val`.
    -   The array's first kkk elements will contain the desired values.

### Explanation:

1.  **Input**:
    -   `nums = [3, 2, 2, 3], val = 3`
2.  **Execution**:
    -   Iterate through the array:
        -   For `index = 0`: `nums[0] == 3` → Skip.
        -   For `index = 1`: `nums[1] == 2` → Place `2` at `nums[k]`, increment `k`.
        -   For `index = 2`: `nums[2] == 2` → Place `2` at `nums[k]`, increment `k`.
        -   For `index = 3`: `nums[3] == 3` → Skip.
    -   Final array: `nums = [2, 2, _, _]`.
3.  **Output**:
    -   `k = 2`.

* * * * *

### Complexity:

-   **Time Complexity**: O(n), where nnn is the length of the array. We traverse the array once.
-   **Space Complexity**: O(1), as no extra space is used.

* * * * *

### Edge Cases:

1.  **Empty Array**:
    -   Input: `nums = [], val = 1`
    -   Output: `k = 0`.
2.  **All Elements Match `val`**:
    -   Input: `nums = [1, 1, 1], val = 1`
    -   Output: `k = 0`.
3.  **No Elements Match `val`**:
    -   Input: `nums = [1, 2, 3], val = 4`
    -   Output: `k = 3`.

This algorithm efficiently handles all edge cases while adhering to the problem's constraints.
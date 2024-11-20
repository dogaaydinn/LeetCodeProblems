### **Approach**

1.  **Use Two Pointers**:

    -   One pointer (`writeIndex`) keeps track of the position to write the next unique value.
    -   The other pointer (`readIndex`) iterates through the array to find unique elements.
2.  **Algorithm**:

    -   Start with `writeIndex` at `0` (first position).
    -   Iterate through the array using `readIndex`.
    -   Whenever `nums[readIndex]` is not equal to `nums[writeIndex]`, increment `writeIndex` and update `nums[writeIndex]` to `nums[readIndex]`.
    -   Continue until the end of the array.
3.  **Return Value**:

    -   The total count of unique elements is `writeIndex + 1`.
4.  **Complexity**:

    -   **Time Complexity**: O(n)O(n)O(n), where nnn is the size of the array (one pass through the array).
    -   **Space Complexity**: O(1)O(1)O(1), as no extra space is used.

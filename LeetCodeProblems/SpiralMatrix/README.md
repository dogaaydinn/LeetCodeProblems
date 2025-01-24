Algorithm Explanation
---------------------

1.  **Initialize Boundaries**: Set `top`, `bottom`, `left`, and `right` to represent the current boundaries of the matrix.

2.  **Traverse Right**: Move from the `left` to the `right` along the `top` boundary and add elements to the result. Increment `top`.

3.  **Traverse Down**: Move from the `top` to the `bottom` along the `right` boundary and add elements to the result. Decrement `right`.

4.  **Traverse Left**: If the `top` has not crossed the `bottom`, move from the `right` to the `left` along the `bottom` boundary and add elements to the result. Decrement `bottom`.

5.  **Traverse Up**: If the `left` has not crossed the `right`, move from the `bottom` to the `top` along the `left` boundary and add elements to the result. Increment `left`.

6.  **Repeat**: Continue the process until all layers of the matrix have been traversed.

Complexity
----------

-   **Time Complexity**: O(m * n), where `m` is the number of rows and `n` is the number of columns in the matrix. Each element is visited exactly once.

-   **Space Complexity**: O(m * n), as we store the spiral order traversal in the result list.
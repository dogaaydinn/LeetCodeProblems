Problem Description
-------------------

The N-Queens puzzle requires placing `n` queens on an `n x n` chessboard so that no two queens threaten each other. That means no two queens can share the same row, column, or diagonal.

**Example 1:**

-   **Input:** `n = 4`
-   **Output:**


  	[
      [".Q..", "...Q", "Q...", "..Q."],
      ["..Q.", "Q...", "...Q", ".Q.."]
    ]

    There are two distinct solutions for placing queens on a 4x4 chessboard.

**Example 2:**

-   **Input:** `n = 1`
-   **Output:**


    [
      ["Q"]
    ]

Intuition
---------

-   **Basic Idea:**\
    Since only one queen can be placed per row, the problem can be approached row by row. For every row, you determine the safe columns where a queen can be placed without being attacked by queens already placed in previous rows.

-   **Attack Zones:**\
    A queen can attack along the same column, the main diagonal (`row - col`), and the anti-diagonal (`row + col`). These are the three constraint groups to check for each candidate position.

Approach
--------

-   **Backtracking:**
    1.  **Row-by-Row Placement:**\
        Process the board row by row, trying all columns in each row.

    2.  **Constraint Tracking:**\
        Use data structures (like `HashSet`s) to keep track of:

        -   Which columns already contain a queen.
        -   Which diagonals (using `row - col` for the main diagonal and `row + col` for the anti-diagonal) have already been occupied.
    3.  **Recursive Exploration:**\
        If a queen can be placed in a row without conflicts, move to the next row. If a dead-end is reached (no safe placements for the current row), backtrack to try alternative positions in previous rows.

    4.  **Board Construction:**\
        Once a valid configuration is found (i.e., queens are successfully placed in all rows), construct the board in the required format using strings (with `"Q"` to represent a queen and `"."` for empty spaces).

Time Complexity
---------------

-   **Worst-Case:**\
    The worst-case time complexity is **O(n!)** since in theory, each row could have up to `n` possible positions, and the number of arrangements is factorial in nature.
-   **Optimization Note:**\
    The use of pruning via tracking columns and diagonals significantly reduces the number of candidate positions that need to be explored, improving the overall performance on average.

Validate Sudoku Board
=====================

Problem Description
-------------------

The goal is to validate if a given 9x9 Sudoku board is valid. A Sudoku board is valid if:

1.  Each row contains the digits `1-9` without repetition.
2.  Each column contains the digits `1-9` without repetition.
3.  Each of the 9 sub-boxes (3x3 grids) contains the digits `1-9` without repetition.

The input board may contain empty cells represented by the `'.'` character.

**Constraints:**

-   The board size is always `9x9`.
-   Each cell may contain a digit (`'1'` to `'9'`) or `'.'`.

* * * * *

Solution Explanation
--------------------

### Approach:

This solution uses **HashSets** to keep track of the numbers seen in each row, column, and sub-box. The algorithm iterates over each cell of the board and performs the following steps:

1.  **Skip empty cells**: If the cell contains `'.'`, continue to the next cell.
2.  **Generate unique keys**:
    -   A key for the row: `"rowIndex-digit"`
    -   A key for the column: `"colIndex-digit"`
    -   A key for the 3x3 sub-box: `"boxRow-boxCol-digit"`
3.  **Validate keys**:
    -   Check if the key already exists in the respective HashSet (row, column, or box). If it exists, the board is invalid, and the function returns `false`.
4.  **Add keys to HashSets**:
    -   If the key is unique, add it to the respective HashSet.

If the entire board is traversed without finding any conflicts, return `true`.

* * * * *

### Code:

csharp

Kodu kopyala

`public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<string>();
        var columns = new HashSet<string>();
        var boxes = new HashSet<string>();

        for (var i = 0; i < 9; i++) {
            for (var j = 0; j < 9; j++) {
                var cell = board[i][j];

                if (cell == '.') {
                    continue;
                }

                var rowKey = $"{i}-{cell}";
                var columnKey = $"{j}-{cell}";
                var boxKey = $"{i / 3}-{j / 3}-{cell}";

                if (rows.Contains(rowKey) || columns.Contains(columnKey) || boxes.Contains(boxKey)) {
                    return false;
                }

                rows.Add(rowKey);
                columns.Add(columnKey);
                boxes.Add(boxKey);
            }
        }

        return true;
    }
}`

* * * * *

Complexity Analysis
-------------------

**Time Complexity**:

-   The algorithm iterates through all `81` cells in the board.
-   Adding or checking elements in a HashSet is an `O(1)` operation.
-   Total: **O(81) = O(1)** (constant time due to fixed board size).

**Space Complexity**:

-   Three HashSets are used to store unique keys:
    -   `rows` for up to 81 entries (9 digits per row, max 9 rows).
    -   `columns` for up to 81 entries.
    -   `boxes` for up to 81 entries.
-   Total: **O(1)** (constant space due to fixed board size).

* * * * *

Notes:
------

-   This solution is highly efficient for the fixed size of a Sudoku board.
-   It's a simple and clean implementation, leveraging HashSets for validation.
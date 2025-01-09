namespace LeetCodeProblems.SudokuSolver;

public class _37_SudokuSolver {
    /*
     Approach:
    1. We will use backtracking to solve the sudoku.
    2. We will iterate through the board.
    3. If we find a cell with '.', we will try to fill the cell with numbers from 1 to 9.
    4. If the number is valid, we will fill the cell with the number.
    5. If the number is not valid, we will backtrack and try the next number.
    6. If we are able to fill all the cells with valid numbers, we will return true.
    7. If we are not able to fill all the cells with valid numbers, we will return false.
    8. Time complexity is O(9^(m*n)) and space complexity is O(m*n).
    
     */
    public void SolveSudoku(char[][] board) {
        Solve(board);
    }

    private bool Solve(char[][] board) {
        for (var row = 0; row < 9; row++) {
            for (var col = 0; col < 9; col++)
            {
                if (board[row][col] != '.') continue;
                for (var num = '1'; num <= '9'; num++)
                {
                    if (!IsValid(board, row, col, num)) continue;
                    board[row][col] = num;
                    if (Solve(board)) {
                        return true;
                    }
                    board[row][col] = '.';
                }
                return false;
            }
        }
        return true;
    }

    private bool IsValid(char[][] board, int row, int col, char num) {
        for (var i = 0; i < 9; i++) {
            if (board[row][i] == num || board[i][col] == num || 
                board[row / 3 * 3 + i / 3][col / 3 * 3 + i % 3] == num) {
                return false;
            }
        }
        return true;
    }
}
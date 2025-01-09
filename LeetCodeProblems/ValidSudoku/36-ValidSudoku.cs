namespace LeetCodeProblems.ValidSudoku;

public class _36_ValidSudoku {
    
    /*
     Approach:
    1. We will use hashset to store the row, column and box.
    2. We will iterate through the board.
    3. If we find a cell with a number, we will check if the number is already present in the row, column or box.
    4. If the number is already present in the row, column or box, we will return false.
    5. If the number is not present in the row, column or box, we will add the number to the row, column and box.
    6. If we don't find any duplicate number, we will return true.
    7. Time complexity is O(1) and space complexity is O(1).
    
     */
    
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
}
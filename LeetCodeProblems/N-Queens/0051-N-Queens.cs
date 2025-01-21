namespace LeetCodeProblems.N_Queens;

public class _0051_N_Queens {
    public IList<IList<string>> SolveNQueens(int n)
    {
        var result = new List<IList<string>>();
        int[] queens = new int[n];
        Array.Fill(queens, -1);
        
        var columns = new HashSet<int>();
        var diagonals1 = new HashSet<int>();
        var diagonals2 = new HashSet<int>();

        void Backtrack(int row)
        {
            if (row == n)
            {
                result.Add(BuildBoard(queens, n));
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (columns.Contains(col) || diagonals1.Contains(row - col) || diagonals2.Contains(row + col))
                    continue;
                
                queens[row] = col;
                columns.Add(col);
                diagonals1.Add(row - col);
                diagonals2.Add(row + col);
                
                Backtrack(row + 1);

                queens[row] = -1;
                columns.Remove(col);
                diagonals1.Remove(row - col);
                diagonals2.Remove(row + col);
            }
        }

        Backtrack(0);
        return result;
    }
    
    private IList<string> BuildBoard(int[] queens, int n)
    {
        var board = new List<string>();
        for (int i = 0; i < n; i++)
        {
            char[] row = Enumerable.Repeat('.', n).ToArray();
            row[queens[i]] = 'Q';
            board.Add(new string(row));
        }
        return board;
    }
    
    }
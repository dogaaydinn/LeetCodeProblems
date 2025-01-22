namespace LeetCodeProblems.N_QueensII;

public class _0052_N_QueensII {
    public int TotalNQueens(int n)
    {
        int count = 0;
        int[] queens = new int[n];
        Array.Fill(queens, -1);
        
        var columns = new HashSet<int>();
        var diagonals1 = new HashSet<int>();
        var diagonals2 = new HashSet<int>();

        void Backtrack(int row)
        {
            if (row == n)
            {
                count++;
                return;
            }

            for (var col = 0; col < n; col++)
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
        return count;
    }
}
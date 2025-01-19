namespace LeetCodeProblems.RotateImage;

public class _0048_RotateImage
{

    /*
        * Problem: 48. Rotate Image
     Intuition:
        - We can solve this problem by transposing the matrix and then reversing each row.
        - To transpose the matrix, we will iterate over the matrix and swap the elements at the current index with the elements at the corresponding index.
        - To reverse each row, we will iterate over the matrix and reverse each row.
        
    Approach:
        - Get the length of the matrix.
        - Transpose the matrix by swapping the elements at the current index with the elements at the corresponding index.
        - Reverse each row of the matrix.
        
    Complexity Analysis:
        - Time Complexity: O(N^2), where N is the length of the matrix.
        - Space Complexity: O(1).
     */
    public void Rotate(int[][] matrix)
    {
        var n = matrix.Length;

        // Transpose the matrix
        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }

        // Reverse each row
        for (var i = 0; i < n; i++)
        {
            Array.Reverse(matrix[i]);
        }
    }
}
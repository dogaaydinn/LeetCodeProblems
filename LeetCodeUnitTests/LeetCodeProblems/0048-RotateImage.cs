using LeetCodeProblems.RotateImage;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class _0048_RotateImage_Tests
{
    [Fact]
    public void Rotate_ShouldRotateMatrixBy90Degrees()
    {
        // Arrange
        var solution = new _0048_RotateImage();
        int[][] matrix = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        int[][] expected = new int[][]
        {
            new int[] { 7, 4, 1 },
            new int[] { 8, 5, 2 },
            new int[] { 9, 6, 3 }
        };

        // Act
        solution.Rotate(matrix);

        // Assert
        for (int i = 0; i < matrix.Length; i++)
        {
            Assert.Equal(expected[i], matrix[i]);
        }
        
        
    }
    
    [Fact]
    public void Rotate_ShouldRotateMatrixBy90Degrees_WhenMatrixIs4x4()
    {
        // Arrange
        var solution = new _0048_RotateImage();
        int[][] matrix = new int[][]
        {
            new int[] { 5, 1, 9, 11 },
            new int[] { 2, 4, 8, 10 },
            new int[] { 13, 3, 6, 7 },
            new int[] { 15, 14, 12, 16 }
        };
        int[][] expected = new int[][]
        {
            new int[] { 15, 13, 2, 5 },
            new int[] { 14, 3, 4, 1 },
            new int[] { 12, 6, 8, 9 },
            new int[] { 16, 7, 10, 11 }
        };

        // Act
        solution.Rotate(matrix);

        // Assert
        for (int i = 0; i < matrix.Length; i++)
        {
            Assert.Equal(expected[i], matrix[i]);
        }
    }
    
    [Fact]
    
    public void Rotate_ShouldRotateMatrixBy90Degrees_WhenMatrixIs3x3()
    {
        // Arrange
        var solution = new _0048_RotateImage();
        int[][] matrix = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        int[][] expected = new int[][]
        {
            new int[] { 7, 4, 1 },
            new int[] { 8, 5, 2 },
            new int[] { 9, 6, 3 }
        };

        // Act
        solution.Rotate(matrix);

        // Assert
        for (int i = 0; i < matrix.Length; i++)
        {
            Assert.Equal(expected[i], matrix[i]);
        }
    }
    
    [Fact]
    
    public void Rotate_ShouldRotateMatrixBy90Degrees_WhenMatrixIs2x2()
    {
        // Arrange
        var solution = new _0048_RotateImage();
        int[][] matrix = new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 3, 4 }
        };
        int[][] expected = new int[][]
        {
            new int[] { 3, 1 },
            new int[] { 4, 2 }
        };

        // Act
        solution.Rotate(matrix);

        // Assert
        for (int i = 0; i < matrix.Length; i++)
        {
            Assert.Equal(expected[i], matrix[i]);
        }
    }
    
    [Fact]
    
    public void Rotate_ShouldRotateMatrixBy90Degrees_WhenMatrixIs1x1()
    {
        // Arrange
        var solution = new _0048_RotateImage();
        int[][] matrix = new int[][]
        {
            new int[] { 1 }
        };
        int[][] expected = new int[][]
        {
            new int[] { 1 }
        };

        // Act
        solution.Rotate(matrix);

        // Assert
        for (int i = 0; i < matrix.Length; i++)
        {
            Assert.Equal(expected[i], matrix[i]);
        }
    }
    
    [Fact]
    
    public void Rotate_ShouldRotateMatrixBy90Degrees_WhenMatrixIs5x5()
    {
        // Arrange
        var solution = new _0048_RotateImage();
        int[][] matrix = new int[][]
        {
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 6, 7, 8, 9, 10 },
            new int[] { 11, 12, 13, 14, 15 },
            new int[] { 16, 17, 18, 19, 20 },
            new int[] { 21, 22, 23, 24, 25 }
        };
        int[][] expected = new int[][]
        {
            new int[] { 21, 16, 11, 6, 1 },
            new int[] { 22, 17, 12, 7, 2 },
            new int[] { 23, 18, 13, 8, 3 },
            new int[] { 24, 19, 14, 9, 4 },
            new int[] { 25, 20, 15, 10, 5 }
        };

        // Act
        solution.Rotate(matrix);

        // Assert
        for (int i = 0; i < matrix.Length; i++)
        {
            Assert.Equal(expected[i], matrix[i]);
        }
    }
    
    [Fact]
    
        
    public void Rotate_ShouldRotateMatrixBy90Degrees_WhenMatrixIs6x6()
    {
        // Arrange
        var solution = new _0048_RotateImage();
        int[][] matrix = new int[][]
        {
            new int[] { 1, 2, 3, 4, 5, 6 },
            new int[] { 7, 8, 9, 10, 11, 12 },
            new int[] { 13, 14, 15, 16, 17, 18 },
            new int[] { 19, 20, 21, 22, 23, 24 },
            new int[] { 25, 26, 27, 28, 29, 30 },
            new int[] { 31, 32, 33, 34, 35, 36 }
        };
        int[][] expected = new int[][]
        {
            new int[] { 31, 25, 19, 13, 7, 1 },
            new int[] { 32, 26, 20, 14, 8, 2 },
            new int[] { 33, 27, 21, 15, 9, 3 },
            new int[] { 34, 28, 22, 16, 10, 4 },
            new int[] { 35, 29, 23, 17, 11, 5 },
            new int[] { 36, 30, 24, 18, 12, 6 }
        };

        // Act
        solution.Rotate(matrix);

        // Assert
        for (int i = 0; i < matrix.Length; i++)
        {
            Assert.Equal(expected[i], matrix[i]);
        }
    }
}
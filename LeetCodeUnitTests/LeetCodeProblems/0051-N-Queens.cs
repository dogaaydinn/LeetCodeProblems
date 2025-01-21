using LeetCodeProblems.N_Queens;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class _0051_N_Queens_Tests
{
    [Fact]
    public void SolveNQueens_ShouldReturnCorrectSolution_ForN4()
    {
        // Arrange
        var solution = new _0051_N_Queens();
        int n = 4;
        var expected = new List<IList<string>>
        {
            new List<string> { ".Q..", "...Q", "Q...", "..Q." },
            new List<string> { "..Q.", "Q...", "...Q", ".Q.." }
        };

        // Act
        var result = solution.SolveNQueens(n);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SolveNQueens_ShouldReturnCorrectSolution_ForN1()
    {
        // Arrange
        var solution = new _0051_N_Queens();
        int n = 1;
        var expected = new List<IList<string>>
        {
            new List<string> { "Q" }
        };

        // Act
        var result = solution.SolveNQueens(n);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SolveNQueens_ShouldReturnEmptyList_ForN2()
    {
        // Arrange
        var solution = new _0051_N_Queens();
        int n = 2;

        // Act
        var result = solution.SolveNQueens(n);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void SolveNQueens_ShouldReturnEmptyList_ForN3()
    {
        // Arrange
        var solution = new _0051_N_Queens();
        int n = 3;

        // Act
        var result = solution.SolveNQueens(n);

        // Assert
        Assert.Empty(result);
    }
    
}
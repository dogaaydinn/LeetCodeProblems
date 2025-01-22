using LeetCodeProblems.N_QueensII;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class _0052_N_QueensIITests
{
    [Fact]
    public void TotalNQueens_WhenNIs1_Returns1()
    {
        var solver = new _0052_N_QueensII();
        int result = solver.TotalNQueens(1);
        Assert.Equal(1, result);
    }

    [Fact]
    public void TotalNQueens_WhenNIs4_Returns2()
    {
        var solver = new _0052_N_QueensII();
        int result = solver.TotalNQueens(4);
        Assert.Equal(2, result);
    }

    [Fact]
    public void TotalNQueens_WhenNIs8_Returns92()
    {
        var solver = new _0052_N_QueensII();
        int result = solver.TotalNQueens(8);
        Assert.Equal(92, result);
    }

    [Fact]
    public void TotalNQueens_WhenNIs9_Returns352()
    {
        var solver = new _0052_N_QueensII();
        int result = solver.TotalNQueens(9);
        Assert.Equal(352, result);
    }
}
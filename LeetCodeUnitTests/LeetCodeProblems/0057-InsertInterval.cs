using Xunit;
using LeetCodeProblems.
namespace LeetCodeTests.LeetCodeProblems;

public class _0057_InsertInterval {
    
    [Fact]
    public void Insert_EmptyInput_ReturnsNewInterval()
    {
        // Arrange
        int[][] intervals = new int[0][];
        int[] newInterval = new int[] {2, 5};
        int[][] expected = new int[][]
        {
            new int[] {2, 5}
        };

        // Act
        var result = _insertInterval.Insert(intervals, newInterval);

        // Assert
        Assert.Equal(expected.Length, result.Length);
        Assert.Equal(expected[0], result[0]);
    }
    
    [Fact]
    public void Insert_IntervalBeforeAll_ReturnsCorrectMerges()
    {
        // Arrange
        int[][] intervals = new int[][]
        {
            new int[] {2, 5},
            new int[] {6, 7},
            new int[] {8, 10}
        };
        int[] newInterval = new int[] {1, 1};
        int[][] expected = new int[][]
        {
            new int[] {1, 1},
            new int[] {2, 5},
            new int[] {6, 7},
            new int[] {8, 10}
        };

        // Act
        var result = _insertInterval.Insert(intervals, newInterval);

        // Assert
        Assert.Equal(expected.Length, result.Length);
        Assert.Equal(expected[0], result[0]);
        Assert.Equal(expected[1], result[1]);
        Assert.Equal(expected[2], result[2]);
        Assert.Equal(expected[3], result[3]);
    }
}
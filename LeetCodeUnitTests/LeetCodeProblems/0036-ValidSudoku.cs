using LeetCodeProblems.ValidSudoku;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class ValidSudokuTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]
        {
            new[]
            {
                new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            },
            true
        };
        yield return new object[]
        {
            new[]
            {
                new[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
                new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            },
            false
        };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void IsValidSudoku_ValidInputs_ReturnsExpectedResult(char[][] board, bool expected)
    {
        // Arrange
        var solution = new _36_ValidSudoku();

        // Act
        var result = solution.IsValidSudoku(board);

        // Assert
        Assert.Equal(expected, result);
    }
}
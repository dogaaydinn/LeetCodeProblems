using LeetCodeProblems.CombinationSumII;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class CombinationSumIiTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]
        {
            new[] { 10, 1, 2, 7, 6, 1, 5 }, 8, new List<IList<int>>
            {
                new List<int> { 1, 1, 6 },
                new List<int> { 1, 2, 5 },
                new List<int> { 1, 7 },
                new List<int> { 2, 6 }
            }
        };
        yield return new object[]
        {
            new[] { 2, 5, 2, 1, 2 }, 5, new List<IList<int>>
            {
                new List<int> { 1, 2, 2 },
                new List<int> { 5 }
            }
        };
        yield return new object[]
        {
            new[] { 1 }, 1, new List<IList<int>>
            {
                new List<int> { 1 }
            }
        };
        yield return new object[]
        {
            new[] { 1, 1, 1, 1 }, 2, new List<IList<int>>
            {
                new List<int> { 1, 1 }
            }
        };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void CombinationSum2_ValidInputs_ReturnsExpectedResult(int[] candidates, int target,
        IList<IList<int>> expected)
    {
        // Arrange
        var solution = new _40_CombinationSumII();

        // Act
        var result = solution.CombinationSum2(candidates, target);

        // Assert
        Assert.Equal(expected.Count, result.Count);

        foreach (var combination in expected) Assert.Contains(result, r => r.SequenceEqual(combination));
    }
}
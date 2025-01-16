using LeetCodeProblems.CombinationSum;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class CombinationSumTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]
        {
            new[] { 2, 3, 6, 7 }, 7, new List<IList<int>>
            {
                new List<int> { 2, 2, 3 },
                new List<int> { 7 }
            }
        };
        yield return new object[]
        {
            new[] { 2, 3, 5 }, 8, new List<IList<int>>
            {
                new List<int> { 2, 2, 2, 2 },
                new List<int> { 2, 3, 3 },
                new List<int> { 3, 5 }
            }
        };
        yield return new object[] { new[] { 2 }, 1, new List<IList<int>>() }; // No combination possible
        yield return new object[]
        {
            new[] { 1 }, 1, new List<IList<int>>
            {
                new List<int> { 1 }
            }
        };
        yield return new object[]
        {
            new[] { 1 }, 2, new List<IList<int>>
            {
                new List<int> { 1, 1 }
            }
        };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void CombinationSum_ValidInputs_ReturnsExpectedResult(int[] candidates, int target,
        IList<IList<int>> expected)
    {
        // Arrange
        var solution = new _39_CombinationSum();

        // Act
        var result = solution.CombinationSum(candidates, target);

        // Assert
        Assert.Equal(expected.Count, result.Count);

        foreach (var combination in expected) Assert.Contains(result, r => r.SequenceEqual(combination));
    }
}
using LeetCodeProblems._4Sum;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class FourSumTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]
        {
            new[] { 1, 0, -1, 0, -2, 2 }, 0, new List<IList<int>>
            {
                new List<int> { -2, -1, 1, 2 },
                new List<int> { -2, 0, 0, 2 },
                new List<int> { -1, 0, 0, 1 }
            }
        };
        yield return new object[]
        {
            new[] { 2, 2, 2, 2, 2 }, 8, new List<IList<int>>
            {
                new List<int> { 2, 2, 2, 2 }
            }
        };
        yield return new object[] { new int[] { }, 0, new List<IList<int>>() }; // Empty array
        yield return new object[]
        {
            new[] { 0, 0, 0, 0 }, 0, new List<IList<int>>
            {
                new List<int> { 0, 0, 0, 0 }
            }
        };
        yield return new object[]
        {
            new[] { -3, -2, -1, 0, 0, 1, 2, 3 }, 0, new List<IList<int>>
            {
                new List<int> { -3, -2, 2, 3 },
                new List<int> { -3, -1, 1, 3 },
                new List<int> { -3, 0, 0, 3 },
                new List<int> { -3, 0, 1, 2 },
                new List<int> { -2, -1, 0, 3 },
                new List<int> { -2, -1, 1, 2 },
                new List<int> { -2, 0, 0, 2 },
                new List<int> { -1, 0, 0, 1 }
            }
        };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void FourSum_ValidInputs_ReturnsExpectedResult(int[] nums, int target, IList<IList<int>> expected)
    {
        // Arrange
        var solution = new _18_4Sum();

        // Act
        var result = solution.FourSum(nums, target);

        // Assert
        Assert.Equal(expected.Count, result.Count);

        foreach (var quadruplet in expected) Assert.Contains(result, r => r.SequenceEqual(quadruplet));
    }
}
using LeetCodeProblems._3Sum;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class ThreeSumTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]
        {
            new[] { -1, 0, 1, 2, -1, -4 },
            new List<IList<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } }
        };
        yield return new object[] { new[] { 0, 0, 0, 0 }, new List<IList<int>> { new List<int> { 0, 0, 0 } } };
        yield return new object[]
        {
            new[] { -2, 0, 1, 1, 2 }, new List<IList<int>> { new List<int> { -2, 0, 2 }, new List<int> { -2, 1, 1 } }
        };
        yield return new object[]
        {
            new[] { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 }, new List<IList<int>>
            {
                new List<int> { -4, -2, 6 },
                new List<int> { -4, 0, 4 },
                new List<int> { -4, 1, 3 },
                new List<int> { -4, 2, 2 },
                new List<int> { -2, -2, 4 },
                new List<int> { -2, 0, 2 }
            }
        };
        yield return new object[] { new[] { 1, 2, -2, -1 }, new List<IList<int>>() };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void ThreeSum_ValidInputs_ReturnsExpectedResult(int[] nums, IList<IList<int>> expected)
    {
        // Arrange
        var solution = new _15_3Sum();

        // Act
        var result = solution.ThreeSum(nums);

        // Assert
        Assert.Equal(expected.Count, result.Count);

        foreach (var triplet in expected) Assert.Contains(result, r => r.SequenceEqual(triplet));
    }
}
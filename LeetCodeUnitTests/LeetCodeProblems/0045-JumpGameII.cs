using Xunit;
using LeetCodeProblems.JumpGameII;

namespace LeetCodeTests.LeetCodeProblems;

public class JumpGameIiTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new[] { 2, 3, 1, 1, 4 }, 2 };
        yield return new object[] { new[] { 2, 3, 0, 1, 4 }, 2 };
        yield return new object[] { new[] { 1, 1, 1, 1 }, 3 };
        yield return new object[] { new[] { 1, 2, 3 }, 2 };
        yield return new object[] { new[] { 1, 2 }, 1 };
        yield return new object[] { new[] { 1 }, 0 };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Jump_ValidInputs_ReturnsExpectedResult(int[] nums, int expected)
    {
        // Arrange
        var solution = new _45_JumpGameII();

        // Act
        var result = solution.Jump(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
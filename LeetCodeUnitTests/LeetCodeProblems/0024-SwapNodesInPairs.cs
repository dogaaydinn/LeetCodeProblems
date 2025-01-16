using LeetCodeProblems.SwapNodesInPairs;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class SwapNodesInPairsTests
{
    [Fact]
    public void SwapPairs_ValidInput_SwapsCorrectly()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        var expected = new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(3))));
        var solution = new _24_SwapNodesInPairs();

        // Act
        var result = solution.SwapPairs(head);

        // Assert
        while (expected != null && result != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }

        Assert.Null(expected);
        Assert.Null(result);
    }
}
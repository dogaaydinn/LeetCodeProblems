using LeetCodeProblems.MergeKSortedLists;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class MergeKSortedListsTests
{
    [Fact]
    public void MergeKLists_ValidInputs_ReturnsExpectedResult()
    {
        // Arrange
        var solution = new Solution();
        var list1 = new ListNode(1, new ListNode(4, new ListNode(5)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var list3 = new ListNode(2, new ListNode(6));
        var lists = new[] { list1, list2, list3 };

        // Act
        var result = solution.MergeKLists(lists);

        // Assert
        var expectedValues = new[] { 1, 1, 2, 3, 4, 4, 5, 6 };
        foreach (var val in expectedValues)
        {
            Assert.NotNull(result);
            Assert.Equal(val, result.val);
            result = result.next;
        }

        Assert.Null(result);
    }
}
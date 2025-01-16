using LeetCodeProblems.MergeTwoSortedLists;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class MergeTwoSortedListsTests
{
    [Fact]
    public void MergeTwoLists_ValidInput_MergesTwoLists()
    {
        // Arrange
        var solution = new _21_MergeTwoSortedLists();
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new global::LeetCodeProblems.MergeTwoSortedLists.ListNode(1,
            new global::LeetCodeProblems.MergeTwoSortedLists.ListNode(3,
                new global::LeetCodeProblems.MergeTwoSortedLists.ListNode(4)));
        var expected = new ListNode(1,
            new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

        // Act
        var result = solution.MergeTwoLists(l1, l2);

        // Assert
        Assert.Equal(l1, new ListNode(1, new ListNode(2, new ListNode(4))));
    }

    [Fact]
    public void MergeTwoLists_EmptyList_ReturnsOtherList()
    {
        // Arrange
        var solution = new _21_MergeTwoSortedLists();
        var l1 = new ListNode();
        var l2 = new global::LeetCodeProblems.MergeTwoSortedLists.ListNode();
        var expected = new ListNode();

        // Act
        var result = solution.MergeTwoLists(l1, l2);

        // Assert
        Assert.Equal(l1, new ListNode());
    }

    [Fact]
    public void MergeTwoLists_OneEmptyList_ReturnsOtherList()
    {
        // Arrange
        var solution = new _21_MergeTwoSortedLists();
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new ListNode();
        var expected = new ListNode(1, new ListNode(2, new ListNode(4)));

        // Act
        var result = solution.MergeTwoLists(l1, l2);

        // Assert
        Assert.Equal(expected, result);
    }
}
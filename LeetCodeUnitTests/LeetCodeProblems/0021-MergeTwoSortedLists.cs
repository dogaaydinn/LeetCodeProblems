using LeetCodeProblems.MergeTwoSortedLists;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class MergeTwoSortedListsTests
{
    [Fact]
    public void MergeTwoLists_WhenCalled_ReturnsMergedLists()
    {
        // Arrange
        var list1 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(2, new MergeTwoSortedLists.ListNode(4)));
        var list2 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(3, new MergeTwoSortedLists.ListNode(4)));
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(1, result.next.val);
        Assert.Equal(2, result.next.next.val);
        Assert.Equal(3, result.next.next.next.val);
        Assert.Equal(4, result.next.next.next.next.val);
        Assert.Equal(4, result.next.next.next.next.next.val);
        Assert.Null(result.next.next.next.next.next.next);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithNullLists_ReturnsNull()
    {
        // Arrange
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(null, null);

        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithNullList1_ReturnsList2()
    {
        // Arrange
        var list2 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(3, new MergeTwoSortedLists.ListNode(4)));
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(null, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(3, result.next.val);
        Assert.Equal(4, result.next.next.val);
        Assert.Null(result.next.next.next);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithNullList2_ReturnsList1()
    {
        // Arrange
        var list1 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(2, new MergeTwoSortedLists.ListNode(4)));
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, null);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Equal(4, result.next.next.val);
        Assert.Null(result.next.next.next);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithEmptyLists_ReturnsNull()
    {
        // Arrange
        var list1 = new MergeTwoSortedLists.ListNode();
        var list2 = new MergeTwoSortedLists.ListNode();
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithEmptyList1_ReturnsList2()
    {
        // Arrange
        var list2 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(3, new MergeTwoSortedLists.ListNode(4)));
        var list1 = new MergeTwoSortedLists.ListNode();
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(3, result.next.val);
        Assert.Equal(4, result.next.next.val);
        Assert.Null(result.next.next.next);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithEmptyList2_ReturnsList1()
    {
        // Arrange
        var list1 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(2, new MergeTwoSortedLists.ListNode(4)));
        var list2 = new MergeTwoSortedLists.ListNode();
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Equal(4, result.next.next.val);
        Assert.Null(result.next.next.next);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithOneElementLists_ReturnsMergedLists()
    {
        // Arrange
        var list1 = new MergeTwoSortedLists.ListNode(1);
        var list2 = new MergeTwoSortedLists.ListNode(2);
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Null(result.next.next);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithOneEmptyList_ReturnsNonEmptyList()
    {
        // Arrange
        var list1 = new MergeTwoSortedLists.ListNode();
        var list2 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(2));
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Null(result.next.next);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithOneNullList_ReturnsNonEmptyList()
    {
        // Arrange
        var list1 = new MergeTwoSortedLists.ListNode(1, new MergeTwoSortedLists.ListNode(2));
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, null);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Null(result.next.next);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithTwoNullLists_ReturnsNull()
    {
        // Arrange
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(null, null);

        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithTwoEmptyLists_ReturnsNull()
    {
        // Arrange
        var list1 = new MergeTwoSortedLists.ListNode();
        var list2 = new MergeTwoSortedLists.ListNode();
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    
    public void MergeTwoLists_WhenCalledWithTwoOneElementLists_ReturnsMergedLists()
    {
        // Arrange
        var list1 = new MergeTwoSortedLists.ListNode(1);
        var list2 = new MergeTwoSortedLists.ListNode(2);
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Null(result.next.next);
    }
    
    [Fact]
    public void MergeTwoLists_WhenCalledWithTwoOneEmptyLists_ReturnsNonEmptyList()
    {
        // Arrange
        var list1 = new MergeTwoSortedLists.ListNode();
        var list2 = new MergeTwoSortedLists.ListNode(1);
        var solution = new MergeTwoSortedLists.Solution();

        // Act
        var result = solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Null(result.next);
    }
    
    
}
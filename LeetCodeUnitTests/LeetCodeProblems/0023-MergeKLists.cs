using LeetCodeProblems.MergeKSortedLists;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class MergeKSortedListsTests
{
    [Fact]
    public void MergeKLists_ValidInputs_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var list2 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(3, new MergeKSortedLists.ListNode(4)));
        var list3 = new MergeKSortedLists.ListNode(2, new MergeKSortedLists.ListNode(6));
        var lists = new[] { list1, list2, list3 };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(2, new MergeKSortedLists.ListNode(3, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5, new MergeKSortedLists.ListNode(6))))))));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_EmptyList_ReturnsNull()
    {
        // Arrange
        var lists = new MergeKSortedLists.ListNode[0];

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public void MergeKLists_NullList_ReturnsNull()
    {
        // Arrange
        MergeKSortedLists.ListNode[] lists = null;

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public void MergeKLists_OneList_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { list1 };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_OneListWithNull_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { list1, null };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_OneListWithNullAtEnd_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { null, list1 };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_OneListWithNullAtStart_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { null, list1 };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_OneListWithNullAtStartAndEnd_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { null, list1, null };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_OneListWithNullAtStartAndEndAndMiddle_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { null, list1, null, null };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_OneListWithNullAtStartAndEndAndMiddleAndEnd_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { null, list1, null, null, null };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_OneListWithNullAtStartAndEndAndMiddleAndEndAndStart_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { null, list1, null, null, null, null };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_OneListWithNullAtStartAndEndAndMiddleAndEndAndStartAndMiddle_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { null, list1, null, null, null, null, null };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_OneListWithNullAtStartAndEndAndMiddleAndEndAndStartAndMiddleAndEnd_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { null, list1, null, null, null, null, null, null };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
    
    [Fact]
    public void MergeKLists_OneListWithNullAtStartAndEndAndMiddleAndEndAndStartAndMiddleAndEndAndStart_ReturnsExpectedResult()
    {
        // Arrange
        var list1 = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));
        var lists = new[] { null, list1, null, null, null, null, null, null, null };
        var expected = new MergeKSortedLists.ListNode(1, new MergeKSortedLists.ListNode(4, new MergeKSortedLists.ListNode(5)));

        // Act
        var solution = new MergeKSortedLists.Solution();
        var result = solution.MergeKLists(lists);

        // Assert
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }
}
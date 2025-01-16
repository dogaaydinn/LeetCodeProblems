using LeetCodeProblems.ReverseNodesInKGroup;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class ReverseNodesInKGroupTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 2, 1, 4, 3, 5 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 3, 2, 1, 4, 5 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 1 }, 1, new[] { 1 })]
    public void ReverseKGroup_ValidInputs_ReturnsExpectedResult(int[] input, int k, int[] expected)
    {
        // Arrange
        var head = CreateLinkedList(input);
        var solution = new _25_ReverseNodesInKGroup();

        // Act
        var result = solution.ReverseKGroup(head, k);

        // Assert
        var resultArray = LinkedListToArray(result);
        Assert.Equal(expected, resultArray);
    }

    private ListNode? CreateLinkedList(int[] values)
    {
        if (values.Length == 0) return null;
        var head = new ListNode(values[0]);
        var current = head;
        for (var i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }

    private int[] LinkedListToArray(ListNode? head)
    {
        var list = new List<int>();
        var current = head;
        while (current != null)
        {
            list.Add(current.val);
            current = current.next;
        }

        return list.ToArray();
    }
}
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class RemoveNthNodeFromEndListTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 2, 3, 5 })]
    [InlineData(new[] { 1 }, 1, new int[] { })]
    [InlineData(new[] { 1, 2 }, 1, new[] { 1 })]
    public void RemoveNthFromEnd_ValidInputs_ReturnsExpectedResult(int[] input, int n, int[] expected)
    {
        // Arrange
        var head = CreateLinkedList(input);
        var solution = new _19_RemoveNthNodeFromEndList();

        // Act
        var result = solution.RemoveNthFromEnd(head, n);

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
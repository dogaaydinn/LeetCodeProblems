public class ListNode
{
    public ListNode? next;
    public int val;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

/*
    Problem:
    Given the head of a linked list, remove the nth node from the end of the list and return its head.

    Approach:
    1. Create a dummy node.
    2. Create two pointers, first and second, and point them to the dummy node.
    3. Move the first pointer n+1 steps ahead.
    4. Move both pointers until the first pointer reaches the end.
    5. Remove the nth node from the end.

    Time complexity: O(n), where n is the length of the linked list.
    Space complexity: O(1)
 */
public class _19_RemoveNthNodeFromEndList
{
    public ListNode? RemoveNthFromEnd(ListNode? head, int n)
    {
        var dummy = new ListNode(0, head);
        var first = dummy;
        var second = dummy;

        // Move first pointer n+1 steps ahead
        for (var i = 0; i <= n; i++) first = first.next;

        // Move both pointers until first reaches the end
        while (first != null)
        {
            first = first.next;
            second = second.next;
        }

        // Remove the nth node from the end
        second.next = second.next.next;

        return dummy.next;
    }
}
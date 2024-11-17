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
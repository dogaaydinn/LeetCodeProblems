namespace LeetCodeProblems.SwapNodesInPairs;

public class _24_SwapNodesInPairs
{
    public ListNode? SwapPairs(ListNode? head)
    {
        if (head?.next == null)
            return head;

        var dummy = new ListNode();
        dummy.next = head;
        var prev = dummy;

        while (prev.next != null && prev.next.next != null)
        {
            var first = prev.next;
            var second = first.next;

            prev.next = second;
            first.next = second.next;
            second.next = first;


            prev = first;
        }

        return dummy.next;
    }
}
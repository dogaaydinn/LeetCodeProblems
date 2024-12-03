namespace LeetCodeProblems.ReverseNodesInKGroup;

public class _25_ReverseNodesInKGroup
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (k == 1) return head;

        var dummy = new ListNode(0, head);
        var groupPrev = dummy;

        while (true)
        {
            var kth = groupPrev;
            for (var i = 0; i < k && kth != null; i++) kth = kth.next;
            if (kth == null) break;

            var groupNext = kth.next;
            ListNode prev = groupNext, curr = groupPrev.next;

            while (curr != groupNext)
            {
                var temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            var tempHead = groupPrev.next;
            groupPrev.next = kth;
            groupPrev = tempHead;
        }

        return dummy.next;
    }
}
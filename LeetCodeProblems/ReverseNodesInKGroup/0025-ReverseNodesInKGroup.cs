namespace LeetCodeProblems.ReverseNodesInKGroup;

public class _25_ReverseNodesInKGroup
{
    /*
     Problem: 25. Reverse Nodes in k-Group

        Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.
        k is a positive integer and is less than or equal to the length of the linked list. If the number of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.
        You may not alter the values in the list's nodes, only nodes themselves may be changed.

        Approach:
            1. Create a dummy node and set its next to the head.
            2. Create a groupPrev node and set it to the dummy node.
            3. Iterate while true.
            4. Create a kth node and set it to groupPrev.
            5. Iterate k times and set kth to kth.next.
            6. If kth is null, break.
            7. Create a groupNext node and set it to kth.next.
            8. Create a prev node and set it to groupNext, and a curr node and set it to groupPrev.next.
            9. Iterate while curr is not equal to groupNext.
            10. Create a temp node and set it to curr.next.
            11. Reverse the links between prev and curr.
            12. Set prev to curr, curr to temp.
            13. Set groupPrev.next to kth.
            14. Set groupPrev to tempHead.
            15. Return dummy.next.

            Time complexity: O(n), where n is the number of nodes in the linked list.
            Space complexity: O(1).
     */
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
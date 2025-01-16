namespace LeetCodeProblems.SwapNodesInPairs;

public class _24_SwapNodesInPairs
{
    /*
     Given a linked list, swap every two adjacent nodes and return its head.
        You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

        Approach:
        1. Create a dummy node.
        2. Create a prev node and point it to the dummy node.
        3. Iterate while prev.next and prev.next.next are not null.
        4. Create two nodes, first and second, and point them to prev.next and prev.next.next.
        5. Swap the nodes.
        6. Move prev to the first node.
        7. Return the dummy node's next node.

        Time complexity: O(n), where n is the length of the linked list.
        Space complexity: O(1)
     */
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
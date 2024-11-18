namespace LeetCodeProblems.ReverseNodesInKGroup;

public class _25_ReverseNodesInKGroup {
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (k == 1) return head;
        
        ListNode dummy = new ListNode(0, head);
        ListNode groupPrev = dummy;

        while (true) {
            ListNode kth = groupPrev;
            for (var i = 0; i < k && kth != null; i++) {
                kth = kth.next;
            }
            if (kth == null) break; 
            
            ListNode groupNext = kth.next;
            ListNode prev = groupNext, curr = groupPrev.next;

            while (curr != groupNext) {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            
            ListNode tempHead = groupPrev.next;
            groupPrev.next = kth;
            groupPrev = tempHead;
        }

        return dummy.next;
    }
}
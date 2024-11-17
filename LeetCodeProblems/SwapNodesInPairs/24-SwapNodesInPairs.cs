namespace LeetCodeProblems.SwapNodesInPairs;

public class _24_SwapNodesInPairs {
    public ListNode? SwapPairs(ListNode? head) {
        if (head?.next == null)
            return head; 
    
        ListNode? dummy = new ListNode(0); 
        dummy.next = head;
        ListNode? prev = dummy;
    
        while (prev.next != null && prev.next.next != null) {

            ListNode? first = prev.next;
            ListNode? second = first.next;
        
            prev.next = second;
            first.next = second.next;
            second.next = first;
        

            prev = first;
        }
    
        return dummy.next;
    }
}

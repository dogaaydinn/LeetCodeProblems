namespace LeetCodeProblems.AddTwoNumbers;

public class AddTwoNumbers
{
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
         this.next = next;
      }
  }

    public ListNode AddTwoNumbersSolution(ListNode l1, ListNode l2) {
        
        ListNode current = new ListNode(0);
        ListNode head = current;
        int value = 0;

        while (l1 != null || l2 != null || value != 0)
        {
            var sum1 = l1?.val ?? 0;
            var sum2 = l2?.val ?? 0;
            
            var sum = sum1 + sum2 + value;
            
            value = sum / 10;
            current.val = sum % 10;
            
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;


            if (l1 != null || l2 != null || value != 0)
            {
                current.next = new ListNode(0);
                current = current.next;
            }
        }
        
        return head;
    }
}
namespace LeetCodeProblems.AddTwoNumbers;

public abstract class _002_AddTwoNumbers
{
  public class ListNode {
      public int Val;
      public ListNode? Next;
      public ListNode(int val=0, ListNode? next=null) {
            Val = val;
            Next = next;
      }
  }

    public static ListNode? AddTwoNumbersSolution(ListNode? l1, ListNode? l2) {
        
        var current = new ListNode(0);
        var head = current;
        var value = 0;

        while (l1 != null || l2 != null || value != 0)
        {
            var sum1 = l1?.Val ?? 0;
            var sum2 = l2?.Val ?? 0;
            
            var sum = sum1 + sum2 + value;
            
            value = sum / 10;
            current.Val = sum % 10;

            l1 = l1?.Next;
            l2 = l2?.Next;


            if (l1 == null && l2 == null && value == 0) continue;
            current.Next = new ListNode(0);
            current = current.Next;
        }
        
        return head;
    }
}
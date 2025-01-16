namespace LeetCodeProblems.AddTwoNumbers;

public abstract class _002_AddTwoNumbers
{
    /*
    You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
    You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    Approach:
    1. Initialize current and head as a new ListNode.
    2. Initialize value as 0.
    3. Iterate while l1 is not null or l2 is not null or value is not 0.
    4. Calculate sum1 as l1?.Val or 0.
    5. Calculate sum2 as l2?.Val or 0.
    6. Calculate sum as sum1 + sum2 + value.
    7. Update value as sum / 10.
    8. Update current.Val as sum % 10.
    9. Update l1 as l1?.Next.
    10. Update l2 as l2?.Next.
    11. If l1 is null and l2 is null and value is 0, continue.
    12. Update current.Next as a new ListNode.
    13. Update current as current.Next.
    14. Return head.

    Complexity Analysis:
    Time Complexity: O(max(m, n)), where m and n are the lengths of l1 and l2.
    Space Complexity: O(max(m, n)), where m and n are the lengths of l1 and l2.
     */
    public static ListNode? AddTwoNumbersSolution(ListNode? l1, ListNode? l2)
    {
        var current = new ListNode();
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
            current.Next = new ListNode();
            current = current.Next;
        }

        return head;
    }

    public class ListNode
    {
        public ListNode? Next;
        public int Val;

        public ListNode(int val = 0, ListNode? next = null)
        {
            Val = val;
            Next = next;
        }
    }
}
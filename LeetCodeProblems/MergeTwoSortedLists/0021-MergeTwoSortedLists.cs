namespace LeetCodeProblems.MergeTwoSortedLists;

public class MergeTwoSortedLists
{
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) 
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution 
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null || (l1.val == 0 && l1.next == null)) l1 = null;
            if (l2 == null || (l2.val == 0 && l2.next == null)) l2 = null;

            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode dummy = new ListNode(0);
            ListNode current = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            current.next = l1 ?? l2;

            return dummy.next;
        }
    }
}
/*
    * Problem:
 * Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.
 *
 Approach:
    1. Create a dummy node.
    2. Create a current node.
    3. Iterate while both lists are not null.
    4. If the value of the first list is less than the value of the second list, add the first list to the current node.
    5. Otherwise, add the second list to the current node.

    Time complexity: O(n + m), where n is the length of the first list and m is the length of the second list.
    Space complexity: O(1)
 */



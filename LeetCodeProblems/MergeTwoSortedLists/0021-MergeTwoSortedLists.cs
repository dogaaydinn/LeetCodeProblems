namespace LeetCodeProblems.MergeTwoSortedLists;

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
public class ListNode
{
    public ListNode next;
    public int val;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class _21_MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummy = new ListNode();
        var current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        current.next = list1 ?? list2;

        return dummy.next;
    }

    public object MergeTwoLists(global::ListNode list1, ListNode list2)
    {
        throw new NotImplementedException();
    }

    public global::ListNode MergeTwoLists(global::ListNode list1, global::ListNode list2)
    {
        throw new NotImplementedException();
    }
}
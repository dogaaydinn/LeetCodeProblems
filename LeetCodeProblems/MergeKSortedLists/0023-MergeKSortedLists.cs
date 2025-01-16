namespace LeetCodeProblems.MergeKSortedLists;

public class Solution
{
    /*
     Given an array of linked-lists lists, each linked list is sorted in ascending order.
     Merge all the linked-lists into one sorted linked-list and return it.

        Approach:
        1. Create a SortedSet heap.
        2. Add the first node of each linked list to the heap.
        3. Create a dummy node and a current node.
        4. Iterate while the heap is not empty.
        5. Get the smallest node from the heap.
        6. Add the node to the current node.
        7. Add the next node of the smallest node to the heap.
        8. Return the dummy node's next node.

        Time complexity: O(n * m * log(m)), where n is the number of linked lists and m is the average length of the linked lists.
        Space complexity: O(m), where m is the average length of the linked lists.
     */
    public ListNode? MergeKLists(ListNode[] lists)
    {
        var heap = new SortedSet<(int val, int listIndex, ListNode? node)>();

        for (var i = 0; i < lists.Length; i++) heap.Add((lists[i].val, i, lists[i]));

        var dummy = new ListNode();
        var current = dummy;

        while (heap.Count > 0)
        {
            var smallest = heap.Min;
            heap.Remove(smallest);

            current.next = smallest.node;
            current = current.next;

            heap.Add((smallest.node.next.val, smallest.listIndex, smallest.node.next));
        }

        return dummy.next;
    }
}


public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {

        var heap = new SortedSet<(int val, int listIndex, ListNode node)>();
        
        for (var i = 0; i < lists.Length; i++)
        {
            heap.Add((lists[i].val, i, lists[i]));
        }
        
        var dummy = new ListNode();
        var current = dummy;
        
        while (heap.Count > 0) {
            var smallest = heap.Min;
            heap.Remove(smallest);
            
            current.next = smallest.node;
            current = current.next;

            heap.Add((smallest.node.next.val, smallest.listIndex, smallest.node.next));
        }
        
        return dummy.next;
    }
}
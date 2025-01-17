namespace LeetCodeProblems.MergeKSortedLists;

public class MergeKSortedLists
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
        public ListNode MergeKLists(ListNode[] lists) 
        {
            if (lists == null || lists.Length == 0)
                return null;
            
            // Initialize the priority queue.
            // The key (priority) is the node's value.
            var pq = new PriorityQueue<ListNode, int>();

            // Enqueue the head of each non-null list.
            foreach (var node in lists)
            {
                if (node != null)
                    pq.Enqueue(node, node.val);
            }
            
            // Dummy head helps simplify list operations.
            ListNode dummy = new ListNode(0);
            ListNode tail = dummy;
            
            // Extract nodes one by one in increasing order.
            while (pq.Count > 0)
            {
                // Remove the node with the smallest value.
                var smallestNode = pq.Dequeue();
                tail.next = smallestNode;
                tail = tail.next;
                
                // If there is a next node, enqueue it.
                if (smallestNode.next != null)
                {
                    pq.Enqueue(smallestNode.next, smallestNode.next.val);
                }
            }
            
            return dummy.next;
        }
    }
}
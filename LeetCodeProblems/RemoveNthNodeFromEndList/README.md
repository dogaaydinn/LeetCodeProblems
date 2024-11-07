# RemoveNthFromEnd

## Problem Description

The `RemoveNthFromEnd` function removes the \(n\)-th node from the end of a singly linked list in a single pass through
the list.

## Approach

This problem is efficiently solved using the two-pointer technique. By maintaining a gap of \(n\) nodes between two
pointers, we can ensure that when the `first` pointer reaches the end, the `second` pointer is positioned just before
the target node to be removed.

## Solution Steps

1. **Create a Dummy Node**: Adding a `dummy` node at the start simplifies handling edge cases, such as removing the head
   node.
2. **Initialize Pointers**: Set both `first` and `second` pointers to the `dummy` node.
3. **Advance the First Pointer**: Move the `first` pointer \(n+1\) steps forward to create a gap of \(n\) nodes between
   `first` and `second`.
4. **Move Both Pointers Together**: Advance both pointers until `first` reaches the end of the list. At this point,
   `second` is just before the target node.
5. **Remove the Target Node**: Update `second.next` to skip the target node.
6. **Return the Updated List**: Return `dummy.next`, which points to the updated list's head.

## Code

```csharp
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(0, head);
        ListNode first = dummy;
        ListNode second = dummy;

        for (int i = 0; i <= n; i++) {
            first = first.next;
        }

        while (first != null) {
            first = first.next;
            second = second.next;
        }

        second.next = second.next.next;

        return dummy.next;
    }
}

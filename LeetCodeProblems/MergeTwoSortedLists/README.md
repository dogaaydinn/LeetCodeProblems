# Merge Two Sorted Lists

## Problem Description

You are given the heads of two sorted linked lists `list1` and `list2`.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

### Examples

#### Example 1
- **Input:** `list1 = [1,2,4]`, `list2 = [1,3,4]`
- **Output:** `[1,1,2,3,4,4]`

#### Example 2
- **Input:** `list1 = []`, `list2 = []`
- **Output:** `[]`

#### Example 3
- **Input:** `list1 = []`, `list2 = [0]`
- **Output:** `[0]`

### Constraints
- The number of nodes in both lists is in the range `[0, 50]`.
- `-100 <= Node.val <= 100`
- Both `list1` and `list2` are sorted in non-decreasing order.

## Solution

To solve the problem of merging two sorted linked lists, we can use a dummy node to simplify the merging process. We will iterate through both lists, comparing the current nodes and appending the smaller one to the merged list. Once we reach the end of one list, we append the remaining nodes of the other list.

### Approach
1. Create a dummy node to act as the starting point of the merged list.
2. Use a pointer `current` to keep track of the last node in the merged list.
3. Iterate through both lists:
   - Compare the current nodes of `list1` and `list2`.
   - Append the smaller node to the merged list and move the pointer of that list to the next node.
4. Once one of the lists is exhausted, append the remaining nodes of the other list to the merged list.
5. Return the next node of the dummy node, which is the head of the merged list.

### Complexity
- **Time complexity:** \(O(n + m)\), where \(n\) and \(m\) are the lengths of `list1` and `list2`, respectively. We process each node exactly once.
- **Space complexity:** \(O(1)\), as we only use a few extra pointers.

### Implementation

```csharp
namespace LeetCodeProblems.MergeTwoSortedLists;

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
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

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
}
```
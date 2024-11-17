## Problem Description
Given a singly linked list, swap every two adjacent nodes and return its head.
You must solve the problem without modifying the values in the list nodes (i.e., only nodes themselves may be changed).

## Solution Approaches
1. Iterative Solution
The iterative approach uses a dummy node to simplify swapping nodes at the head of the list. It maintains a pointer prev to manage swapping pairs.

### Steps:
1. Create a dummy node pointing to the head.
2.Iterate through the list while there are at least two nodes remaining.
- For each pair:
3. Identify the two nodes to be swapped.
4. Update pointers to perform the swap.
5.Return the new head starting from dummy.next.

- Complexity Analysis
Iterative Solution
-Time Complexity: O(N) (each node is visited once).
Space Complexity: O(1) (only pointers are used).
### Recursive Solution

-Time Complexity: O(N) (each node is visited once).

-Space Complexity: O(N) (stack space for recursion).

Intuition
=========

We aim to reverse Every K Nodes in the Linked List. IF the number of nodes left is less chen k, those nodes remain as
they are. The keys of the nodes of the nodes of the nodes of k where maintain the overall Structure.

Approach
========

1. Dummy node:

The Dummy knot makes it easier to follow the head of the list. Thus, it is easier to update the connections when turning
the beginning of the list upside down.

1. Finding K-Thh Node:

We find the last node of the current group (KTH) by moving up to K with the cycle.

If Kth == Null, the remaining nodes means less than K. In this case, the process ends.

1. Reversing:

We turn the group's nodes upside down as Prev, Curr, and Next and in-place.

1. Update links:

We set the start of the upside -down group (Groupprev.next) and the end.

1. Management with a single cycle:

To check the remaining nodes and turn the group upside down, we handle all operations in a single method.

Complexity
==========

- Time complexity:\
  𝑂(𝑛), each knot is visited at most twice (to find the group once, to reversed once).

- Space complexity:\
  𝑂(1), an extra data structure is not used.

### Explanation

1. **Dummy Node**:

    - A dummy node simplifies handling the head of the list when reversing the first group.
2. **Group Reversal**:

    - Reverse the group using a simple while loop. The pointers are updated to reverse links without extra space.
3. **Edge Cases**:

    - If fewer than `k` nodes remain, the process stops, leaving the remaining nodes as they are.

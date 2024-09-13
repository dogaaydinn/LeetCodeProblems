# 🧮 Add Two Numbers - Linked List Solution

This repository provides a solution to the "Add Two Numbers" problem using linked lists. The implementation efficiently handles the addition of two numbers represented by linked lists with digits stored in reverse order.

## Problem Description

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, where each node contains a single digit. Your task is to add the two numbers and return the sum as a linked list.

### Problem Statement

- **Difficulty**: Medium
- **Topics**: Linked List, Arithmetic
- **Companies**: Google, Microsoft

### Example

**Input**:
- `l1 = [2,4,3]`
- `l2 = [5,6,4]`

**Output**:
- `[7,0,8]`

**Explanation**:  
342 + 465 = 807. The result is represented as `[7,0,8]` in reverse order.

**Input**:
- `l1 = [0]`
- `l2 = [0]`

**Output**:
- `[0]`

**Input**:
- `l1 = [9,9,9,9,9,9,9]`
- `l2 = [9,9,9,9]`

**Output**:
- `[8,9,9,9,0,0,0,1]`

### Constraints

- The number of nodes in each linked list is in the range `[1, 100]`.
- `0 <= Node.val <= 9`
- It is guaranteed that the list represents a number that does not have leading zeros.

## Approach

1. **Initialize**: Start with a dummy node to build the result linked list and a variable to keep track of the carry.
2. **Iterate through Lists**: Traverse both linked lists simultaneously, adding corresponding digits and considering any carry from the previous digit.
3. **Handle Carry**: Update the carry and the current node value based on the sum of digits and carry.
4. **Construct Result**: Append new nodes to the result list as needed until all nodes in both input lists are processed and any remaining carry is handled.

## Complexity Analysis

- **Time Complexity**: `O(max(m, n))`  
  Where `m` and `n` are the lengths of the two linked lists. We traverse both lists once.

- **Space Complexity**: `O(max(m, n))`  
  The space complexity is proportional to the length of the resulting linked list, which can be at most `max(m, n) + 1` nodes long due to potential carry.

## Explanation of the Code

The solution uses a dummy node to simplify list manipulations and a while loop to process digits from both linked lists. It efficiently handles cases where the lengths of the linked lists are different and manages the carry properly.
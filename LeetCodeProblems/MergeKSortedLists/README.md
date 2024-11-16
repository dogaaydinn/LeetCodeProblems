# Merge k Sorted Lists

## Problem Description

You are given an array of `k` sorted linked lists, where each linked list is sorted in ascending order. Your task is to merge all the linked lists into one sorted linked list and return it.

### Example 1:
	**Input:**
			```plaintext
		lists = [[1,4,5], [1,3,4], [2,6]]

### Approach
We solve this problem using a Min-Heap (or Priority Queue). The algorithm works as follows:

Heap Initialization: Insert the head of each linked list into a min-heap.
Heap Operations: At each step, extract the smallest element from the heap, append it to the merged list, and insert the next element from the corresponding list into the heap.
Continue until the heap is empty.
This ensures that the smallest element from all lists is always selected, leading to a merged sorted list.

Time Complexity
Heap Operations: Each insert and delete operation on the heap takes 
O(logk) time, where k is the number of linked lists.
We process each node exactly once, so the total time complexity is 
O(nlogk), where n is the total number of nodes across all lists.
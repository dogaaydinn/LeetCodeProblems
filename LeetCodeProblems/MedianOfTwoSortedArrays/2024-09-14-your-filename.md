# 📈 Median of Two Sorted Arrays - Binary Search Approach

This repository contains an efficient solution to the "Median of Two Sorted Arrays" problem using Binary Search to achieve `O(log(min(m,n)))` time complexity.

## Problem Description

We are given two sorted arrays, and the task is to find the median without merging the arrays. Merging would result in an `O(m+n)` time complexity, which is inefficient for large datasets.

### Median of Two Sorted Arrays

**Difficulty**: Hard

**Problem Statement**: Given two sorted arrays `nums1` and `nums2`, find the median without merging them.

## Approach

### Initial Thoughts

Binary search is used to find the correct partition without merging arrays.

### Explanation

By using binary search on the smaller array, we split both arrays into two halves, ensuring the elements in the left half are smaller than those in the right half. This partition allows us to calculate the median.

### Edge Cases

- Empty arrays.
- Arrays of unequal lengths.

## Complexity Analysis

- **Time Complexity**: `O(log(min(m,n)))`
- **Space Complexity**: `O(1)`

## Why Not Merge the Arrays?

Merging two sorted arrays would result in a complexity of `O(m+n)` because we are combining both arrays into one large array before finding the median. However, the problem asks for an optimized solution with a time complexity of `O(log(m+n))`.

## Merge Sort Complexity

Merge sort has a complexity of `O(n log n)` due to repeated partitioning (logarithmic) and merging (linear). The merge operation alone is linear, which would be expensive for this problem.

## Optimized Solution Using Binary Search

We can avoid merging by using binary search to directly find the median of the two arrays. The idea is to partition the arrays in such a way that the left partition contains the same number of elements as the right partition. We can then compare the elements in these partitions to find the median.

### Key Points

- **Partitioning**: We divide both arrays into two parts, ensuring the left and right halves contain an equal number of elements. This allows us to find the median without merging.
- **Binary Search**: We apply binary search to the smaller array, adjusting the partition until the conditions for the median are met.

### Median Finding Criteria

- If the maximum element on the left side of the partition is less than or equal to the minimum element on the right side, we have found the correct partition.
- If not, we adjust the partition by modifying the binary search range.

## Explanation of the Code

- **Input**: Two sorted arrays `nums1` and `nums2`.
- **Goal**: Find the median of the two arrays without merging them.
- **Binary Search**: The binary search is applied to the smaller array to find the correct partition.
- **Edge Cases**: Edge cases such as empty arrays or arrays of different sizes are handled by setting `left1`, `right1`, `left2`, and `right2` appropriately.

### Example

Given the two arrays:

```plaintext
nums1 = [1, 3]
nums2 = [2]

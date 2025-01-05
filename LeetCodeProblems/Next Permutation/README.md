
Problem Description
-------------------

**LeetCode Problem 31: Next Permutation**

A **permutation** of an array of integers is an arrangement of its members into a sequence or linear order. The **next permutation** of an array of integers is the next lexicographically greater permutation of its integer. More formally, if all the permutations of the array are sorted in one container according to their lexicographical order, then the next permutation of that array is the permutation that follows it in the sorted container. If such an arrangement is not possible (i.e., the array is in descending order), the array must be rearranged as the lowest possible order (i.e., sorted in ascending order).

### Examples

-   **Example 1:**

    -   **Input:** `nums = [1,2,3]`
    -   **Output:** `[1,3,2]`
    -   **Explanation:** The next permutation is obtained by swapping `2` and `3`.
-   **Example 2:**

    -   **Input:** `nums = [3,2,1]`
    -   **Output:** `[1,2,3]`
    -   **Explanation:** The array is in descending order, so the next permutation is the smallest possible, which is sorted in ascending order.
-   **Example 3:**

    -   **Input:** `nums = [1,1,5]`
    -   **Output:** `[1,5,1]`
    -   **Explanation:** The next permutation is obtained by swapping the second `1` with `5`.

### Constraints

-   `1 <= nums.length <= 100`
-   `0 <= nums[i] <= 100`

Solution
--------

To solve the "Next Permutation" problem in C#, we'll implement an efficient algorithm that modifies the input array `nums` in-place to produce the next lexicographical permutation. If such a permutation isn't possible (i.e., the array is in descending order), we'll rearrange it to the lowest possible order (i.e., sorted in ascending order).

### Intuition

The key idea is to identify the rightmost position in the array where the sequence can be incremented to form a greater permutation. This involves finding the first pair of two successive numbers from the end where the first number is smaller than the second. Once this pair is found, swapping it with the smallest number larger than it in the suffix ensures the next permutation is just one step ahead. Finally, reversing the suffix guarantees that the new permutation is the smallest possible one that is larger than the current arrangement.

### Approach

1.  **Identify the Pivot:**

    -   Traverse the array from the end to find the first index `i` such that `nums[i] < nums[i + 1]`. This index `i` marks the pivot point where the next permutation can be formed.
    -   If no such index exists (i.e., the entire array is non-increasing), the array is in its highest permutation. In this case, reverse the entire array to transform it into the lowest possible order.
2.  **Find the Successor to the Pivot:**

    -   Once the pivot is identified at index `i`, traverse the array again from the end to find the first index `j` where `nums[j] > nums[i]`. This element `nums[j]` is the smallest number larger than `nums[i]` in the suffix.
    -   Swap the elements at indices `i` and `j`. This step ensures that the next permutation is just larger than the current one.
3.  **Reverse the Suffix:**

    -   After swapping, the suffix starting at index `i + 1` is still in descending order. To obtain the next smallest permutation, reverse this suffix to transform it into ascending order.
4.  **Edge Cases:**

    -   If the array has only one element or is `null`, no action is needed.
    -   Handle cases where multiple duplicate elements exist by ensuring that the correct successor is chosen for the pivot.

### Step-by-Step Example

Consider the array `[1, 3, 5, 4, 2]`:

1.  **Identify the Pivot:**

    -   Start from the end: `4 > 2` → continue.
    -   `5 > 4` → continue.
    -   `3 < 5` → pivot found at index `1` (value `3`).
2.  **Find the Successor:**

    -   Traverse from the end to find the first number greater than `3`, which is `4` at index `3`.
    -   Swap `3` and `4`: `[1, 4, 5, 3, 2]`.
3.  **Reverse the Suffix:**

    -   Reverse the suffix starting at index `2`: `[1, 4, 2, 3, 5]`.

The next permutation is `[1, 4, 2, 3, 5]`.

Complexity Analysis
-------------------

-   **Time Complexity:** O(n)O(n)O(n)

    -   We perform a constant number of passes through the array:
        -   One pass to find the pivot.
        -   Another pass to find the successor.
        -   A final pass to reverse the suffix.
    -   Each of these operations is linear with respect to the length of the array.
-   **Space Complexity:** O(1)O(1)O(1)

    -   The algorithm modifies the array in-place and uses only a fixed amount of extra space for variables like indices and temporary storage during swaps.

### Explanation of the Code

1.  **Edge Case Handling:**

    -   The method first checks if the input array `nums` is `null` or has only one element. If so, there's nothing to do, so the method returns immediately.
2.  **Finding the Pivot (`i`):**

    -   Starting from the second-last element (`nums.Length - 2`), traverse the array backwards to find the first index `i` where `nums[i] < nums[i + 1]`. This index `i` is the pivot point.
3.  **Finding the Successor (`j`):**

    -   If a pivot is found (`i >= 0`), traverse the array from the end to find the first index `j` where `nums[j] > nums[i]`. This element `nums[j]` is the smallest number greater than `nums[i]` in the suffix.
    -   Swap `nums[i]` and `nums[j]` to create a larger permutation.
4.  **Reversing the Suffix:**

    -   After swapping, the suffix (elements after index `i`) is still in descending order. Reverse this suffix to transform it into ascending order, ensuring the smallest possible next permutation.
5.  **Helper Methods:**

    -   `Swap`: Swaps two elements in the array given their indices using tuple deconstruction for brevity.
    -   `Reverse`: Reverses a portion of the array in-place between the `start` and `end` indices by repeatedly swapping elements from both ends towards the center.

### Code Breakdown

-   **Method: `NextPermutation`**

    -   **Parameters:** `int[] nums` - The input array of integers.
    -   **Functionality:** Modifies the input array to its next lexicographical permutation.
-   **Method: `Swap`**

    -   **Parameters:** `int[] nums`, `int i`, `int j` - The array and the two indices of elements to swap.
    -   **Functionality:** Swaps the elements at indices `i` and `j` using tuple swapping for efficiency.
-   **Method: `Reverse`**

    -   **Parameters:** `int[] nums`, `int start`, `int end` - The array and the start and end indices of the subarray to reverse.
    -   **Functionality:** Reverses the elements in the specified range in-place.
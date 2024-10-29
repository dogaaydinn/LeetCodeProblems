### Intuition

The problem asks to move all zeros in the array to the end while maintaining the relative order of the non-zero
elements. The key observation here is that we can solve this problem by using a two-pass approach: first, we move all
non-zero elements to the front, then we fill the remaining spaces with zeros.

### # Approach

1. **First Pass (Move Non-Zero Elements):**
    - We initialize an `index` variable to keep track of the position where the next non-zero element should be placed.
      We iterate through the array and whenever we encounter a non-zero element, we place it at `nums[index]` and then
      increment `index`.

2. **Second Pass (Fill Remaining with Zeros):**
    - After all the non-zero elements are placed in the front part of the array, the remaining positions (from `index`
      to the end of the array) are filled with zeros.

This method ensures that all the non-zero elements retain their order and that all zeros are moved to the end of the
array.

### Complexity

- **Time complexity:**
    - The first loop iterates over all the elements of the array, and the second loop fills the remaining part with
      zeros. Therefore, the total time complexity is:
      $$ O(n) $$  
      where \( n \) is the number of elements in the array.

- **Space complexity:**
    - Since we are not using any extra data structures and only modifying the input array in place, the space complexity
      is:
      $$ O(1) $$

---

### **Test Results**

- **74 / 74 test cases passed.**
- **Status:** Accepted
- **Runtime:** 1 ms
- **Memory Usage:** 57.4 MB

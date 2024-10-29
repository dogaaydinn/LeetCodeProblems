# LeetCode Problem: Reverse Integer

## Problem Description:

Given a signed 32-bit integer `x`, return `x` with its digits reversed. If reversing `x` causes the value to go outside
the signed 32-bit integer range [-2^31, 2^31 - 1], return 0.

**Assumptions:**

- The environment does not allow storing 64-bit integers (signed or unsigned).

### Example 1:

**Input:**  
`x = 123`  
**Output:**  
`321`

### Example 2:

**Input:**  
`x = -123`  
**Output:**  
`-321`

### Example 3:

**Input:**  
`x = 120`  
**Output:**  
`21`

### Constraints:

- `-2^31 <= x <= 2^31 - 1`

---

## Solution Explanation:

The goal is to reverse the digits of a given integer `x` while ensuring the result remains within the 32-bit signed
integer range. If the reversed integer exceeds this range, we must return `0`.

### Steps:

1. **Initialization:**
    - We initialize `reversed = 0` to store the reversed number.

2. **Digit Extraction:**
    - In each iteration of the loop, the last digit of `x` is extracted using `x % 10`. We then remove this digit from
      `x` using `x /= 10`.

3. **Overflow Check:**
    - Before updating `reversed`, we check for potential overflow conditions:
        - If `reversed > int.MaxValue / 10`, or if `reversed == int.MaxValue / 10` and the last digit (`pop`) is greater
          than 7.
        - If `reversed < int.MinValue / 10`, or if `reversed == int.MinValue / 10` and the last digit (`pop`) is less
          than -8.
    - If any of these conditions hold, return `0` to indicate overflow.

4. **Update Reversed Number:**
    - If no overflow is detected, update `reversed` with the new digit:  
      `reversed = reversed * 10 + pop`.

5. **Return Result:**
    - Once all digits have been processed, return the `reversed` value.

### Edge Cases:

**Input**: x = 0 → Output: 0 (no digits to reverse).
Input: x = 1534236469 → Output: 0 (reversing causes overflow).
Input: x = -8463847412 → Output: -2147483648 (reverse remains within bounds).
**Time and Space Complexity:**
Time Complexity: O(log(x)) — We process each digit in x, which has a logarithmic relationship with the number of digits.

**Space Complexity:** O(1) — The algorithm uses a constant amount of extra space.


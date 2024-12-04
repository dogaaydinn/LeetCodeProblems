## Divide Two Integers Solution in C#

Intuition
=========

To solve the problem of dividing two integers without using multiplication, division, or the mod operator, we can use bit manipulation and subtraction. The idea is to repeatedly subtract the divisor from the dividend while keeping track of how many times we can do this. By using bit shifts, we can efficiently find the largest multiple of the divisor that fits into the remaining dividend.

Approach
========

1.  Handle edge cases such as division by zero and overflow.
2.  Determine the sign of the result based on the signs of the dividend and divisor.
3.  Convert both the dividend and divisor to their absolute values to simplify the calculation.
4.  Use bit manipulation to find the quotient by repeatedly subtracting the largest possible multiple of the divisor from the dividend.
5.  Adjust the sign of the result based on the initial signs of the dividend and divisor.
6.  Ensure the result is within the 32-bit signed integer range.

Complexity
==========

-   Time complexity:\
    The time complexity is O(logn), where n is the absolute value of the dividend. This is because we are using bit shifts to efficiently find the largest multiple of the divisor.

-   Space complexity:\
    The space complexity is O(1) since we are using a constant amount of extra space.

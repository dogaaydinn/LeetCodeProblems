# 443. String Compression

## Problem Statement
Given an array of characters `chars`, compress it using the following algorithm:

- Begin with an empty string `s`. For each group of consecutive repeating characters in `chars`:
  - If the group's length is 1, append the character to `s`.
  - Otherwise, append the character followed by the group's length.

The compressed string `s` should not be returned separately, but instead, be stored in the input character array `chars`. Note that group lengths that are 10 or longer will be split into multiple characters in `chars`.

After you are done modifying the input array, return the new length of the array.

You must write an algorithm that uses only constant extra space.


Constraints
1 <= chars.length <= 2000
chars[i] is a lowercase English letter, uppercase English letter, digit, or symbol.
Approach
Use two pointers (i for reading and write for writing) to iterate through the chars array.
Count the occurrences of consecutive characters.
Write the character and its count (if greater than 1) back into the chars array.
Return the new length of the array.

Complexity
- Time Complexity: O(n), where n is the length of the input array.
- Space Complexity: O(1), as we are modifying the input array in place and using a constant amount of extra space.

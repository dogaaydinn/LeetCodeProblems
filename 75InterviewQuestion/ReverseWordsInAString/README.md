# LeetCode - 151. Reverse Words in a String

## Problem Description

Given an input string `s`, reverse the order of the words.

A word is defined as a sequence of non-space characters. The words in `s` will be separated by at least one space.

Return a string of the words in reverse order, concatenated by a single space. Note that `s` may contain leading or
trailing spaces or multiple spaces between two words. The returned string should have only a single space separating the
words, without extra spaces.

### Examples

#### Example 1:

	```plaintext

	Input: s = "the sky is blue"

	Output: "blue is sky the"
	Input: s = "  hello world  "
	Output: "world hello"
	Explanation: Your reversed string should not contain leading or trailing spaces.

	Input: s = "a good   example"
	Output: "example good a"

## Explanation: Multiple spaces between two words should be reduced to a single space.

### Constraints

1 <= s.length <= 10^4
s contains English letters (upper-case and lower-case), digits, and spaces ' '.
There is at least one word in s.

## Solution Approach

- Trim the string to remove leading and trailing spaces.
- Split the string by spaces, using StringSplitOptions.RemoveEmptyEntries to handle multiple spaces.
- Reverse the array of words.
  -Join the reversed words into a new string with a single space between them.

## Explanation:

- Trim(): Removes extra spaces from the beginning and end of the string.
- Split(): Splits the string into words based on spaces and removes any empty entries caused by multiple spaces.
- Array.Reverse(): Reverses the order of the words.
- string.Join(" ", words): Joins the words back into a single string with a single space between each word.

## Time Complexity:

- The time complexity of this solution is O(n), where n is the length of the input string s.
  Trimming the string takes O(n).

Splitting the string into words takes O(n).
Reversing the array of words takes O(n).
Joining the words into a final string takes O(n).

- Space Complexity:
  The space complexity is O(n) because we store the words in an array and create a new string as the output.
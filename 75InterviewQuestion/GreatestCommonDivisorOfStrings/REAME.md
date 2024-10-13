## 📜 Largest Common Divisor (GCD) Substring

### Problem Statement

The task is to find the largest common divisor (GCD) substring between two given strings, str1 and str2. This substring represents a repeating pattern that can construct both strings. By calculating the GCD of their lengths, we can identify the longest substring that may be able to form both strings through repetition.

### Intuition

The main idea is to compute the GCD based on the lengths of str1 and str2. This will give us the maximum possible length of a common substring. We then take a candidate substring from the start of str1 of this GCD length and check if this substring can construct both str1 and str2 by repetition. If replacing all instances of the candidate substring in both strings results in empty strings, then it is a valid common substring.

### Approach

1. Compute the GCD Length:
 Use the GCD of the lengths of str1 and str2 to determine the maximum potential length of a common substring.
2. Create Candidate Substring:
 Extract a substring from str1 starting from the beginning, with a length equal to the GCD.
3. Check Validity: 
Replace all occurrences of the candidate substring in both strings and check if they result in empty strings.
4. Return Result:
 If both strings are empty after replacement, return the candidate substring; otherwise, return an empty string ("") indicating no common substring exists.
 
### Complexity

**Time Complexity:**

- The GCD function runs in O(log(min(a, b))) time.

- The Replace function operates over both strings, taking O(n + m) time (where n and m are the lengths of str1 and str2).
- Overall time complexity: O(n + m), where n = str1.Length and m = str2.Length.

**Space Complexity:**

- The extra space requirement is O(1) since the only additional space used is for the candidate substring and some variables.

# Reverse Vowels of a String

## Intuition
The problem asks us to reverse only the vowels in the string, leaving all other characters in their original positions. The key idea is to use two pointers: one starting from the beginning and the other from the end, to find vowels and swap them. This approach ensures that we efficiently reverse the vowels while avoiding unnecessary operations on non-vowel characters.

## Approach
1. **Two Pointers**: 
   - One pointer (`start`) starts at the beginning of the string.
   - The other pointer (`end`) starts at the end of the string.
   
2. **Vowel Check Using HashSet**: 
   - We create a `HashSet<char>` that contains all the vowels (both lowercase and uppercase) for quick lookup.
   
3. **Iterative Process**:
   - Move the `start` pointer forward until it finds a vowel.
   - Move the `end` pointer backward until it finds a vowel.
   - If both `start` and `end` point to vowels, swap them.
   - Continue moving the pointers inward and repeat the process until they meet or cross.
   
4. **Return the Modified String**: 
   - Once all the vowels are swapped, convert the modified `char[]` back to a string and return it.

## Complexity

- **Time complexity**:  
  The time complexity is $$O(n)$$ because we only traverse the string once, with both pointers moving towards the center. Each character is processed a maximum of two times (once by each pointer).

- **Space complexity**:  
  The space complexity is $$O(n)$$ because we create an additional character array `char[] sChars` to store the input string, and the `HashSet` used for vowel lookups is a constant space structure (its size does not depend on the input size).

## Code

```csharp
public class Solution {
    public string ReverseVowels(string s) {
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        int start = 0;
        int end = s.Length - 1;
        char[] sChars = s.ToCharArray();

        while (start < end) {
            // Move start forward until a vowel is found
            while (start < end && !vowels.Contains(sChars[start])) start++;
            // Move end backward until a vowel is found
            while (start < end && !vowels.Contains(sChars[end])) end--;

            // Swap the vowels
            if (start < end) {
                char temp = sChars[start];
                sChars[start++] = sChars[end];
                sChars[end--] = temp;
            }
        }

        return new string(sChars);
    }
}


namespace _75InterviewQuestion.ReverseVowelsOfAString;

public class _345_ReverseVowelsOfAString
{
    /*
     Problem:
        Write a function that takes a string as input and reverse only the vowels of a string.

        Approach:
        1. Initialize a hash set to store all the vowels.
        2. Initialize two pointers, start and end, to the start and end of the string, respectively.
        3. Convert the string to a character array.
        4. While the start pointer is less than the end pointer:
            a. Move the start pointer to the next vowel.
            b. Move the end pointer to the previous vowel.
            c. Swap the vowels at the start and end pointers.
        5. Return the reversed string.

        Time complexity: O(n), where n is the length of the string.
        Space complexity: O(1).
     */
    public string ReverseVowels(string s)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        var start = 0;
        var end = s.Length - 1;
        var sChars = s.ToCharArray();

        while (start < end)
        {
            while (start < end && !vowels.Contains(sChars[start])) start++;
            while (start < end && !vowels.Contains(sChars[end])) end--;

            if (start < end)
            {
                var temp = sChars[start];
                sChars[start++] = sChars[end];
                sChars[end--] = temp;
            }
        }

        return new string(sChars);
    }
}
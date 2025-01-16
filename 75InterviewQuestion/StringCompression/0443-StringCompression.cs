namespace _75InterviewQuestion.StringCompression;

public class _443_StringCompression
{
    /*
     * 443. String Compression
     * Given an array of characters chars, compress it using the following algorithm:
     * Begin with an empty string s. For each group of consecutive repeating characters in chars:
     * If the group's length is 1, append the character to s.
     * Otherwise, append the character followed by the group's length.
     *
     * The compressed string s should not be returned separately, but instead, be stored in the input character array chars.
     * Note that group lengths that are 10 or longer will be split into multiple characters in chars.
     * After you are done modifying the input array, return the new length of the array.
     * You must write an algorithm that uses only constant extra space.
     *
     * Approach:
     * 1. Initialize two pointers, write and i, to 0.
     * 2. Iterate over the chars array.
     * 3. Initialize a variable, currentChar, to store the current character.
     * 4. Initialize a variable, count, to store the count of the current character.
     * 5. While the current character is equal to the character at the i-th position of chars:
     *     - Increment i.
     *    - Increment count.
     * 6. Append the current character to the write-th position of chars.
     * 7. Increment write.
     * 8. If the count is greater than 1, convert the count to a string and append each character to the write-th position of chars.
     * 9. Increment write.
     * 10. Return the write pointer.
     *
     * Time complexity: O(n), where n is the length of the chars array.
     * Space complexity: O(1).
     */
    public int Compress(char[] chars)
    {
        var write = 0;
        var i = 0;

        while (i < chars.Length)
        {
            var currentChar = chars[i];
            var count = 0;

            while (i < chars.Length && chars[i] == currentChar)
            {
                i++;
                count++;
            }

            chars[write] = currentChar;
            write++;

            if (count <= 1) continue;
            foreach (var c in count.ToString())
            {
                chars[write] = c;
                write++;
            }
        }

        return write;
    }
}
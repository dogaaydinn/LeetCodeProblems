using System.Text;

namespace _75InterviewQuestion.MergeStringsAlternately;

public static class _1798_MergeStringsAlternately
{
    /*
     * 1798. Merge Strings Alternately
     * You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.
     * Return the merged string.
     *
     * Approach:
     * 1. Initialize two variables, length1 and length2, to store the lengths of word1 and word2, respectively.
     * 2. Initialize a variable, maxLength, to store the maximum length of the two strings.
     * 3. Initialize a StringBuilder, combinedWord, to store the merged string.
     * 4. Iterate over the maxLength.
     * 5. If the current index is less than the length of word1, append the character at the current index of word1 to the combinedWord.
     * 6. If the current index is less than the length of word2, append the character at the current index of word2 to the combinedWord.
     * 7. Return the merged string.
     *
     */
    public static string MergeAlternately(string word1, string word2)
    {
        var length1 = word1.Length;
        var length2 = word2.Length;

        var maxLength = Math.Max(length1, length2);

        var combinedWord = new StringBuilder(length1 + length2);

        for (var i = 0; i < maxLength; i++)
        {
            if (i < length1) combinedWord.Append(word1[i]);
            if (i < length2) combinedWord.Append(word2[i]);
        }

        return combinedWord.ToString();
    }
}
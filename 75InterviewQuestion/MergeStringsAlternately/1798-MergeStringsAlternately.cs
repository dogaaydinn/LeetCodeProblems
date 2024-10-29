using System.Text;

namespace _75InterviewQuestion.MergeStringsAlternately;

public static class _1798_MergeStringsAlternately
{
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
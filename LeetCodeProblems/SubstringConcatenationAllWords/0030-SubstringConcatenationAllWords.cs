namespace LeetCodeProblems.SubstringConcatenationAllWords;

public class _30_SubstringConcatenationAllWords
{
    /*
        * Problem: 30. Substring with Concatenation of All Words
     Given a string s and a list of words, where each word is the same length, find all starting indices of substring(s) in s that is a concatenation of each word in words exactly once and without any intervening characters.

        Approach:
            1. Create a result list.
            2. If the string is empty or the words array is null or empty, return the result list.
            3. Get the length of a word.
            4. Get the total length of all words.
            5. Create a dictionary to store the count of each word.
            6. Iterate through the words and add the count of each word to the dictionary.
            7. Iterate through the string from 0 to the length of the string minus the total length of all words.
            8. Create a dictionary to store the count of words seen so far.
            9. Create a variable j to iterate through the words.
            10. While j is less than the length of the words array:
                a. Get the word from the substring of the string starting at i + j * word length and with the length of a word.
                b. If the word is in the dictionary of word counts:
                    i. If the word is already in the dictionary of seen words, increment the count.
                    ii. Otherwise, add the word to the dictionary of seen words.
                    iii. If the count of the word in the dictionary of seen words is greater than the count of the word in the dictionary of word counts, break.
                c. Otherwise, break.
                d. Increment j.
            11. If j is equal to the length of the words array, add i to the result list.
            12. Return the result list.

            Time complexity: O(n * m), where n is the length of the string and m is the length of the words array.
            Space complexity: O(m), where m is the length of the words array.
     */
    public IList<int> FindSubstring(string? s, string[]? words)
    {
        IList<int> result = new List<int>();
        if (string.IsNullOrEmpty(s) || words == null || words.Length == 0) return result;

        var wordLength = words[0].Length;
        var totalLength = wordLength * words.Length;
        Dictionary<string, int> wordCount = new();

        foreach (var word in words)
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;

        for (var i = 0; i <= s.Length - totalLength; i++)
        {
            Dictionary<string, int> seenWords = new();
            var j = 0;
            while (j < words.Length)
            {
                var word = s.Substring(i + j * wordLength, wordLength);
                if (wordCount.TryGetValue(word, out var value))
                {
                    if (!seenWords.TryAdd(word, 1)) seenWords[word]++;

                    if (seenWords[word] > value) break;
                }
                else
                {
                    break;
                }

                j++;
            }

            if (j == words.Length) result.Add(i);
        }

        return result;
    }
}
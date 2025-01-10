namespace LeetCodeProblems.SubstringConcatenationAllWords;

public class _30_SubstringConcatenationAllWords
{
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
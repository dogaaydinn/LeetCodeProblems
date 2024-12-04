namespace LeetCodeProblems.SubstringConcatenationAllWords;

public class _30_SubstringConcatenationAllWords {
    public IList<int> FindSubstring(string? s, string[]? words) {
        IList<int> result = new List<int>();
        if (string.IsNullOrEmpty(s) || words == null || words.Length == 0) {
            return result;
        }

        int wordLength = words[0].Length;
        int totalLength = wordLength * words.Length;
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words) {
            if (wordCount.ContainsKey(word)) {
                wordCount[word]++;
            } else {
                wordCount[word] = 1;
            }
        }

        for (int i = 0; i <= s.Length - totalLength; i++) {
            Dictionary<string, int> seenWords = new Dictionary<string, int>();
            int j = 0;
            while (j < words.Length) {
                string word = s.Substring(i + j * wordLength, wordLength);
                if (wordCount.TryGetValue(word, out var value)) {
                    if (!seenWords.TryAdd(word, 1)) {
                        seenWords[word]++;
                    }

                    if (seenWords[word] > value) {
                        break;
                    }
                } else {
                    break;
                }
                j++;
            }

            if (j == words.Length) {
                result.Add(i);
            }
        }

        return result;
    }
}
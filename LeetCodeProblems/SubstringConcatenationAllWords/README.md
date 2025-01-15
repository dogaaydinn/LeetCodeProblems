# Problem: 30. Substring with Concatenation of All Words

## Description:
Given a string `s` and a list of words, where each word is the same length, find all starting indices of substring(s) in `s` that is a concatenation of each word in `words` exactly once and without any intervening characters.

### Notes:
- Each word in `words` can appear multiple times.
- The order of words in the substring does not matter.
- If no valid substring exists, return an empty list.


## Approach:
To solve the problem:
1. **Edge Cases:**
   - If the input string `s` is empty, or `words` is null or empty, return an empty list.

2. **Initialization:**
   - Determine the length of each word (`wordLength`).
   - Calculate the total length of all words concatenated (`totalLength`).
   - Create a dictionary `wordCount` to store the frequency of each word in `words`.

3. **Iterate Through the String:**
   - Loop through `s` starting from index 0 to `s.Length - totalLength`.
   - For each starting index `i`:
     - Create a `seenWords` dictionary to track the frequency of words encountered in the current substring.
     - Iterate through the substring in chunks of `wordLength`:
       - Extract the current word from the substring.
       - If the word is not in `wordCount`, break the loop.
       - Otherwise, update `seenWords`.
       - If the frequency of any word in `seenWords` exceeds its frequency in `wordCount`, break the loop.
     - If all words are matched exactly, add the index `i` to the result list.

4. **Return Result:**
   - Return the list of starting indices where valid substrings are found.

### Complexity Analysis:
- **Time Complexity:** O(n * m), where `n` is the length of `s` and `m` is the number of words in `words`.
- **Space Complexity:** O(m), for storing `wordCount` and `seenWords`.

## Code Implementation:
```csharp
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
```

## Edge Cases:
1. **Empty Input:**
   - Input: `s = "", words = ["foo"]`
   - Output: `[]`

2. **No Matches:**
   - Input: `s = "abcdef", words = ["gh", "ij"]`
   - Output: `[]`

3. **Overlapping Words:**
   - Input: `s = "barfoobarfoo", words = ["bar", "foo"]`
   - Output: `[0, 3, 6]`

4. **Single Character Words:**
   - Input: `s = "abc", words = ["a", "b", "c"]`
   - Output: `[0]`



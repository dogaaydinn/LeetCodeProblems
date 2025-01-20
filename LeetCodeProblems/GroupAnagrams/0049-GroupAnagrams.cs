namespace LeetCodeProblems.GroupAnagrams;

public class _0049_GroupAnagrams
{
    /*
     Intuition:
        - Anagrams are words that have the same characters but in different orders.
        - We can sort the characters of each word and use the sorted string as a key in a dictionary.
        - The value of the dictionary will be a list of words that are anagrams of each other.
        - Finally, we can return the values of the dictionary as a list of lists.
        
        Approach:
        - Create a dictionary to store the anagrams.
        - Iterate through each word in the input array.
        - Sort the characters of the word and use the sorted string as a key in the dictionary.
        - If the key does not exist in the dictionary, create a new list and add the word to it.
        - If the key exists in the dictionary, add the word to the list.
        - Return the values of the dictionary as a list of lists.
        
        Time complexity:
        - Let n be the number of words in the input array and k be the maximum length of a word.
        - Sorting a word takes O(k log k) time.
        - We iterate through each word in the input array, so the total time complexity is O(n * k log k).
        - The space complexity is O(n * k) to store the anagrams.
        
     */
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagrams = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var sortedStr = new string(str.OrderBy(c => c).ToArray());
            if (!anagrams.ContainsKey(sortedStr))
            {
                anagrams[sortedStr] = new List<string>();
            }
            anagrams[sortedStr].Add(str);
        }

        return anagrams.Values.ToList<IList<string>>();
    }
}
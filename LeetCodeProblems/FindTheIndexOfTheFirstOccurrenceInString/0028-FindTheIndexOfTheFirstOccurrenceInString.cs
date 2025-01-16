namespace LeetCodeProblems.FindTheIndexOfTheFirstOccurrenceInString;

public class _28_FindTheIndexOfTheFirstOccurrenceInString
{
    /*
     Given two strings haystack and needle, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

     Approach:
        1. If the needle is empty, return 0.
        2. Iterate through the haystack.
        3. If the substring of the haystack from i to the length of the needle is equal to the needle, return i.
        4. Return -1.

        Time complexity: O(n * m), where n is the length of the haystack and m is the length of the needle.
        Space complexity: O(1)
     */
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle))
            return 0;

        for (var i = 0; i <= haystack.Length - needle.Length; i++)
            if (haystack.Substring(i, needle.Length) == needle)
                return i;

        return -1;
    }
}
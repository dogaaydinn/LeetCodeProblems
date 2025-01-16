namespace _75InterviewQuestion.ReverseWordsInAString;

public class _151_ReverseWordsInAString
{
    /*
        * 151. Reverse Words in a String
        * Given an input string s, reverse the order of the words.
     Approach:
        1. Trim the input string.
        2. Split the string by space.
        3. Reverse the array of words.
        4. Join the words with space.

        Time complexity: O(n), where n is the length of the input string.
        Space complexity: O(n).
     */
    public string ReverseWords(string s)
    {
        s = s.Trim();

        var words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        return string.Join(" ", words);
    }
}
using System.Text;

namespace LeetCodeProblems.CountAndSay;

public class _38_CountAndSay
{
    /*
     Given an integer n, return the nth term of the count-and-say sequence.
     The count-and-say sequence is the sequence of integers with the first five terms as following:

        Approach:
        1. We will start with n = 1.
        2. We will get the sequence for n = 1.
        3. We will iterate from n = 2 to n.
        4. For each n, we will get the next sequence.
        5. To get the next sequence, we will iterate through the current sequence.
        6. We will count the number of times the current character is repeated.
        7. We will append the count and the character to the next sequence.
        8. We will return the next sequence.
        9. Time complexity is O(n * m) where n is the input and m is the length of the sequence.
        10. Space complexity is O(m) where m is the length of the sequence.

     */
    public string CountAndSay(int n)
    {
        if (n == 1) return "1";

        var result = "1";
        for (var i = 2; i <= n; i++) result = GetNextSequence(result);
        return result;
    }

    private string GetNextSequence(string sequence)
    {
        var nextSequence = new StringBuilder();
        var count = 1;
        var currentChar = sequence[0];

        for (var i = 1; i < sequence.Length; i++)
            if (sequence[i] == currentChar)
            {
                count++;
            }
            else
            {
                nextSequence.Append(count).Append(currentChar);
                currentChar = sequence[i];
                count = 1;
            }

        nextSequence.Append(count).Append(currentChar);

        return nextSequence.ToString();
    }
}
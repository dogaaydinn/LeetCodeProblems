namespace _75InterviewQuestion.IsSubsequence;

public class _392_IsSubsequence
{
    //first solution

    public bool IsSubsequence(string s, string t)
    {
        var substring = s;
        var mainString = t;

        if (t.Length < s.Length) return false;

        var i = 0;
        while (i < substring.Length && mainString.Length > 0)
        {
            if (mainString[0] == substring[i]) i++;
            mainString = mainString.Substring(1);
        }

        return i == substring.Length;
    }

    //second solution
    public bool IsSubsequence2(string s, string t)
    {
        if (s.Length > t.Length) return false;

        var i = 0;
        var j = 0;

        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j]) i++;
            j++;
        }

        return i == s.Length;
    }
}
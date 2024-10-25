namespace LeetCodeProblems.LongestCommonPrefix;

public class _14_LongestCommonPrefix {
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix, StringComparison.Ordinal) !=0)
            {
                prefix = prefix[..^1];

                if (prefix.Length==0)
                {
                    return "";
                }
            }
        }

        return prefix;
    }
}
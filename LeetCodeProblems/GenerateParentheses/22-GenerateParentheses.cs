namespace LeetCodeProblems.GenerateParentheses;

public class _22_GenerateParentheses
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();

        void Generate(string current, int open, int close, int max)
        {
            if (current.Length == max * 2)
            {
                result.Add(current);
                return;
            }

            if (open < max) Generate(current + "(", open + 1, close, max);

            if (close < open) Generate(current + ")", open, close + 1, max);
        }

        Generate("", 0, 0, n);
        return result;
    }
}
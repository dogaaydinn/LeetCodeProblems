namespace LeetCodeProblems.GenerateParentheses;

public class _22_GenerateParentheses
{
    /*
    Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

    Approach:
        1. Create a recursive function Generate that generates all combinations of well-formed parentheses.
        2. The function takes four parameters: the current string, the number of open parentheses, the number of close parentheses, and the maximum number of parentheses.
        3. If the length of the current string is equal to the maximum number of parentheses multiplied by 2, add the current string to the result.
        4. If the number of open parentheses is less than the maximum number of parentheses, call the Generate function with an open parenthesis.
        5. If the number of close parentheses is less than the number of open parentheses, call the Generate function with a close parenthesis.
        6. Call the Generate function with an empty string, 0 open parentheses, 0 close parentheses, and n.
        7. Return the result.

        Time complexity: O(4^n / sqrt(n))
        Space complexity: O(4^n / sqrt(n))
     */
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
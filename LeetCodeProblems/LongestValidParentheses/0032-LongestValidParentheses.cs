namespace LeetCodeProblems.LongestValidParentheses;

public class _0032_LongestValidParentheses
{
    public int LongestValidParentheses(string s)
    {
        int maxLen = 0;
        Stack<int> stack = new Stack<int>();

        // Initialize the stack with -1,
        // which acts as a base for calculating lengths.
        stack.Push(-1);

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                // Push the index of '(' onto the stack.
                stack.Push(i);
            }
            else // s[i] == ')'
            {
                // Pop the last opening bracket's index.
                stack.Pop();

                if (stack.Count == 0)
                {
                    // No matching opening bracket, push current index as base.
                    stack.Push(i);
                }
                else
                {
                    // Calculate the length of the current valid substring.
                    // The current valid substring starts right after the index
                    // at the top of the stack.
                    maxLen = Math.Max(maxLen, i - stack.Peek());
                }
            }
        }

        return maxLen;
    }
}
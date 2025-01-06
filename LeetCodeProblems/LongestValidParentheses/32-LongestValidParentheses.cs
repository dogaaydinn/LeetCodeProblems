namespace LeetCodeProblems.LongestValidParentheses;

public class _32_LongestValidParentheses {
    public int LongestValidParentheses(string s) {
        Stack<int> stack = new Stack<int>();
        stack.Push(-1); 
        var maxLength = 0;

        for (var i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                stack.Push(i); 
            } else {
                stack.Pop(); 
                if (stack.Count == 0) {
                    stack.Push(i); 
                } else {
                    maxLength = Math.Max(maxLength, i - stack.Peek());
                }
            }
        }

        return maxLength;
    }

}
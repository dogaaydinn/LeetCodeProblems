namespace LeetCodeProblems.ValidParentheses;

public class _20_ValidParentheses
{
    /*
     Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        An input string is valid if:
            1. Open brackets must be closed by the same type of brackets.
            2. Open brackets must be closed in the correct order.


        Approach:
            1. Create a stack to store the opening brackets.
            2. Iterate through the string.
            3. If the character is an opening bracket, push it to the stack.
            4. If the character is a closing bracket, pop the top element from the stack.
            5. If the stack is empty or the top element is not the corresponding opening bracket, return false.
            6. If the stack is not empty after iterating through the string, return false.
            7. Return true.

            Time complexity: O(n)
            Space complexity: O(n)
     */
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
            if (c is '(' or '{' or '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) return false;
                var top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                    return false;
            }

        return stack.Count == 0;
    }
}
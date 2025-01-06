namespace LeetCodeProblems.LongestValidParentheses;

/*
 # Intuition
    - We can use stack to solve this problem.
    - We will push -1 to stack initially.
    - We will iterate over the string.
    - If we find '(' then we will push the index to stack.
    - If we find ')' then we will pop the top element from stack.
    - If stack is empty then we will push the index to stack.
    - If stack is not empty then we will calculate the length of valid parentheses and update the maxLength.
    - Finally we will return the maxLength.
    
    # Time Complexity
        - O(N), where N is the length of the string.
    # Space Complexity
        - O(N), where N is the length of the string.
        # Approach
        - We will use stack to solve this problem.
        - We will push -1 to stack initially.
        - We will iterate over the string.
        - If we find '(' then we will push the index to stack.
        - If we find ')' then we will pop the top element from stack.
        - If stack is empty then we will push the index to stack.
        - If stack is not empty then we will calculate the length of valid parentheses and update the maxLength.
        - Finally we will return the maxLength.
        
 */
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
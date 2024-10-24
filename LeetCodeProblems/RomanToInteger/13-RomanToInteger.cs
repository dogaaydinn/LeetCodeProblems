namespace LeetCodeProblems.RomanToInteger;

public class _13_RomanToInteger {
    public int RomanToInt(string s) {
        Dictionary<char, int> roman = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        
        int result = 0;
        int previousValue = 0;
        
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int value = roman[s[i]];
            
            if (value < previousValue)
            {
                result -= value;
            }
            else
            {
                result += value;
            }
            
            previousValue = value;
        }
        
        return result;
    }
}
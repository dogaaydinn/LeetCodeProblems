namespace LeetCodeProblems.LetterCombinationsPhoneNumber;

public class _17_LetterCombinationsPhoneNumber
{
    /*
    Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
    A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

    Approach:
        1. Create a phoneLetter array that maps each digit to its corresponding letters.
        2. Create a digitMap dictionary that maps each digit to its corresponding letters.
        3. Create a result list to store the letter combinations.
        4. Create a stack to store the index and current letter combination.
        5. Push the initial index and an empty string to the stack.
        6. While the stack is not empty, pop the index and current letter combination from the stack.
        7. If the index is equal to the length of the digits, add the current letter combination to the result.
        8. Otherwise, get the digit from the digits string.
        9. If the digit is not in the digitMap, continue.
        10. Iterate through the letters of the digit and push the next index and the current letter combination with the letter to the stack.
        11. Return the result.

        Time complexity: O(4^n), where n is the length of the digits string.
        Space complexity: O(4^n)
     */
    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits)) return new List<string>();

        string[][] phoneLetter =
        {
            new[] { "a", "b", "c" },
            new[] { "d", "e", "f" },
            new[] { "g", "h", "i" },
            new[] { "j", "k", "l" },
            new[] { "m", "n", "o" },
            new[] { "p", "q", "r", "s" },
            new[] { "t", "u", "v" },
            new[] { "w", "x", "y", "z" }
        };

        var digitMap = new Dictionary<char, string[]>
        {
            { '2', phoneLetter[0] },
            { '3', phoneLetter[1] },
            { '4', phoneLetter[2] },
            { '5', phoneLetter[3] },
            { '6', phoneLetter[4] },
            { '7', phoneLetter[5] },
            { '8', phoneLetter[6] },
            { '9', phoneLetter[7] }
        };
        var result = new List<string>();
        var stack = new Stack<(int, string)>();
        stack.Push((0, ""));

        while (stack.Count > 0)
        {
            var (index, current) = stack.Pop();
            if (index == digits.Length)
            {
                result.Add(current);
            }
            else
            {
                var digit = digits[index];
                if (!digitMap.TryGetValue(digit, out var letters)) continue;
                foreach (var letter in letters) stack.Push((index + 1, current + letter));
            }
        }

        return result;
    }
}
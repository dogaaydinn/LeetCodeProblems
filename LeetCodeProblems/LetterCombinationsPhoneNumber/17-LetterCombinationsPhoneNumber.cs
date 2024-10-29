namespace LeetCodeProblems.LetterCombinationsPhoneNumber;

public class _17_LetterCombinationsPhoneNumber
{
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
                foreach (var letter in letters)
                {
                    stack.Push((index + 1, current + letter));
                }
            }
        }

        return result;
    }
}
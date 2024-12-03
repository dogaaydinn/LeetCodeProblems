public class PalindromeChecker
{
    public static bool IsPalindrome(string input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));

        try
        {
            // Remove spaces and punctuation, and convert to lower case.
            var processedInput = new string(Array.FindAll(input.ToCharArray(), char.IsLetterOrDigit));
            processedInput = processedInput.ToLowerInvariant();

            // Check if the processed string is a palindrome.
            var left = 0;
            var right = processedInput.Length - 1;
            while (left < right)
                if (processedInput[left] != processedInput[right])
                    return false;

            return true;
        }
        catch (Exception ex)
        {
            // Handle potential exceptions, such as index out of range.
            Console.WriteLine($"An error occurred: {ex.Message}");
            return false;
        }
    }

    public static void Main(string[] args)
    {
        // Example usage
        var input = "A man, a plan, a canal: Panama";
        var result = IsPalindrome(input);
        Console.WriteLine($"Is the input a palindrome? {result}");
    }
}
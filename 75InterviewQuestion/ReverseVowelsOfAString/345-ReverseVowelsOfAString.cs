namespace _75InterviewQuestion.ReverseVowelsOfAString;

public class _345_ReverseVowelsOfAString
{
    public string ReverseVowels(string s)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        var start = 0;
        var end = s.Length - 1;
        var sChars = s.ToCharArray();

        while (start < end)
        {
            while (start < end && !vowels.Contains(sChars[start])) start++;
            while (start < end && !vowels.Contains(sChars[end])) end--;

            if (start < end)
            {
                var temp = sChars[start];
                sChars[start++] = sChars[end];
                sChars[end--] = temp;
            }
        }

        return new string(sChars);
    }
}
namespace _75InterviewQuestion.ReverseWordsInAString;

public class _151_ReverseWordsInAString
{
    public string ReverseWords(string s)
    {
        s = s.Trim();

        var words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        return string.Join(" ", words);
    }
}
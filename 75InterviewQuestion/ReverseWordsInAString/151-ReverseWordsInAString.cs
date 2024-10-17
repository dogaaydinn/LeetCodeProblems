namespace _75InterviewQuestion.ReverseWordsInAString;

public class _151_ReverseWordsInAString {
    public string ReverseWords(string s) {
    
        s = s.Trim();
        
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
     
        Array.Reverse(words);

        return string.Join(" ", words);  
    }
}

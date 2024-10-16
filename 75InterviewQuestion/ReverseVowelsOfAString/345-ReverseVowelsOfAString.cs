using System.Text;

namespace _75InterviewQuestion.ReverseVowelsOfAString;

public class _345_ReverseVowelsOfAString {
    public string ReverseVowels(string s) {
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        int start = 0;
        int end = s.Length - 1;
        char[] sChars = s.ToCharArray();

        while (start < end) {
         
            while (start < end && !vowels.Contains(sChars[start])) start++;
            while (start < end && !vowels.Contains(sChars[end])) end--;

            if (start < end) {
                char temp = sChars[start];
                sChars[start++] = sChars[end];
                sChars[end--] = temp;
            }
        }

        return new string(sChars);
    }
}
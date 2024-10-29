namespace _75InterviewQuestion.StringCompression;

public class _443_StringCompression
{
    public int Compress(char[] chars)
    {
        var write = 0;
        var i = 0;

        while (i < chars.Length)
        {
            var currentChar = chars[i];
            var count = 0;

            while (i < chars.Length && chars[i] == currentChar)
            {
                i++;
                count++;
            }

            chars[write] = currentChar;
            write++;

            if (count <= 1) continue;
            foreach (var c in count.ToString())
            {
                chars[write] = c;
                write++;
            }
        }

        return write;
    }
}
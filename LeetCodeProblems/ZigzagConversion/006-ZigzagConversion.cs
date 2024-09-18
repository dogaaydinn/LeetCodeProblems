using System.Text;

namespace LeetCodeProblems.ZigzagConversion;

public class ZigzagConversion {
    public string Convert(string s, int numRows)
    {
        if (numRows <= 1) return s;

        var rows = new string[numRows];
        for (var i = 0; i < numRows; i++)
        {
            rows[i] = "";
        }

        var currentRow = 0;
        var direction = -1;

        foreach (char c in s)
        {
            if (currentRow == 0 || currentRow == numRows - 1)
            {
                direction *= -1; 
            }

            rows[currentRow] += c; 

            currentRow += direction;
        }

        var result = new StringBuilder();
        foreach (var row in rows)
        {
            result.Append(row);
        }

        return result.ToString();
    }
}
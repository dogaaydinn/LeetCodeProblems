using System.Text;

namespace LeetCodeProblems.ZigzagConversion;

public static class _006_ZigzagConversion
{
    /*
     Given a string s and an integer numRows, the task is to convert the string to zigzag pattern with numRows rows.
        Approach:
        1. If numRows is less than or equal to 1, return the string.
        2. Create an array of strings with numRows elements.
        3. Initialize currentRow as 0 and direction as -1.
        4. Iterate through the string.
        5. If currentRow is 0 or numRows - 1, change the direction.
        6. Append the character to the currentRow.
        7. Update the currentRow.
        8. Join the rows and return the result.

        Time complexity: O(n), where n is the length of the string.
        Space complexity: O(n)
     */
    public static string Convert(string s, int numRows)
    {
        if (numRows <= 1) return s;

        var rows = new string[numRows];
        for (var i = 0; i < numRows; i++) rows[i] = "";

        var currentRow = 0;
        var direction = -1;

        foreach (var c in s)
        {
            if (currentRow == 0 || currentRow == numRows - 1) direction *= -1;

            rows[currentRow] += c;

            currentRow += direction;
        }

        var result = new StringBuilder();
        foreach (var row in rows) result.Append(row);

        return result.ToString();
    }
}
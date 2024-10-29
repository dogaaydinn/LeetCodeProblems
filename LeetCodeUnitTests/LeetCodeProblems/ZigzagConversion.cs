using LeetCodeProblems.ZigzagConversion;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class ZigzagConversion
{
    [Fact]
    public void Convert_ReturnsCorrectZigzagString()
    {
        const string input = "PAYPALISHIRING";
        const int numRows = 3;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("PAHNAPLSIIGYIR", result);
    }
}
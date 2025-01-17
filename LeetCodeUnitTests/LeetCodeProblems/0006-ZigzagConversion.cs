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
    
    [Fact]
    public void Convert_ReturnsCorrectZigzagString1()
    {
        const string input = "PAYPALISHIRING";
        const int numRows = 4;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("PINALSIGYAHRPI", result);
    }
    
    [Fact]
    public void Convert_ReturnsCorrectZigzagString2()
    {
        const string input = "A";
        const int numRows = 1;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("A", result);
    }
    
    [Fact]
    
    public void Convert_ReturnsCorrectZigzagString3()
    {
        const string input = "AB";
        const int numRows = 1;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("AB", result);
    }
    
    [Fact]
    
    public void Convert_ReturnsCorrectZigzagString4()
    {
        const string input = "AB";
        const int numRows = 2;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("AB", result);
    }
    
    [Fact]
    
    public void Convert_ReturnsCorrectZigzagString5()
    {
        const string input = "AB";
        const int numRows = 3;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("AB", result);
    }
    
    [Fact]
    
    public void Convert_ReturnsCorrectZigzagString6()
    {
        const string input = "AB";
        const int numRows = 4;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("AB", result);
    }
    
    [Fact]
    
    public void Convert_ReturnsCorrectZigzagString7()
    {
        const string input = "ABCD";
        const int numRows = 1;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("ABCD", result);
    }
    
    [Fact]
    
    public void Convert_ReturnsCorrectZigzagString8()
    {
        const string input = "ABCD";
        const int numRows = 2;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("ACBD", result);
    }
    
    [Fact]
    
    public void Convert_ReturnsCorrectZigzagString9()
    {
        const string input = "ABCD";
        const int numRows = 3;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("ABDC", result);
    }
    
    [Fact]
    
    public void Convert_ReturnsCorrectZigzagString10()
    {
        const string input = "ABCD";
        const int numRows = 4;

        var result = _006_ZigzagConversion.Convert(input, numRows);

        Assert.Equal("ABCD", result);
    }
}
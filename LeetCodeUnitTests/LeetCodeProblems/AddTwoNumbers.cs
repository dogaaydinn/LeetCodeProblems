using LeetCodeProblems.AddTwoNumbers;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class AddTwoNumbersTests
{
    [Fact]
    public void AddTwoNumbersSolution_ReturnsCorrectSum()
    {
        var l1 = new _002_AddTwoNumbers.ListNode(2, new _002_AddTwoNumbers.ListNode(4, new _002_AddTwoNumbers.ListNode(3)));
        var l2 = new _002_AddTwoNumbers.ListNode(5, new _002_AddTwoNumbers.ListNode(6, new _002_AddTwoNumbers.ListNode(4)));
        
        var result = _002_AddTwoNumbers.AddTwoNumbersSolution(l1, l2);
        
        Assert.Equal(7, result.Val);
        Assert.Equal(0, result.Next.Val);
        Assert.Equal(8, result.Next.Next.Val);
    }

    [Fact]
    public void AddTwoNumbersSolution_ReturnsCorrectSum_WithCarry()
    {
        var l1 = new _002_AddTwoNumbers.ListNode(9, new _002_AddTwoNumbers.ListNode(9, new _002_AddTwoNumbers.ListNode(9)));
        var l2 = new _002_AddTwoNumbers.ListNode(1);

        var result = _002_AddTwoNumbers.AddTwoNumbersSolution(l1, l2);
        
        Assert.Equal(0, result.Val);
        Assert.Equal(0, result.Next.Val);
        Assert.Equal(0, result.Next.Next.Val);
        Assert.Equal(1, result.Next.Next.Next.Val);
    }
}
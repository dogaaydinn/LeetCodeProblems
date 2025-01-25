using LeetCodeProblems.JumpGame;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class JumpGameTests
{
    [Fact]
    public void TestCanJump_Example1()
    {
        // Arrange
        var nums = new int[] { 2, 3, 1, 1, 4 };
        var jumpGame = new JumpGame();

        // Act
        var result = jumpGame.CanJump(nums);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void TestCanJump_Example2()
    {
        // Arrange
        var nums = new int[] { 3, 2, 1, 0, 4 };
        var jumpGame = new JumpGame();

        // Act
        var result = jumpGame.CanJump(nums);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void TestCanJump_SingleElement()
    {
        // Arrange
        var nums = new int[] { 0 };
        var jumpGame = new JumpGame();

        // Act
        var result = jumpGame.CanJump(nums);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void TestCanJump_TwoElements()
    {
        // Arrange
        var nums = new int[] { 1, 0 };
        var jumpGame = new JumpGame();

        // Act
        var result = jumpGame.CanJump(nums);

        // Assert
        Assert.True(result);
    }

}
    
    
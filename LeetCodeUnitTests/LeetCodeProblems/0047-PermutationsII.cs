using LeetCodeProblems.PermutationsII;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class _0047_PermutationsII {
    
    [Fact]
    public void ExampleTest1()
    {
        // Arrange
        int[] nums = {1, 1, 2};
        PermutationsII permutationsII = new();

        // Act
        IList<IList<int>> actual = permutationsII.PermuteUnique(nums);

        // Assert
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1, 1, 2},
            new List<int> {1, 2, 1},
            new List<int> {2, 1, 1}
        };
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExampleTest2()
    {
        // Arrange
        int[] nums = {1, 2, 3};
        PermutationsII permutationsII = new();

        // Act
        IList<IList<int>> actual = permutationsII.PermuteUnique(nums);

        // Assert
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1, 2, 3},
            new List<int> {1, 3, 2},
            new List<int> {2, 1, 3},
            new List<int> {2, 3, 1},
            new List<int> {3, 1, 2},
            new List<int> {3, 2, 1}
        };
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    
    public void ExampleTest3()
    {
        // Arrange
        int[] nums = {1};
        PermutationsII permutationsII = new();

        // Act
        IList<IList<int>> actual = permutationsII.PermuteUnique(nums);

        // Assert
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1}
        };
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    
    public void ExampleTest4()
    {
        // Arrange
        int[] nums = {1, 1, 1};
        PermutationsII permutationsII = new();

        // Act
        IList<IList<int>> actual = permutationsII.PermuteUnique(nums);

        // Assert
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1, 1, 1}
        };
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    
    public void ExampleTest5()
    {
        // Arrange
        int[] nums = {1, 1, 1, 1};
        PermutationsII permutationsII = new();

        // Act
        IList<IList<int>> actual = permutationsII.PermuteUnique(nums);

        // Assert
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1, 1, 1, 1}
        };
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    
    public void ExampleTest6()
    {
        // Arrange
        int[] nums = {1, 2, 1};
        PermutationsII permutationsII = new();

        // Act
        IList<IList<int>> actual = permutationsII.PermuteUnique(nums);

        // Assert
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1, 1, 2},
            new List<int> {1, 2, 1},
            new List<int> {2, 1, 1}
        };
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    
    public void ExampleTest7()
    {
        // Arrange
        int[] nums = {1, 2, 2};
        PermutationsII permutationsII = new();

        // Act
        IList<IList<int>> actual = permutationsII.PermuteUnique(nums);

        // Assert
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1, 2, 2},
            new List<int> {2, 1, 2},
            new List<int> {2, 2, 1}
        };
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    
    public void ExampleTest8()
    {
        // Arrange
        int[] nums = {2, 2, 1};
        PermutationsII permutationsII = new();

        // Act
        IList<IList<int>> actual = permutationsII.PermuteUnique(nums);

        // Assert
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1, 2, 2},
            new List<int> {2, 1, 2},
            new List<int> {2, 2, 1}
        };
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    
    public void ExampleTest9()
    {
        // Arrange
        int[] nums = {2, 1, 2};
        PermutationsII permutationsII = new();

        // Act
        IList<IList<int>> actual = permutationsII.PermuteUnique(nums);

        // Assert
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1, 2, 2},
            new List<int> {2, 1, 2},
            new List<int> {2, 2, 1}
        };
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    
    public void ExampleTest10()
    {
        // Arrange
        int[] nums = {2, 1, 1};
        PermutationsII permutationsII = new();

        // Act
        IList<IList<int>> actual = permutationsII.PermuteUnique(nums);

        // Assert
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> {1, 1, 2},
            new List<int> {1, 2, 1},
            new List<int> {2, 1, 1}
        };
        Assert.Equal(expected, actual);
    }
}
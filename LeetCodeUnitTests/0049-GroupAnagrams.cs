using LeetCodeProblems.GroupAnagrams;
using Xunit;

namespace LeetCodeTests;

public class _0049_GroupAnagrams_Tests
{
    [Fact]
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var expected = new List<IList<string>>
        {
            new List<string> { "eat", "tea", "ate" },
            new List<string> { "tan", "nat" },
            new List<string> { "bat" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly2()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly3()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly4()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "a" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a", "a" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly5()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b", "c" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" },
            new List<string> { "c" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly6()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b", "c", "d" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" },
            new List<string> { "c" },
            new List<string> { "d" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly7()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b", "c", "d", "e" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" },
            new List<string> { "c" },
            new List<string> { "d" },
            new List<string> { "e" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly8()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b", "c", "d", "e", "f" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" },
            new List<string> { "c" },
            new List<string> { "d" },
            new List<string> { "e" },
            new List<string> { "f" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly9()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b", "c", "d", "e", "f", "g" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" },
            new List<string> { "c" },
            new List<string> { "d" },
            new List<string> { "e" },
            new List<string> { "f" },
            new List<string> { "g" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly10()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" },
            new List<string> { "c" },
            new List<string> { "d" },
            new List<string> { "e" },
            new List<string> { "f" },
            new List<string> { "g" },
            new List<string> { "h" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly11()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" },
            new List<string> { "c" },
            new List<string> { "d" },
            new List<string> { "e" },
            new List<string> { "f" },
            new List<string> { "g" },
            new List<string> { "h" },
            new List<string> { "i" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly12()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" },
            new List<string> { "c" },
            new List<string> { "d" },
            new List<string> { "e" },
            new List<string> { "f" },
            new List<string> { "g" },
            new List<string> { "h" },
            new List<string> { "i" },
            new List<string> { "j" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly13()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" },
            new List<string> { "c" },
            new List<string> { "d" },
            new List<string> { "e" },
            new List<string> { "f" },
            new List<string> { "g" },
            new List<string> { "h" },
            new List<string> { "i" },
            new List<string> { "j" },
            new List<string> { "k" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
    
    [Fact]
    
    public void GroupAnagrams_ShouldGroupAnagramsCorrectly14()
    {
        // Arrange
        var solution = new _0049_GroupAnagrams();
        string[] input = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l" };
        var expected = new List<IList<string>>
        {
            new List<string> { "a" },
            new List<string> { "b" },
            new List<string> { "c" },
            new List<string> { "d" },
            new List<string> { "e" },
            new List<string> { "f" },
            new List<string> { "g" },
            new List<string> { "h" },
            new List<string> { "i" },
            new List<string> { "j" },
            new List<string> { "k" },
            new List<string> { "l" }
        };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (var group in expected)
        {
            Assert.Contains(group, result);
        }
    }
}
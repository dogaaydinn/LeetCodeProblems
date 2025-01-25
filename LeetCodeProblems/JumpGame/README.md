# LeetCode Problems Solutions

This repository contains solutions to various LeetCode problems implemented in C#. Each solution is accompanied by unit tests to verify its correctness.

## Solutions

### Spiral Matrix

**Problem:** Given a matrix, return all elements of the matrix in spiral order.

**Solution:** The `SpiralMatrix` class contains the `SpiralOrder` method which implements a boundary-based approach to traverse the matrix in spiral order.

**Code:**

```csharp

namespace LeetCodeProblems.SpiralMatrix;

public class SpiralMatrix

{

    public IList<int> SpiralOrder(int[][] matrix)

    {

        var result = new List<int>();

        if (matrix == null || matrix.Length == 0) return result;

        int top = 0, bottom = matrix.Length - 1;

        int left = 0, right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)

        {

            for (int i = left; i <= right; i++)

                result.Add(matrix[top][i]);

            top++;

            for (int i = top; i <= bottom; i++)

                result.Add(matrix[i][right]);

            right--;

            if (top <= bottom)

            {

                for (int i = right; i >= left; i--)

                    result.Add(matrix[bottom][i]);

                bottom--;

            }

            if (left <= right)

            {

                for (int i = bottom; i >= top; i--)

                    result.Add(matrix[i][left]);

                left++;

            }

        }

        return result;

    }

}

```

**Unit Tests:**

```csharp

using LeetCodeProblems.SpiralMatrix;

using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class SpiralMatrixTests

{

    [Fact]

    public void TestSpiralOrder_Example1()

    {

        var matrix = new int[][]

        {

            new int[] { 1, 2, 3 },

            new int[] { 4, 5, 6 },

            new int[] { 7, 8, 9 }

        };

        var expected = new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

        var spiralMatrix = new SpiralMatrix();

        var result = spiralMatrix.SpiralOrder(matrix);

        Assert.Equal(expected, result);

    }

    [Fact]

    public void TestSpiralOrder_Example2()

    {

        var matrix = new int[][]

        {

            new int[] { 1, 2, 3, 4 },

            new int[] { 5, 6, 7, 8 },

            new int[] { 9, 10, 11, 12 }

        };

        var expected = new List<int> { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };

        var spiralMatrix = new SpiralMatrix();

        var result = spiralMatrix.SpiralOrder(matrix);

        Assert.Equal(expected, result);

    }

    [Fact]

    public void TestSpiralOrder_EmptyMatrix()

    {

        var matrix = new int[][] { };

        var expected = new List<int> { };

        var spiralMatrix = new SpiralMatrix();

        var result = spiralMatrix.SpiralOrder(matrix);

        Assert.Equal(expected, result);

    }

}

```

### Jump Game

**Problem:** Given an integer array `nums`, determine if you can reach the last index starting from the first index.

**Solution:** The `JumpGame` class contains the `CanJump` method which uses a greedy algorithm to track the farthest index that can be reached.

**Code:**

```csharp

namespace LeetCodeProblems.JumpGame;

public class JumpGame

{

    public bool CanJump(int[] nums)

    {

        int maxReach = 0;

        for (int i = 0; i < nums.Length; i++)

        {

            if (i > maxReach) return false;

            maxReach = Math.Max(maxReach, i + nums[i]);

        }

        return maxReach >= nums.Length - 1;

    }

}

```

**Unit Tests:**

```csharp

using LeetCodeProblems.JumpGame;

using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class JumpGameTests

{

    [Fact]

    public void TestCanJump_Example1()

    {

        var nums = new int[] { 2, 3, 1, 1, 4 };

        var jumpGame = new JumpGame();

        var result = jumpGame.CanJump(nums);

        Assert.True(result);

    }

    [Fact]

    public void TestCanJump_Example2()

    {

        var nums = new int[] { 3, 2, 1, 0, 4 };

        var jumpGame = new JumpGame();

        var result = jumpGame.CanJump(nums);

        Assert.False(result);

    }

    [Fact]

    public void TestCanJump_SingleElement()

    {

        var nums = new int[] { 0 };

        var jumpGame = new JumpGame();

        var result = jumpGame.CanJump(nums);

        Assert.True(result);

    }

    [Fact]

    public void TestCanJump_TwoElements()

    {

        var nums = new int[] { 1, 0 };

        var jumpGame = new JumpGame();

        var result = jumpGame.CanJump(nums);

        Assert.True(result);

    }

}

```

## Running Tests

To run the unit tests, use the following command:

```sh

dotnet test

```

## License

This project is licensed under the MIT License.

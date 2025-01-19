# Rotate Image (LeetCode 48)

This project contains a C# solution for the LeetCode problem **48. Rotate Image**. The task is to rotate a given \( n \times n \) 2D matrix by 90 degrees clockwise in-place.

## Problem Description

Given an \( n \times n \) 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

You must rotate the image in-place, which means you have to modify the input 2D matrix directly. **DO NOT** allocate another 2D matrix and perform the rotation.

**Example:**

- **Input:** [ [1, 2, 3], [4, 5, 6], [7, 8, 9] ]

- **Output:** [ [7, 4, 1], [8, 5, 2], [9, 6, 3] ]


## Approach

The solution rotates the matrix in two main steps:

1. **Transpose the Matrix:**
 - Swap `matrix[i][j]` with `matrix[j][i]` for every element above (or below) the main diagonal.
2. **Reverse Each Row:**
 - Reverse each row of the transposed matrix to obtain the final rotated matrix.

This approach achieves the rotation in-place with a time complexity of \(O(n^2)\) and a constant space complexity, \(O(1)\).

## Code Structure

### _0048_RotateImage.cs
	
	```csharp
	namespace LeetCodeProblems.RotateImage;

	public class _0048_RotateImage

  	public void Rotate(int[][] matrix)
  	{
     	 var n = matrix.Length;

  
      	for (var i = 0; i < n; i++)
      	{
       	   for (var j = i + 1; j < n; j++)
        	  {
           	   (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
         	 }
      	}

     	 for (var i = 0; i < n; i++)
     	 {
      	    Array.Reverse(matrix[i]);
      	}
 	 }
	}
Running the Application
-----------------------

### Building the Project

Use the .NET CLI to build the project:


`dotnet build`

### Running the Code

If you have a console application or a test project set up, you can run the solution as follows:


`dotnet run`

For debugging or integration within a larger solution, simply call the `Rotate` method with a properly initialized n×nn \times nn×n matrix.

Unit Testing
------------

You can write unit tests using your preferred testing framework (e.g., xUnit, MSTest, or NUnit). Below is an example using xUnit:

	```csharp


	using LeetCodeProblems.RotateImage;
	using Xunit;

	namespace LeetCodeTests.LeetCodeProblems
	{
  	  public class RotateImageTests
  	  {
     	   [Fact]
          public void Rotate_3x3Matrix_RotatesCorrectly()
          {
         
          	  var rotateImage = new _0048_RotateImage();
           	 int[][] matrix = new int[][] {
           	     new int[] { 1, 2, 3 },
           	     new int[] { 4, 5, 6 },
            	    new int[] { 7, 8, 9 }
            	};

           	 int[][] expected = new int[][] {
           	     new int[] { 7, 4, 1 },
            	    new int[] { 8, 5, 2 },
                	new int[] { 9, 6, 3 }
            	};

         
            	rotateImage.Rotate(matrix);

  
           	 for (int i = 0; i < matrix.Length; i++)
            	{
            	    Assert.Equal(expected[i], matrix[i]);
            	}
        	}
    	}
	}`

Run your tests with the following command:


`dotnet test`

Complexity Analysis
-------------------

-   **Time Complexity:** O(n2)O(n^2)O(n2) --- Both the transposition and the row reversal steps involve iterating over the entire matrix.
-   **Space Complexity:** O(1)O(1)O(1) --- The matrix is rotated in-place without using extra space.

Conclusion
----------

This project implements an efficient in-place solution for rotating an n×nn \times nn×n matrix by 90 degrees clockwise. The method of transposing followed by row reversal provides a clean and optimal approach to the problem.


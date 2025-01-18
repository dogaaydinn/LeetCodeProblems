# Permutations II

This project provides a C# solution for the LeetCode problem **47. Permutations II**. 
The goal is to generate all unique permutations of a given array of integers, especially taking into account duplicate values.

## Problem Description

Given an array `nums` of numbers that might contain duplicates, return all possible unique permutations. The solution should not contain duplicate permutations.

**Example:**

- **Input:** `nums = [1, 1, 2]`
- **Output:**   [ [1, 1, 2], [1, 2, 1], [2, 1, 1] ]

## Approach

The solution uses a backtracking approach similar to the one for the Permutations problem with an additional check to handle duplicates:

1. **Sorting:**  
 The input array is sorted so that duplicate elements are adjacent. This makes it easier to skip over duplicates later in the backtracking process.

2. **Tracking Usage:**  
 A boolean array is used to keep track of which elements have already been used in the current permutation.

3. **Backtracking:**  
 - A recursive `Backtrack` function is implemented to build permutations.
 - When the current permutation’s length equals the length of `nums`, the permutation is added to the result list.
 - During each recursive call, if the current element is already used, or if it is equal to the previous element and the previous element has not been used, the element is skipped to avoid duplicate permutations.

## Code Structure

### PermutationsII.cs


	```csharp
	namespace LeetCodeProblems.PermutationsII;

	public class PermutationsII
	{

 	 public IList<IList<int>> PermuteUnique(int[] nums)
  	{
      var results = new List<IList<int>>();
      Array.Sort(nums);
      Backtrack(nums, new bool[nums.Length], new List<int>(), results);
      return results;
	  }

 	 private void Backtrack(int[] nums, bool[] used, List<int> current, List<IList<int>> results)
  	{
      if (current.Count == nums.Length)
      {
          results.Add(new List<int>(current));
          return;
      }

      for (var i = 0; i < nums.Length; i++)
      {
         
          if (used[i] || (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]))
          {
              continue;
          }

          used[i] = true;
          current.Add(nums[i]);
          Backtrack(nums, used, current, results);
          used[i] = false;
          current.RemoveAt(current.Count - 1);
      }
  }
}
Running the Application
-----------------------

### Building the Project

Use the .NET CLI to build the project:
		
	`dotnet build`

### Running the Application

If you have set this up as a console application, you can run it using:


	`dotnet run`

### Unit Tests

The project includes unit tests using the xUnit framework. To run the tests, use the following command:


`dotnet test`

Here's an example test class for verifying the unique permutations:
  
	```csharp  
	using LeetCodeProblems.PermutationsII;
	using Xunit;
	using System.Collections.Generic;
	using System.Linq;

	namespace LeetCodeTests.LeetCodeProblems
	{
  	  public class PermutationsIITests
   	 {
      	  [Fact]
       	 public void PermuteUnique_Example1_ReturnsExpectedPermutations()
       	 {
          
           	 var solver = new PermutationsII();
           	 int[] input = new int[] { 1, 1, 2 };
            	var expected = new List<IList<int>>
            	{
               	 new List<int>{1, 1, 2},
               	 new List<int>{1, 2, 1},
               	 new List<int>{2, 1, 1}
            	};

            
            	var result = solver.PermuteUnique(input);

       
            	Assert.Equal(expected.Count, result.Count);

            	
            	foreach (var perm in expected)
            	{
             	   Assert.Contains(result, r => r.SequenceEqual(perm));
            	}
        	}
    	}
	}

Complexity Analysis
-------------------

-   **Time Complexity:**\
    In the worst case, the time complexity is O(N×N!)O(N \times N!)O(N×N!) because we generate N!N!N! permutations and each permutation construction takes O(N).

-   **Space Complexity:**\
    The space complexity is O(N×N!)O(N \times N!)O(N×N!), as we store each permutation which is of size N.

Conclusion
----------

This project implements a backtracking approach to solve the **Permutations II** problem, carefully handling duplicates to ensure that only unique permutations are generated. Feel free to extend the tests or modify the code according to your project requirements.
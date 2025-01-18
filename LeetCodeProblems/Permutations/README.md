# Permutations (LeetCode 46)

This project provides a C# solution for the LeetCode problem **46. Permutations**. The goal is to generate all possible permutations of a given array of integers using a backtracking approach.

## Problem Description

Given an array of distinct integers `nums`, return all possible permutations.

**Example:**

- **Input:** `nums = [1, 2, 3]`
- **Output:** [ [1,2,3], [1,3,2], [2,1,3], [2,3,1], [3,1,2], [3,2,1] ]


## Approach

The solution uses backtracking to generate all possible permutations:

1. **Backtracking Strategy:**
 - We define a recursive function `Backtrack` that builds a permutation incrementally.
 - If the current permutation's size equals the length of the input array, a complete permutation is formed and added to the result list.
 - Otherwise, iterate over all numbers in the input array:
   - If a number is not already in the current permutation, add it and recursively call `Backtrack` with the updated permutation.
   - After the recursion, remove the last element (backtrack) to explore other possibilities.

2. **Time and Space Complexity:**
 - **Time Complexity:** \(O(n! \times n)\) — Since there are \(n!\) permutations and each permutation requires \(O(n)\) time to construct.
 - **Space Complexity:** \(O(n)\) for the recursion call stack and current permutation list.

## Code Structure

### _0046_Permutations.cs

	```csharp
	
    namespace LeetCodeProblems.Permutations;

	public class _0046_Permutations {

     
  	public IList<IList<int>> Permute(int[] nums) {
      	var result = new List<IList<int>>();
      	Backtrack(nums, new List<int>(), result);
      	return result;
  	}

 	 private void Backtrack(int[] nums, List<int> current, List<IList<int>> result)
 	 {
     	 if (current.Count == nums.Length) {
       	   result.Add(new List<int>(current));
        	  return;
     	 }

     	 foreach (var t in nums)
      	{
       	   if (current.Contains(t)) continue;
        	  current.Add(t);
         	 Backtrack(nums, current, result);
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

If the project is set up as a console application, you can run it using:

`dotnet run`

Unit Tests
----------

Unit tests can be written using the xUnit framework to verify the correctness of the permutations algorithm. An example test class is provided below:

	```csharp

	`using LeetCodeProblems.Permutations;
	using Xunit;
	using System.Collections.Generic;
	using System.Linq;

	namespace LeetCodeTests.LeetCodeProblems
	{
      public class PermutationsTests
   	 {
       	 [Fact]
       	 public void Permute_Example_ReturnsExpectedPermutations()
       	 {
      
        	    var solver = new _0046_Permutations();
          	  int[] input = new int[] { 1, 2, 3 };

         
          	  var expected = new List<IList<int>>
           	 {
               	 new List<int>{1, 2, 3},
               	 new List<int>{1, 3, 2},
               	 new List<int>{2, 1, 3},
               	 new List<int>{2, 3, 1},
               	 new List<int>{3, 1, 2},
               	 new List<int>{3, 2, 1}
           	 };

         
            	var result = solver.Permute(input);

            
            	Assert.Equal(expected.Count, result.Count);
           	 foreach (var perm in expected)
           	 {
            	    Assert.Contains(result, r => r.SequenceEqual(perm));
            	}
       	 }
   	 }
	}`

To run the tests, use the following command:

`dotnet test`

Conclusion
----------

This project implements a backtracking approach to solve the **Permutations** problem (LeetCode 46) by generating all possible orders of the input numbers. The solution is efficient for small to moderately-sized inputs and demonstrates clear recursive problem-solving techniques.


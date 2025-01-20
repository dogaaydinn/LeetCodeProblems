# Group Anagrams (LeetCode 49)

This project contains a C# solution for the LeetCode problem **49. Group Anagrams**. 
The goal is to group a list of strings into sets of anagrams.

## Problem Description

Anagrams are words or phrases made by rearranging the letters of another word or phrase, using all the original letters exactly once. Given an array of strings, group the anagrams together.

**Example:**

- **Input:** strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
- **Output:** [ ["eat","tea","ate"], ["tan","nat"], ["bat"] ]


Note that the order of the output does not matter.

## Approach

The solution uses the following strategy:

1\. **Sorting as a Key:**

 - For each string, sort its characters. Anagrams will result in the same sorted string.

2\. **Dictionary Mapping:**

 - Use a dictionary where the key is the sorted string and the value is a list of strings (anagrams) corresponding to that key.

3\. **Grouping:**

 - Iterate over each word in the input array, compute its sorted key, then add the original string to the dictionary under that key.

4\. **Return Result:**

 - Finally, return the values of the dictionary as a list of lists.

## Complexity Analysis

- **Time Complexity:**  

Let \( n \) be the number of words and \( k \) be the maximum length of a word.  

Sorting each word takes \( O(k \log k) \). Since we process each word, the total time complexity is \( O(n \times k \log k) \).

- **Space Complexity:**  

The space is used to store all anagrams in the dictionary, which is \( O(n \times k) \) in the worst case.

## Code Structure

### _0049_GroupAnagrams.cs

	```csharp

	namespace LeetCodeProblems.GroupAnagrams;

	public class _0049_GroupAnagrams

	{

  	public IList<IList<string>> GroupAnagrams(string[] strs)

  	{

     	 var anagrams = new Dictionary<string, List<string>>();

     	 foreach (var str in strs)

     	 {

        	  var sortedStr = new string(str.OrderBy(c => c).ToArray());

        	  if (!anagrams.ContainsKey(sortedStr))

         	 {

              	anagrams[sortedStr] = new List<string>();

        	  }

         	 anagrams[sortedStr].Add(str);

     	 }

     	 return anagrams.Values.ToList<IList<string>>();

 	 }

	}
    
 Running the Application
-----------------------

### Building the Project

Use the .NET CLI to build the project:


`dotnet build`

### Running the Code

If integrated into a console application or test suite, simply call the `GroupAnagrams` method with an input array of strings.

Unit Testing
------------

Below is an example unit test class using the xUnit framework to verify the correctness of the implementation:
	
    ```csharp

	using LeetCodeProblems.GroupAnagrams;

	using Xunit;

	using System.Collections.Generic;

	using System.Linq;

	namespace LeetCodeTests.LeetCodeProblems
	
	{

	    public class GroupAnagramsTests

	    {

   	     [Fact]

       	 public void GroupAnagrams_Example_ReturnsExpectedGrouping()

       	 {


         	   var solver = new _0049_GroupAnagrams();

          	  string[] input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };


           	 var result = solver.GroupAnagrams(input);


            	var expectedGroups = new List<IList<string>>

          	  {

               	 new List<string> { "eat", "tea", "ate" },

               	 new List<string> { "tan", "nat" },

               	 new List<string> { "bat" }

           	 };


            	foreach (var expectedGroup in expectedGroups)

            	{

             	   Assert.Contains(result, group => group.OrderBy(s => s).SequenceEqual(expectedGroup.OrderBy(s => s)));

            	}

       	 }

   	 }

	}
    
    
    
    
 Run the unit tests using:


`dotnet test`

Conclusion
----------

This project implements a straightforward and efficient solution for grouping anagrams by using sorted strings as keys. 
Its time complexity is O(n×klog⁡k)O(n \times k \log k)O(n×klogk) and 
it uses only O(n×k)O(n \times k)O(n×k) additional space.

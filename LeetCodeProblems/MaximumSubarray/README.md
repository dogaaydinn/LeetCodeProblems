Maximum Subarray Solution
=========================

This repository contains a C# implementation of the Maximum Subarray problem, commonly known as Kadane's Algorithm. The solution efficiently finds the contiguous subarray within a one-dimensional array of numbers that has the largest sum.

Problem Statement
-----------------

Given an integer array `nums`, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

**Example:**


`Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum = 6.`

Solution Overview
-----------------

The problem is solved using **Kadane's Algorithm**, which operates in linear time. The algorithm maintains two variables:

-   `maxSoFar`: The maximum sum of any subarray found so far.
-   `maxEndingHere`: The maximum sum of a subarray ending at the current index.

By iterating through the array and updating these variables, the algorithm efficiently finds the maximum subarray sum.

### Approach

1.  **Initialization**:

    -   Set `maxSoFar` and `maxEndingHere` to the first element of the array.
2.  **Iteration**:

    -   For each element in the array (starting from the second element), update `maxEndingHere` to be the maximum of the current element and the sum of the current element with `maxEndingHere`.
    -   Update `maxSoFar` to be the maximum of `maxSoFar` and `maxEndingHere`.
3.  **Result**:

    -   After iterating through the array, `maxSoFar` will hold the maximum subarray sum.

### Time and Space Complexity

-   **Time Complexity**: O(n), where n is the length of the input array.
-   **Space Complexity**: O(1), as only a constant amount of extra space is used.

Usage
-----

### Prerequisites

-   .NET Core SDK installed on your machine.

### Running the Solution

1.  **Clone the Repository**


    `git clone https://github.com/your-username/MaximumSubarray.git
    cd MaximumSubarray`

2.  **Build the Project**

    Navigate to the project directory and build the solution:


    `dotnet build`

3.  **Run the Solution**

    You can create a test harness or use the following example to run the solution:

    csharp



    `using LeetCodeProblems.MaximumSubarray;

    class Program
    {
        static void Main(string[] args)
        {
            var solution = new MaximumSubarray();
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxSum = solution.MaxSubArray(nums);
            Console.WriteLine($"Maximum Subarray Sum: {maxSum}");
        }
    }`

    
   Compile and run the program:


    `dotnet run`

    **Output:**

    `Maximum Subarray Sum: 6`

Code Explanation
----------------


```csharp


	
    public class MaximumSubarray
    {
        /*
         Intution:
            - We can solve this problem using Kadane's algorithm.
            - We will keep track of two variables maxSoFar and maxEndingHere.
            - maxSoFar will keep track of the maximum sum of subarray so far.
            - maxEndingHere will keep track of the maximum sum of subarray ending at the current index.
            - We will iterate through the array and update the maxEndingHere and maxSoFar.
            - Finally, we will return maxSoFar.

            APPROACH:
            - Initialize maxSoFar and maxEndingHere with the first element of the array.
            - Iterate through the array starting from the second element.
            - Update maxEndingHere with the maximum of the current element and the sum of the current element and maxEndingHere.
            - Update maxSoFar with the maximum of maxSoFar and maxEndingHere.
            - Return maxSoFar.

            TIME COMPLEXITY:
            - O(n) where n is the length of the input array.

            SPACE COMPLEXITY:
            - O(1)
         */
      
        public int MaxSubArray(int[] nums)
        {
            var maxSoFar = nums[0];
            var maxEndingHere = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
    }


-   **Namespace**: `LeetCodeProblems.MaximumSubarray`
-   **Class**: `MaximumSubarray`
-   **Method**: `MaxSubArray(int[] nums)`
    -   Implements Kadane's Algorithm to find the maximum subarray sum.
    -   Initializes `maxSoFar` and `maxEndingHere` with the first element.
    -   Iterates through the array, updating the variables based on the current element.
    -   Returns the maximum subarray sum found.

Contributing
------------

Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

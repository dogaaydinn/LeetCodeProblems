Problem Statement
-----------------

Given an array of intervals where each interval is represented as a pair of integers `[start, end]`, merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

### Example

**Input:** `[[1,3],[2,6],[8,10],[15,18]]`\
**Output:** `[[1,6],[8,10],[15,18]]`\
**Explanation:** Since intervals `[1,3]` and `[2,6]` overlap, merge them into `[1,6]`.

Solution
--------

The `MergeIntervals` class provides a method `Merge` that takes a list of intervals and returns a new list where all overlapping intervals have been merged. The approach is as follows:

1.  **Sorting:**

    -   Sort the intervals based on their start times. This ensures that overlapping intervals are adjacent, making it easier to merge them sequentially.
2.  **Merging:**

    -   Initialize a list to hold the merged intervals.
    -   Iterate through each interval:
        -   If the current interval overlaps with the last interval in the merged list (i.e., the start of the current interval is less than or equal to the end of the last merged interval), merge them by updating the end of the last merged interval to the maximum end value.
        -   If there's no overlap, simply add the current interval to the merged list.
3.  **Result:**

    -   Return the merged list as an array of intervals.

### Time and Space Complexity

-   **Time Complexity:**

    -   Sorting takes O(nlog⁡n)O(n \log n)O(nlogn) time.
    -   The merging process takes O(n)O(n)O(n) time.
    -   Overall, the time complexity is O(nlog⁡n)O(n \log n)O(nlogn).
-   **Space Complexity:**

    -   The space required for the merged list is O(n)O(n)O(n) in the worst case when no intervals overlap.



Technologies Used
-----------------

-   **.NET 6.0 or later**: The project is built using the .NET framework.
-   **C#**: The primary programming language used.
-   **xUnit**: A free, open-source, community-focused unit testing tool for the .NET Framework.

Installation
------------

### Prerequisites

-   **.NET SDK**: Ensure that you have the .NET SDK installed. You can download it from the [.NET Downloads](https://dotnet.microsoft.com/download) page.
-   **IDE/Text Editor**: Visual Studio, Visual Studio Code, or any other preferred IDE/text editor.


**Output:**

csharp

Kopyala

`[1, 6]
[8, 10]
[15, 18]`

### Running the Application

1.  **Navigate to the Project Directory:**

    bash

    Kopyala

    `cd MergeIntervals`

2.  **Build the Project:**

    bash

    Kopyala

    `dotnet build`

3.  **Run the Application:**

    If you have a `Main` method to execute, you can run the project using:

    bash

    Kopyala

    `dotnet run --project MergeIntervals/MergeIntervals.csproj`

Running Tests
-------------

The `MergeIntervalsTests` project contains a comprehensive suite of unit tests to verify the correctness of the `Merge` method under various scenarios.

### Execute Tests Using the .NET CLI

1.  **Navigate to the Test Project Directory:**


    `cd MergeIntervalsTests`

2.  **Run the Tests:**


    `dotnet test`

    This command will build both the main project and the test project, then execute all the tests, providing a summary of the results.

### Understanding the Tests

The tests cover a wide range of scenarios, including but not limited to:

-   **Empty Input:** Verifies that the method returns an empty array when given no intervals.
-   **Single Interval:** Ensures that a single interval is returned as-is.
-   **No Overlapping Intervals:** Checks that non-overlapping intervals are returned in sorted order.
-   **All Overlapping Intervals:** Ensures that all intervals are merged into a single interval.
-   **Some Overlapping Intervals:** Verifies correct merging when only some intervals overlap.
-   **Unsorted Intervals:** Confirms that the method correctly sorts intervals before merging.
-   **Intervals with Same Start or End:** Tests merging behavior when multiple intervals share the same start or end points.
-   **Negative Numbers:** Ensures that intervals with negative values are handled correctly.
-   **Large Number of Intervals:** Assesses the performance and correctness with a large dataset.
-   **Identical Start and End Points:** Checks the behavior when multiple intervals have identical start and end points.

Contributing
------------

Contributions are welcome! If you have suggestions, improvements, or bug fixes, feel free to open an issue or submit a pull request.



N-Queens Problem Solution in C#
===============================

Overview
--------

This repository contains a C# solution to the classic N-Queens problem as presented in LeetCode Problem 51. The solution employs a backtracking algorithm to efficiently find all possible distinct solutions to placing `n` queens on an `n×n` chessboard such that no two queens threaten each other.

Problem Description
-------------------

The N-Queens problem is the challenge of placing `n` queens on an `n×n` chessboard so that no two queens can attack each other. This means that no two queens share the same row, column, or diagonal.

### Example

**Input:** `n = 4`

**Output:**

[ [".Q..",  "...Q",  "Q...",  "..Q."],

 ["..Q.",  "Q...",  "...Q",  ".Q.."]
]

Solution
--------

The solution utilizes backtracking to explore all possible placements of queens row by row. To efficiently check for conflicts, three hash sets are maintained:

-   **Columns (`columns`)**: Tracks which columns are already occupied by queens.
-   **Diagonal 1 (`diagonals1`)**: Tracks the difference `row - col` to identify major diagonals.
-   **Diagonal 2 (`diagonals2`)**: Tracks the sum `row + col` to identify minor diagonals.

By checking these sets before placing a queen, the algorithm ensures that no two queens threaten each other.

### Code Structure

-   **`SolveNQueens(int n)`**: The main method that initiates the backtracking process and returns all valid board configurations.
-   **`Backtrack(int row)`**: A helper method that attempts to place a queen in each row recursively.
-   **`BuildBoard(int[] queens, int n)`**: Constructs the visual representation of the board from the positions of the queens.

Usage
-----

### Prerequisites

-   [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Running the Solution

1.  **Clone the Repository**

    `git clone https://github.com/your-username/N-Queens-CSharp.git
    cd N-Queens-CSharp`

2.  **Build the Project**

    `dotnet build`

3.  **Run the Solution** You can integrate the `_0051_N_Queens` class into your project or write a simple test harness. Here's an example of how to use it:


    `using LeetCodeProblems.N_Queens;

    class Program
    {
        static void Main(string[] args)
        {
            var solver = new _0051_N_Queens();
            int n = 4;
            var solutions = solver.SolveNQueens(n);

            Console.WriteLine($"Total solutions for n={n}: {solutions.Count}");
            foreach (var solution in solutions)
            {
                foreach (var row in solution)
                {
                    Console.WriteLine(row);
                }
                Console.WriteLine();
            }
        }
    }`

4.  **Execute the Program**


    `dotnet run`

### Sample Output


`Total solutions for n=4: 2
.Q..
...Q
Q...
..Q.

..Q.
Q...
...Q
.Q..`

Explanation
-----------

The algorithm works by attempting to place a queen in each row, ensuring that no two queens share the same column or diagonal. If a valid position is found, the algorithm proceeds to the next row. If it reaches a state where no valid positions are available, it backtracks to the previous row to try alternative positions.

This approach guarantees that all possible valid configurations are explored and collected.

Complexity Analysis
-------------------

-   **Time Complexity:** O(N!), where N is the number of queens. This is because there are N choices for the first queen, N-1 for the second, and so on.

-   **Space Complexity:** O(N), due to the recursion stack and the storage used for tracking columns and diagonals.

Contributing
------------

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

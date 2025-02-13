Count and Say - LeetCode Problem 38
===================================

Problem Description
-------------------

The **Count and Say** sequence is a sequence of strings defined by the following rules:

1. The first term is `"1"`.
2. Each subsequent term is generated by describing the previous term:
    - Count the number of times each digit appears in groups and append the count followed by the digit.

For example:

- Term 1: `"1"`
- Term 2: `"11"` (One `1`)
- Term 3: `"21"` (Two `1`s)
- Term 4: `"1211"` (One `2`, One `1`)
- Term 5: `"111221"` (One `1`, One `2`, Two `1`s)

The task is to return the `n`th term of the sequence.

* * * * *

Solution Explanation
--------------------

### Approach:

1. Start with the first term (`"1"`) as the initial sequence.
2. For each iteration from `2` to `n`, generate the next sequence by:
    - Iterating through the current sequence.
    - Counting consecutive identical characters.
    - Appending the count followed by the character to build the next sequence.
3. Return the final sequence after iterating `n` times.

* * * * *

### Code:

```
using System.Text;

namespace LeetCodeProblems.CountAndSay;

public class _38_CountAndSay
{
    public string CountAndSay(int n)
    {
        if (n == 1) return "1";

        var result = "1";
        for (var i = 2; i <= n; i++) result = GetNextSequence(result);
        return result;
    }

    private string GetNextSequence(string sequence)
    {
        var nextSequence = new StringBuilder();
        var count = 1;
        var currentChar = sequence[0];

        for (var i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] == currentChar)
            {
                count++;
            }
            else
            {
                nextSequence.Append(count).Append(currentChar);
                currentChar = sequence[i];
                count = 1;
            }
        }

        nextSequence.Append(count).Append(currentChar);
        return nextSequence.ToString();
    }
}

```

* * * * *

Complexity Analysis
-------------------

**Time Complexity**:

- **O(n * m)**:
    - `n` is the input number, representing the number of terms to generate.
    - `m` is the average length of the sequences. Each sequence generation involves iterating through the previous
      sequence.

**Space Complexity**:

- **O(m)**:
    - `m` is the maximum length of the sequence, which is stored in a `StringBuilder` for intermediate results.

* * * * *

Example Usage:
--------------

### Input:

```
n = 5

```

### Output:

```
"111221"

```

### Explanation:

1. Term 1: `"1"`
2. Term 2: `"11"` (One `1`)
3. Term 3: `"21"` (Two `1`s)
4. Term 4: `"1211"` (One `2`, One `1`)
5. Term 5: `"111221"` (One `1`, One `2`, Two `1`s)

* * * * *

Notes:
------

- The `StringBuilder` class is used for efficient string manipulation.
- The algorithm builds each term iteratively, ensuring that the sequence is generated correctly.
- This approach handles up to the constraints of the problem effectively.
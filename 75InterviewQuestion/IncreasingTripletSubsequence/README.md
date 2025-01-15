# Problem: 334. Increasing Triplet Subsequence

## Description:
Given an integer array `nums`, determine whether there exists a triple of indices `(i, j, k)` such that

If such indices exist, return `true`. Otherwise, return `false`.

## Approach:
To solve this problem efficiently:

1. **Initialization:**
   - Initialize two variables `first` and `second` to `int.MaxValue`.

2. **Iterate Through the Array:**
   - For each number in the array:
     - If the current number is less than or equal to `first`, update `first` to the current number.
     - Otherwise, if the current number is less than or equal to `second`, update `second` to the current number.
     - Otherwise, if the current number is greater than `second`, an increasing triplet is found, so return `true`.

3. **Return Result:**
   - If no increasing triplet is found during the iteration, return `false`.

### Complexity Analysis:
- **Time Complexity:** O(n), where `n` is the length of the array. Each element is processed once.
- **Space Complexity:** O(1), as no additional data structures are used.

## Code Implementation:
```csharp
namespace _75InterviewQuestion.IncreasingTripletSubsequence;

public class _334_IncreasingTripletSubsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        var first = int.MaxValue;
        var second = int.MaxValue;

        foreach (var num in nums)
            if (num <= first)
                first = num;
            else if (num <= second)
                second = num;
            else
                return true;

        return false;
    }
}
```

## Examples:

### Example 1:
**Input:**
```plaintext
nums = [1, 2, 3, 4, 5]
```
**Output:**
```plaintext
true
```
**Explanation:**
The increasing triplet subsequence is `1, 2, 3`.

### Example 2:
**Input:**
```plaintext
nums = [5, 4, 3, 2, 1]
```
**Output:**
```plaintext
false
```
**Explanation:**
No increasing triplet subsequence exists.

### Example 3:
**Input:**
```plaintext
nums = [2, 1, 5, 0, 4, 6]
```
**Output:**
```plaintext
true
```
**Explanation:**
The increasing triplet subsequence is `1, 4, 6`.

## Edge Cases:
1. **Empty Array:**
   - Input: `nums = []`
   - Output: `false`

2. **Single Element:**
   - Input: `nums = [1]`
   - Output: `false`

3. **Two Elements:**
   - Input: `nums = [1, 2]`
   - Output: `false`

4. **Duplicates:**
   - Input: `nums = [1, 1, 1, 1]`
   - Output: `false`

5. **Multiple Triplets:**
   - Input: `nums = [1, 2, 3, 4, 5, 6]`
   - Output: `true`

## Notes:
This solution effectively tracks the smallest and second smallest elements in the array. If a number greater than both is found, it guarantees the existence of an increasing triplet subsequence.



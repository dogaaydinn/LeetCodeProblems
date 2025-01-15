# Problem: 15. 3Sum

The problem requires finding all unique triplets in the array that sum up to zero. Each triplet should be a combination of three numbers from the array, and no duplicate triplets are allowed.

## Approach: Two Pointers with Sorting

### Steps:
1. **Sort the Array:**
   - Sort the input array `nums` in ascending order.
   - This helps efficiently manage the search for triplets using a two-pointer approach.

2. **Iterate through the Array:**
   - Loop through the array with an index `i` starting from 0.
   - Skip duplicate elements for `nums[i]` to ensure unique triplets.

3. **Two Pointers:**
   - Use two pointers `left` and `right` to find the remaining two numbers such that their sum with `nums[i]` equals zero.
   - If the sum is less than zero, increment `left`.
   - If the sum is greater than zero, decrement `right`.
   - If the sum is zero, store the triplet in the result and skip duplicates for both `left` and `right` pointers.

4. **Repeat Until All Triplets are Found:**
   - Continue the process until `left` and `right` pointers meet.

5. **Return the Result:**
   - Return the list of all unique triplets.

### Complexity Analysis:
- **Time Complexity:** O(n²)
  - Sorting the array takes O(n log n).
  - The two-pointer approach iterates through the array, leading to O(n²) in total.
- **Space Complexity:** O(log n) or O(n)
  - Sorting requires O(log n) for in-place sorting or O(n) for external sorting.

## Code Implementation

```csharp
namespace LeetCodeProblems._3Sum;

public class _15_3Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                switch (sum)
                {
                    case 0:
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) left++;

                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                        break;
                    }
                    case < 0:
                        left++;
                        break;
                    default:
                        right--;
                        break;
                }
            }
        }

        return result;
    }
}
```

## Example

### Input:
```plaintext
nums = [-1, 0, 1, 2, -1, -4]
```

### Output:
```plaintext
[[-1, -1, 2], [-1, 0, 1]]
```

### Explanation:
- The array is sorted as `[-4, -1, -1, 0, 1, 2]`.
- Triplet `[-1, -1, 2]` sums to zero.
- Triplet `[-1, 0, 1]` sums to zero.
- No duplicates are included in the result.

## Edge Cases:
1. **Empty Array:**
   - Input: `nums = []`
   - Output: `[]`

2. **Array with Less than 3 Elements:**
   - Input: `nums = [1, 2]`
   - Output: `[]`

3. **No Triplets Found:**
   - Input: `nums = [1, 2, -2, -1]`
   - Output: `[]`

## References:
- [LeetCode Problem #15](https://leetcode.com/problems/3sum/)

# Problem: 42. Trapping Rain Water

The problem requires calculating the total amount of water that can be trapped between the heights of bars represented
by an array. Each element in the array represents the height of a bar at that index, and the width of each bar is 1.

## Approach: Two Pointers

### Steps:

1. **Initialize Pointers and Variables:**
    - Use two pointers `left` and `right` starting at the beginning and end of the array, respectively.
    - Maintain two variables, `leftMax` and `rightMax`, to store the maximum height seen so far from the left and right.
    - Use a variable `waterTrapped` to accumulate the trapped water.

2. **Iterate Until Pointers Meet:**
    - If the height at `left` is less than the height at `right`:
        - Check if `height[left]` is greater than or equal to `leftMax`:
            - Update `leftMax` to `height[left]`.
        - Else:
            - Add the difference between `leftMax` and `height[left]` to `waterTrapped`.
        - Move the `left` pointer one step to the right.
    - If the height at `right` is less than or equal to the height at `left`:
        - Check if `height[right]` is greater than or equal to `rightMax`:
            - Update `rightMax` to `height[right]`.
        - Else:
            - Add the difference between `rightMax` and `height[right]` to `waterTrapped`.
        - Move the `right` pointer one step to the left.

3. **Repeat Until Pointers Meet:**
    - Continue the process until `left` and `right` pointers cross each other.

4. **Return the Result:**
    - The value of `waterTrapped` will be the total amount of trapped water.

### Complexity Analysis:

- **Time Complexity:** O(n)
    - Each element in the array is visited once.
- **Space Complexity:** O(1)
    - Only a few variables are used for computation, regardless of input size.

## Code Implementation

```csharp
namespace LeetCodeProblems.TrappingRainWater;

public class _42_TrappingRainWater {
    public int Trap(int[] height) {
        if (height.Length == 0) {
            return 0;
        }

        int left = 0, right = height.Length - 1;
        int leftMax = 0, rightMax = 0;
        var waterTrapped = 0;

        while (left < right) {
            if (height[left] < height[right]) {
                if (height[left] >= leftMax) {
                    leftMax = height[left];
                } else {
                    waterTrapped += leftMax - height[left];
                }
                left++;
            } else {
                if (height[right] >= rightMax) {
                    rightMax = height[right];
                } else {
                    waterTrapped += rightMax - height[right];
                }
                right--;
            }
        }

        return waterTrapped;
    }
}
```

## Example

### Input:

```plaintext
height = [0,1,0,2,1,0,1,3,2,1,2,1]
```

### Output:

```plaintext
6
```

### Explanation:

- Water trapped at each index:
    - Index 2: 1 unit
    - Index 4: 1 unit
    - Index 5: 2 units
    - Index 6: 1 unit
    - Index 8: 1 unit
- Total = 6 units.

## References:

- [LeetCode Problem #42](https://leetcode.com/problems/trapping-rain-water/)



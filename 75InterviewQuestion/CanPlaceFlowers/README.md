# LeetCode Problem: Can Place Flowers

## Problem Description:
You are given a flowerbed represented as an array containing 0's and 1's, where:
- `0` means an empty plot,
- `1` means the plot is occupied with a flower.

You are also given an integer `n` that represents the number of flowers you need to plant. You cannot plant flowers in adjacent plots (no two flowers can be next to each other). The goal is to determine if you can plant `n` flowers in the flowerbed without violating the no-adjacent-flowers rule.

### Example 1:
**Input:**  
`flowerbed = [1, 0, 0, 0, 1], n = 1`  
**Output:**  
`true`

### Example 2:
**Input:**  
`flowerbed = [1, 0, 0, 0, 1], n = 2`  
**Output:**  
`false`

### Constraints:
- `1 <= flowerbed.length <= 2 * 10^4`
- `flowerbed[i]` is 0 or 1.
- There are no two adjacent flowers in the flowerbed.
- `0 <= n <= flowerbed.length`

---

## Solution Explanation:
We need to check whether we can plant `n` flowers in the flowerbed array while ensuring that no two flowers are adjacent.

### Steps:

1. **Initialize Count:**  
   We start by initializing `count = 0` to track how many flowers we can successfully plant.

2. **Iterate Through Flowerbed:**  
   We iterate through each plot in the flowerbed. For each plot, we check if it's possible to plant a flower:
   - The current plot (`flowerbed[i]`) must be empty (`flowerbed[i] == 0`).
   - The previous plot (`flowerbed[i-1]`) must be empty, or it must be the first plot (i.e., `i == 0`).
   - The next plot (`flowerbed[i+1]`) must be empty, or it must be the last plot (i.e., `i == flowerbed.Length - 1`).
   
   If all conditions are satisfied, we plant a flower by setting `flowerbed[i] = 1` and increment `count` by 1.

3. **Stop Early if Possible:**  
   If at any point `count` becomes greater than or equal to `n`, we can return `true` early since we've successfully planted enough flowers.

4. **Return the Result:**  
   After iterating through the entire flowerbed, we return `true` if we could plant at least `n` flowers; otherwise, we return `false`.

### Edge Cases:
**All plots empty:** If the entire flowerbed consists of 0's, you can plant a flower in every other plot.

Single plot: If flowerbed contains just one plot, and it's empty, you can plant one flower.
Early termination: If enough flowers are planted early, the algorithm stops without checking the entire flowerbed.

**Time and Space Complexity:**
- Time Complexity: O(flowerbed.Length) — We traverse the flowerbed array once.
- Space Complexity: O(1) — We use constant extra space since we modify the flowerbed array in place.


---

## Code Implementation:
```csharp
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        var count = 0;  // Track how many flowers can be planted
        var i = 0;      // Index to traverse the flowerbed
        
        // Traverse through the flowerbed array
        while (i < flowerbed.Length)
        {
            // Check if the current plot can have a flower
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1;  // Plant a flower
                count++;  // Increment the count of planted flowers
            }
            i++;  // Move to the next plot
        }

        // Return true if the count of planted flowers is greater than or equal to n
        return count >= n;
    }
}

  

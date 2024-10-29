## 🎉 Kids and Their Candies: Finding the Sweetest Winners! 🍭

### Problem Statement

You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an
integer extraCandies, denoting the number of extra candies you can distribute. The goal is to determine which kids can
have the greatest number of candies after receiving all the extraCandies.

### Description

The output should be a boolean array result of the same length as candies, where result[i] is true if, after giving the
ith kid all the extra candies, they will have the greatest number of candies among all the kids, or false otherwise.

### Example

**Input**

      candies = [2, 3, 5, 1, 3]
      extraCandies = 3

**Output**

    [result] = [true, true, true, false, true]

### Explanation

- If Kid 1 receives all the extra candies: 2 + 3 = 5 (greatest)
- If Kid 2 receives all the extra candies: 3 + 3 = 6 (greatest)
- If Kid 3 receives all the extra candies: 5 + 3 = 8 (greatest)
- If Kid 4 receives all the extra candies: 1 + 3 = 4 (not the greatest)
- If Kid 5 receives all the extra candies: 3 + 3 = 6 (greatest)

### Approach

1. Find the Maximum Candy Count:
   Identify the maximum number of candies any kid currently has.
2. Calculate New Candy Counts:
   For each kid, calculate their total candies after receiving the extra candies.
3. Determine Results:
   Check if each kid's new total is greater than or equal to the maximum candy count.

### Complexity

- **Time Complexity:**
  O(n), where n is the number of kids.
- **Space Complexity:**
  O(n) for the result array.

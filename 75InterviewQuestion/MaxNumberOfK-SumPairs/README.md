# Max Number of K-Sum Pairs (LeetCode 1679)

## Problem Description

You are given an integer array `nums` and an integer `k`. In one operation, you can pick two numbers from the array
whose sum equals `k` and remove them from the array. Return the **maximum number of operations** you can perform on the
array.

### Example

**Input:** `nums = [1,2,3,4]`, `k = 5`  
**Output:** `2`  
**Explanation:**

- Remove numbers `1` and `4` to get `nums = [2,3]`
- Remove numbers `2` and `3` to get `nums = []`
- Total operations = `2`

**Constraints:**

- `1 <= nums.length <= 10^5`
- `1 <= nums[i] <= 10^9`
- `1 <= k <= 10^9`

## Approach

### Intuition

The problem requires finding pairs that sum up to `k` without reusing elements from previous pairs. To efficiently match
elements, we use a dictionary to track the frequency of each number as we process the array.

### Solution

1. **Frequency Dictionary**: We use a dictionary (`frequencyList`) to track the count of each number in `nums`.
2. **Iterate Through `nums`**:
    - For each element `num`, calculate its required pair value as `k - num`.
    - Check if the pair value exists in `frequencyList`:
        - **If exists and frequency > 0**: We found a valid pair, so we increase the operation count and decrease the
          frequency of the pair value.
        - **If does not exist**: Add `num` to the dictionary or increase its frequency, as it might find a pair later.

### Complexity

- **Time Complexity**: $$O(n)$$ - where \( n \) is the length of `nums`. Each element is processed once.
- **Space Complexity**: $$O(n)$$ - for the dictionary to store frequencies of unique numbers.

## Code

```csharp
public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Dictionary<int, int> frequencyList = new Dictionary<int, int>();
        int numberOfOperations = 0;
        
        foreach (var num in nums) {
            int component = k - num;

            if (frequencyList.ContainsKey(component) && frequencyList[component] > 0) {
                numberOfOperations++;
                frequencyList[component]--;
                
                if (frequencyList[component] == 0) {
                    frequencyList.Remove(component);
                }
            } else {
                if (frequencyList.ContainsKey(num)) {
                    frequencyList[num]++;
                } else {
                    frequencyList[num] = 1;
                }
            }
        }

        return numberOfOperations;
    }
}


	```csharp
     Example 1
    int[] nums = {1, 2, 3, 4};
    int k = 5;
    Solution solution = new Solution();
    Console.WriteLine(solution.MaxOperations(nums, k));  Output: 2



	```csharp
     Example 1
  	int[] nums = {3, 1, 3, 4, 3};
  	k = 6;
  	Console.WriteLine(solution.MaxOperations(nums, k)); Output: 1


## Running the Solution
Compile and run this code in a C# environment or IDE like Visual Studio.
To test different cases, modify the nums array and k value in the example code above.
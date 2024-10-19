## Beats %100 in C#


### Intuition
The goal is to compute the product of all elements in the array except the current one, without using division. We can do this efficiently by calculating two sets of products:
1. **Prefix products**: The product of all elements to the left of the current index.
2. **Suffix products**: The product of all elements to the right of the current index.

By multiplying these two products for each index, we can get the desired result in linear time.

### Approach
1. **Compute Prefix Products**:
   - Initialize `output[0]` as `1` since the first element has no elements to its left.
   - For each element `i`, calculate the product of all the elements before `i` and store it in `output[i]` using the relation:  
     `output[i] = output[i-1] * nums[i-1]`.

2. **Compute Suffix Products and Combine**:
   - Use a variable `right` initialized to `1`, representing the product of all elements to the right of the current index.
   - Traverse the array from the end to the beginning, updating `output[i]` by multiplying it with the `right` value.  
     After updating, set `right = right * nums[i]` to include the current element in the suffix product for the next iteration.

### Complexity
- **Time complexity**:  
  The time complexity is $$O(n)$$ because we traverse the array twice: once to compute the prefix products and once to compute the suffix products.

- **Space complexity**:  
  The space complexity is $$O(1)$$ (ignoring the output array) because only a constant amount of extra space (`right`) is used.  
  If we count the output array, the space complexity becomes $$O(n)$$ as the size of the array depends on the input.


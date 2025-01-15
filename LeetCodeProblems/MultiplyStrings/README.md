# Problem: 43. Multiply Strings

The problem requires multiplying two non-negative integers represented as strings, `num1` and `num2`, and returning the product as a string. The input strings do not contain leading zeros except when the number is 0.

## Approach: Simulated Multiplication Using Arrays

### Steps:
1. **Result Array:**
   - Create an integer array `result` of size `m + n` (where `m` is the length of `num1` and `n` is the length of `num2`) to store intermediate results.

2. **Multiply Digits:**
   - Iterate through each digit of `num1` and `num2` from right to left.
   - Multiply digits `num1[i]` and `num2[j]`.
   - Add the product to `result[i + j + 1]` and update the values at indices `result[i + j + 1]` and `result[i + j]` to account for carries.

3. **Build the Result String:**
   - Convert the `result` array into a string, skipping leading zeros.

4. **Handle Edge Cases:**
   - If the result string is empty (e.g., both inputs are "0"), return "0".

### Complexity Analysis:
- **Time Complexity:** O(m * n)
  - Each digit of `num1` is multiplied with each digit of `num2`.
- **Space Complexity:** O(m + n)
  - The result array is of size `m + n`.

## Code Implementation

```csharp
using System.Text;

namespace LeetCodeProblems.MultiplyStrings;

public class _43_MultiplyStrings {
    public string Multiply(string num1, string num2) {
        int m = num1.Length, n = num2.Length;
        var result = new int[m + n];

        for (var i = m - 1; i >= 0; i--) {
            for (var j = n - 1; j >= 0; j--) {
                var mul = (num1[i] - '0') * (num2[j] - '0');
                var sum = mul + result[i + j + 1];

                result[i + j + 1] = sum % 10;
                result[i + j] += sum / 10;
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (var num in result) {
            if (!(sb.Length == 0 && num == 0)) {
                sb.Append(num);
            }
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
```


### Explanation:
- Perform the multiplication similar to how it is done manually.
- Add the intermediate results at each position and handle carries.

### Intermediate Steps:
1. Multiply 3 (from `num1`) with 6 (from `num2`) and add to `result`.
2. Repeat for all digits and update the carry accordingly.
3. Convert the `result` array to the final string by skipping leading zeros.

## References:
- [LeetCode Problem #43](https://leetcode.com/problems/multiply-strings/)



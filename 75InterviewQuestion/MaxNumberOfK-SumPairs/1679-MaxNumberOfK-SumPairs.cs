namespace _75InterviewQuestion.MaxNumberOfK_SumPairs;

public class _1679_MaxNumberOfK_SumPairs
{
    /*
     * 1679. Max Number of K-Sum Pairs
     *
     * You are given an integer array nums and an integer k.
     * In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.
     * Return the maximum number of operations you can perform on the array.
     *
     * Approach:
     * 1. Initialize a dictionary to store the frequency of each number in the nums array.
     * 2. Initialize a variable, numberOfOperations, to keep track of the number of operations.
     * 3. Iterate over the nums array.
     * 4. For each number, calculate the component (k - num).
     * 5. If the component is present in the dictionary and its frequency is greater than 0, increment the numberOfOperations, decrement the frequency, and remove the component if its frequency becomes 0.
     * 6. If the component is not present in the dictionary, update the frequency of the current number in the dictionary.
     * 7. Return the numberOfOperations.
     *
     * Time complexity: O(n), where n is the length of the nums array.
     * Space complexity: O(n), where n is the length of the nums array.
     */
    public int MaxOperations(int[] nums, int k)
    {
        var frequencyList = new Dictionary<int, int>();
        var numberOfOperations = 0;

        foreach (var num in nums)
        {
            var component = k - num;

            if (frequencyList.ContainsKey(component) && frequencyList[component] > 0)
            {
                numberOfOperations++;
                frequencyList[component]--;
                if (frequencyList[component] == 0) frequencyList.Remove(component);
            }
            else
            {
                if (frequencyList.ContainsKey(num))
                    frequencyList[num]++;
                else
                    frequencyList[num] = 1;
            }
        }

        return numberOfOperations;
    }
}
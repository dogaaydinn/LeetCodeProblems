namespace _75InterviewQuestion.MaxNumberOfK_SumPairs;

public class _1679_MaxNumberOfK_SumPairs {
    public int MaxOperations(int[] nums, int k)
    {
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
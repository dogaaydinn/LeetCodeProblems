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